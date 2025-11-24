import React, { useEffect, useState, useCallback } from 'react';
import {
  View,
  Text,
  FlatList,
  TouchableOpacity,
  ActivityIndicator,
  RefreshControl,
  StyleSheet,
  TextInput,
} from 'react-native';

import Animated, {
  useSharedValue,
  useAnimatedStyle,
  withTiming,
  SharedValue,
} from 'react-native-reanimated';

import Icon from 'react-native-vector-icons/Feather';
import { Ionicons, MaterialCommunityIcons } from '@expo/vector-icons';
import { Link } from 'expo-router';

import {
  getAppointments,
  markCompleted,
  markPostponed,
  markDoNotAttempt,
  AppointmentPatientDto,
  AppointmentFilter,
} from '../utils/appointmentsApi';
import { theme } from '../../styles/theme';

const FILTERS: AppointmentFilter[] = ['upcoming', 'completed', 'completed'];

const PAST_DAYS = 30;
const FUTURE_DAYS = 120;
const DAY_ITEM_WIDTH = 78;

function buildCalendarDays(): Date[] {
  const today = new Date();
  const days: Date[] = [];

  for (let i = PAST_DAYS; i > 0; i--) {
    const d = new Date(today);
    d.setDate(today.getDate() - i);
    days.push(d);
  }

  for (let i = 0; i < FUTURE_DAYS; i++) {
    const d = new Date(today);
    d.setDate(today.getDate() + i);
    days.push(d);
  }

  return days;
}

function isSameDay(a: Date, b: Date) {
  return (
    a.getFullYear() === b.getFullYear() &&
    a.getMonth() === b.getMonth() &&
    a.getDate() === b.getDate()
  );
}

function getFilterLabel(f: AppointmentFilter) {
  if (f === 'all') return 'All';
  if (f === 'upcoming') return 'Upcoming';
  if (f === 'completed') return 'Completed';
  return f;
}

function startOfDay(date: Date) {
  const d = new Date(date);
  d.setHours(0, 0, 0, 0);
  return d;
}

function isSameOrAfterToday(date: Date) {
  const today = startOfDay(new Date());
  const d = startOfDay(date);
  return d.getTime() >= today.getTime();
}

function isUpcomingLike(a: AppointmentPatientDto) {
  const s = (a.statusDisplay || '').toLowerCase();

  if (s.includes('completed')) return false;
  if (s.includes('did not attend') || s.includes('did not') || s.includes('dna'))
    return false;

  if (!isSameOrAfterToday(new Date(a.startDate))) return false;

  return true;
}

type DayItemAnimatedProps = {
  date: Date;
  isActive: boolean;
  onSelect: () => void;
  selectedScale: SharedValue<number>;
};

const DayItemAnimated: React.FC<DayItemAnimatedProps> = ({
  date,
  isActive,
  onSelect,
  selectedScale,
}) => {
  const animatedStyle = useAnimatedStyle(() => ({
    transform: [{ scale: isActive ? selectedScale.value : 1 }],
    opacity: isActive ? selectedScale.value : 0.85,
  }));

  const monthStr = date.toLocaleDateString(undefined, { month: 'short' });

  return (
    <Animated.View style={animatedStyle}>
      <TouchableOpacity
        style={[styles.dayItem, isActive && styles.dayItemActive]}
        onPress={onSelect}
      >
        <Text style={[styles.dayName, isActive && styles.dayNameActive]}>
          {date.toLocaleDateString(undefined, { weekday: 'short' })}
        </Text>

        <Text style={[styles.dayNumber, isActive && styles.dayNumberActive]}>
          {date.getDate()}
        </Text>

        <Text style={[styles.monthName, isActive && styles.monthNameActive]}>
          {monthStr}
        </Text>
      </TouchableOpacity>
    </Animated.View>
  );
};

export default function AppointmentsScreen() {
  const [filter, setFilter] = useState<AppointmentFilter>('upcoming');
  const [appointments, setAppointments] = useState<AppointmentPatientDto[]>([]);
  const [loading, setLoading] = useState(false);
  const [refreshing, setRefreshing] = useState(false);
  const [error, setError] = useState<string | null>(null);

  // TODO: wire this from your auth / user context
  const patientId = undefined as number | undefined; 

  const loadAppointments = useCallback(async () => {
    try {
      setError(null);
      setLoading(true);
      const data = await getAppointments(filter, patientId);
      setAppointments(data);
    } catch (e: any) {
      setError(e.message ?? 'Failed to load appointments');
    } finally {
      setLoading(false);
    }
  }, [filter, patientId]);

  useEffect(() => {
    loadAppointments();
  }, [loadAppointments]);

  const onRefresh = useCallback(async () => {
    try {
      setRefreshing(true);
      await loadAppointments();
    } finally {
      setRefreshing(false);
    }
  }, [loadAppointments]);

  const handleStatusChange = async (
    id: number,
    action: 'COMPLETED' | 'POSTPONED' | 'DNA',
  ) => {
    try {
      setError(null);

      if (action === 'COMPLETED') {
        await markCompleted(id);
      } else if (action === 'POSTPONED') {
        await markPostponed(id);
      } else {
        await markDoNotAttempt(id);
      }

      await loadAppointments();
    } catch (e: any) {
      setError(e.message ?? 'Failed to update appointment');
    }
  };

  const renderFilterButtons = () => (
    <View style={styles.filterRow}>
      {FILTERS.map(f => (
        <TouchableOpacity
          key={f}
          style={[
            styles.filterButton,
            filter === f && styles.filterButtonActive,
          ]}
          onPress={() => setFilter(f)}
        >
          <Text
            style={[
              styles.filterButtonText,
              filter === f && styles.filterButtonTextActive,
            ]}
          >
            {f.toUpperCase()}
          </Text>
        </TouchableOpacity>
      ))}
    </View>
  );

  const renderItem = ({ item }: { item: AppointmentPatientDto }) => {
    const date = new Date(item.startDate);

    return (
      <View style={styles.card}>
        <Text style={styles.title}>{item.title}</Text>
        <Text style={styles.date}>
          {date.toLocaleDateString()} {date.toLocaleTimeString()}
        </Text>
        {item.comments ? (
          <Text style={styles.comments}>{item.comments}</Text>
        ) : null}
        <Text style={styles.status}>
          Status:{' '}
          <Text style={styles.statusValue}>
            {item.statusDisplay ?? 'Scheduled'}
          </Text>
        </Text>

        <View style={styles.actionsRow}>
          <TouchableOpacity
            style={[styles.actionButton, styles.completedButton]}
            onPress={() => handleStatusChange(item.id, 'COMPLETED')}
          >
            <Text style={styles.actionButtonText}>Completed</Text>
          </TouchableOpacity>

          <TouchableOpacity
            style={[styles.actionButton, styles.postponedButton]}
            onPress={() => handleStatusChange(item.id, 'POSTPONED')}
          >
            <Text style={styles.actionButtonText}>Postponed</Text>
          </TouchableOpacity>

          <TouchableOpacity
            style={[styles.actionButton, styles.dnaButton]}
            onPress={() => handleStatusChange(item.id, 'DNA')}
          >
            <Text style={styles.actionButtonText}>Do not attempt</Text>
          </TouchableOpacity>
        </View>
      </View>
    );
  };

  return (
    <View style={styles.container}>
      {renderFilterButtons()}

      {loading && !refreshing ? (
        <View style={styles.center}>
          <ActivityIndicator />
        </View>
      ) : (
        <FlatList
          data={appointments}
          keyExtractor={item => item.id.toString()}
          renderItem={renderItem}
          contentContainerStyle={
            appointments.length === 0 ? styles.emptyContainer : undefined
          }
          refreshControl={
            <RefreshControl refreshing={refreshing} onRefresh={onRefresh} />
          }
          ListEmptyComponent={
            !loading ? (
              <Text style={styles.emptyText}>No appointments found.</Text>
            ) : null
          }
        />
      )}

      {error && (
        <View style={styles.errorBar}>
          <Text style={styles.errorText}>{error}</Text>
        </View>
      )}
    </View>
  );
}

const styles = StyleSheet.create({
  container: { flex: 1, paddingTop: 40, paddingHorizontal: 12 },
  center: { flex: 1, justifyContent: 'center', alignItems: 'center' },

  filterRow: {
    flexDirection: 'row',
    justifyContent: 'center',
    marginBottom: 12,
  },
  filterButton: {
    paddingHorizontal: 12,
    paddingVertical: 6,
    marginHorizontal: 4,
    borderRadius: 16,
    borderWidth: 1,
    borderColor: '#ccc',
  },
  filterButtonActive: {
    backgroundColor: '#007AFF',
    borderColor: '#007AFF',
  },
  filterButtonText: { fontSize: 12, color: '#333' },
  filterButtonTextActive: { color: 'white', fontWeight: '600' },

  card: {
    backgroundColor: 'white',
    borderRadius: 12,
    padding: 12,
    marginBottom: 10,
    elevation: 2,
    shadowColor: '#000',
    shadowOpacity: 0.1,
    shadowRadius: 4,
    shadowOffset: { width: 0, height: 2 },
  },
  title: { fontSize: 16, fontWeight: '600', marginBottom: 4 },
  date: { fontSize: 13, color: '#666', marginBottom: 4 },
  comments: { fontSize: 13, color: '#444', marginBottom: 6 },
  status: { fontSize: 13, color: '#555', marginBottom: 8 },
  statusValue: { fontWeight: '600' },

  actionsRow: {
    flexDirection: 'row',
    justifyContent: 'space-between',
  },
  actionButton: {
    flex: 1,
    marginHorizontal: 3,
    paddingVertical: 6,
    borderRadius: 8,
    alignItems: 'center',
  },
  actionButtonText: { fontSize: 12, color: 'white', fontWeight: '600' },
  completedButton: { backgroundColor: '#34C759' },
  postponedButton: { backgroundColor: '#FF9500' },
  dnaButton: { backgroundColor: '#FF3B30' },

  emptyContainer: {
    flexGrow: 1,
    justifyContent: 'center',
    alignItems: 'center',
  },
  emptyText: { color: '#666' },

  errorBar: {
    position: 'absolute',
    bottom: 0,
    left: 0,
    right: 0,
    backgroundColor: '#ff3b30',
    padding: 8,
  },
  errorText: { color: 'white', textAlign: 'center', fontSize: 12 },
});
