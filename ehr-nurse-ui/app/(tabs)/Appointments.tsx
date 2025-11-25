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

const FILTERS: AppointmentFilter[] = ['all', 'upcoming', 'completed'];

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

  const [days] = useState<Date[]>(() => buildCalendarDays());
  const [selectedDate, setSelectedDate] = useState<Date | null>(null);

  const [isSearching, setIsSearching] = useState(false);
  const [searchQuery, setSearchQuery] = useState('');

  const selectedScale = useSharedValue(1);

  const patientId = undefined as number | undefined;

  const loadAppointments = useCallback(async () => {
    try {
      setError(null);
      setLoading(true);

      const apiFilter: AppointmentFilter =
        filter === 'upcoming' ? 'all' : filter;

      const data = await getAppointments(apiFilter, patientId);

      if (filter === 'upcoming') {
        setAppointments(data.filter(isUpcomingLike));
      } else if (filter === 'completed') {
        setAppointments(
          data.filter(a => isSameOrAfterToday(new Date(a.startDate))),
        );
      } else {
        setAppointments(data);
      }
    } catch (e: any) {
      setError(e.message ?? 'Failed to load appointments');
    } finally {
      setLoading(false);
    }
  }, [filter, patientId]);

  useEffect(() => {
    loadAppointments();
  }, [loadAppointments]);

  useEffect(() => {
    if (!selectedDate && days.length > 0) {
      setSelectedDate(days[PAST_DAYS]);
    }
  }, [selectedDate, days]);

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

  const handleSearchPress = () => {
    setIsSearching(true);
  };

  const cancelSearch = () => {
    setIsSearching(false);
    setSearchQuery('');
  };

  const onSelectDate = (d: Date) => {
    setSelectedDate(d);
    selectedScale.value = 0.8;
    selectedScale.value = withTiming(1, { duration: 160 });
  };

  const renderFilterButtons = () => (
    <View style={styles.segmentContainer}>
      {FILTERS.map(f => {
        const active = filter === f;
        const label = getFilterLabel(f);

        return (
          <TouchableOpacity
            key={f}
            style={[styles.segmentItem, active && styles.segmentItemActive]}
            onPress={() => {
              setFilter(f);
              setIsSearching(false);
              setSearchQuery('');
            }}
          >
            <Text
              style={[styles.segmentText, active && styles.segmentTextActive]}
            >
              {label}
            </Text>
          </TouchableOpacity>
        );
      })}
    </View>
  );

  const renderDayStrip = () => (
    <View style={styles.dayStripContainer}>
      <FlatList
        horizontal
        data={days}
        keyExtractor={item => item.toISOString()}
        showsHorizontalScrollIndicator={false}
        initialScrollIndex={PAST_DAYS}
        getItemLayout={(_, index) => ({
          length: DAY_ITEM_WIDTH,
          offset: DAY_ITEM_WIDTH * index,
          index,
        })}
        renderItem={({ item: d }) => {
          const active = selectedDate && isSameDay(d, selectedDate);
          return (
            <DayItemAnimated
              date={d}
              isActive={!!active}
              onSelect={() => onSelectDate(d)}
              selectedScale={selectedScale}
            />
          );
        }}
      />
    </View>
  );

  const renderItem = ({ item }: { item: AppointmentPatientDto }) => {
    const dt = new Date(item.startDate);
    const dateStr = dt.toLocaleDateString();
    const timeStr = dt.toLocaleTimeString([], {
      hour: '2-digit',
      minute: '2-digit',
    });

    const rawTitle = item.title || '';
    const baseTitle = rawTitle.split(':')[0];
    const displayTitle = `${baseTitle}`;

    const status = item.statusDisplay ?? 'Scheduled';

    let statusColor = '#16A34A';
    const statusLower = status.toLowerCase();

    if (
      statusLower.includes('did not attend') ||
      statusLower.includes('did not')
    ) {
      statusColor = '#EF4444';
    } else if (statusLower.includes('postponed')) {
      statusColor = '#F59E0B';
    }

    return (
      <View style={styles.card}>
        <Text style={styles.title}>{displayTitle}</Text>

        <View style={styles.statusRow}>
          <Text style={[styles.statusText, { color: statusColor }]}>
            {status}
          </Text>
        </View>

        <View style={styles.infoRow}>
          <Text style={styles.infoLabel}>Date</Text>
          <Text style={styles.infoValue}>{dateStr}</Text>
        </View>

        <View style={styles.infoRow}>
          <Text style={styles.infoLabel}>Time</Text>
          <Text style={styles.infoValue}>{timeStr}</Text>
        </View>

        {item.comments ? (
          <Text style={styles.comments}>{item.comments}</Text>
        ) : null}

        <View style={styles.actionsRow}>
          <TouchableOpacity
            style={[styles.actionButton, styles.dnaButton]}
            onPress={() => handleStatusChange(item.id, 'DNA')}
          >
            <Text style={styles.actionButtonText}>Did not attend</Text>
          </TouchableOpacity>

          <TouchableOpacity
            style={[styles.actionButton, styles.postponedButton]}
            onPress={() => handleStatusChange(item.id, 'POSTPONED')}
          >
            <Text style={styles.actionButtonText}>Postponed</Text>
          </TouchableOpacity>

          <TouchableOpacity
            style={[styles.actionButton, styles.completedButton]}
            onPress={() => handleStatusChange(item.id, 'COMPLETED')}
          >
            <Text style={styles.actionButtonText}>Completed</Text>
          </TouchableOpacity>
        </View>
      </View>
    );
  };

  let appointmentsByDate: AppointmentPatientDto[] = [];

  if (filter === 'all') {
    appointmentsByDate = selectedDate
      ? appointments.filter(a =>
          isSameDay(new Date(a.startDate), selectedDate),
        )
      : [];
  } else if (selectedDate && isSameOrAfterToday(selectedDate)) {
    appointmentsByDate = appointments;
  } else {
    appointmentsByDate = [];
  }

  const visibleAppointments =
    isSearching && searchQuery.trim().length > 0
      ? appointmentsByDate.filter(a =>
          (a.title || '')
            .toLowerCase()
            .includes(searchQuery.trim().toLowerCase()),
        )
      : appointmentsByDate;

  const placeholderText = `Search ${getFilterLabel(
    filter,
  ).toLowerCase()} appointments`;

  return (
    <View style={styles.container}>
      <View style={styles.header}>
        <View>
          <Text style={styles.headerTitle}>Your Appointments</Text>
          <Text style={styles.headerSubtitle}>
            Last synced: {new Date().toLocaleDateString()}{' '}
            {new Date().toLocaleTimeString([], {
              hour: '2-digit',
              minute: '2-digit',
            })}
          </Text>
        </View>

        <View style={styles.headerIcons}>
          <TouchableOpacity
            style={styles.headerIcon}
            onPress={handleSearchPress}
          >
            <Icon name="search" size={18} color="#111827" />
          </TouchableOpacity>
        </View>
      </View>

      {renderFilterButtons()}

      {isSearching && (
        <View style={styles.searchRow}>
          <TextInput
            style={styles.searchInput}
            placeholder={placeholderText}
            value={searchQuery}
            onChangeText={setSearchQuery}
          />
          <TouchableOpacity style={styles.searchCancel} onPress={cancelSearch}>
            <Text style={styles.searchCancelText}>Cancel</Text>
          </TouchableOpacity>
        </View>
      )}

      {renderDayStrip()}

      {loading && !refreshing ? (
        <View style={styles.center}>
          <ActivityIndicator />
        </View>
      ) : (
        <FlatList
          data={visibleAppointments}
          keyExtractor={item => item.id.toString()}
          renderItem={renderItem}
          contentContainerStyle={
            visibleAppointments.length === 0
              ? styles.emptyContainer
              : styles.listContent
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

      <View style={styles.bottomNav}>
        <Link href="/home" asChild>
          <TouchableOpacity style={styles.bottomItem}>
            <Ionicons
              name="home"
              size={26}
              color={theme.colors.mutedText}
            />
          </TouchableOpacity>
        </Link>

        <TouchableOpacity style={styles.bottomItem}>
          <MaterialCommunityIcons
            name="clipboard-text-outline"
            size={26}
            color={theme.colors.mutedText}
          />
        </TouchableOpacity>

        <TouchableOpacity style={styles.bottomItem}>
          <MaterialCommunityIcons
            name="pill"
            size={26}
            color={theme.colors.mutedText}
          />
        </TouchableOpacity>

        <TouchableOpacity style={styles.bottomItem}>
          <MaterialCommunityIcons
            name="silverware-fork-knife"
            size={26}
            color={theme.colors.mutedText}
          />
        </TouchableOpacity>

        <TouchableOpacity style={styles.bottomItem}>
          <Ionicons
            name="calendar-outline"
            size={26}
            color={theme.colors.primary}
          />
        </TouchableOpacity>
      </View>
    </View>
  );
}

const styles = StyleSheet.create({
  container: {
    flex: 1,
    paddingTop: 24,
    paddingHorizontal: 16,
    backgroundColor: '#F4F6F8',
  },
  center: { flex: 1, justifyContent: 'center', alignItems: 'center' },

  header: {
    flexDirection: 'row',
    alignItems: 'center',
    justifyContent: 'space-between',
    marginBottom: 16,
  },
  headerTitle: {
    fontSize: 22,
    fontWeight: '700',
    color: '#111827',
  },
  headerSubtitle: {
    marginTop: 4,
    fontSize: 11,
    color: '#6B7280',
  },
  headerIcons: {
    flexDirection: 'row',
    alignItems: 'center',
  },
  headerIcon: {
    width: 32,
    height: 32,
    borderRadius: 10,
    borderWidth: 1,
    borderColor: '#D1D5DB',
    marginLeft: 8,
    alignItems: 'center',
    justifyContent: 'center',
    backgroundColor: '#FFFFFF',
  },

  segmentContainer: {
    flexDirection: 'row',
    alignSelf: 'center',
    backgroundColor: '#E5E7EB',
    borderRadius: 24,
    padding: 2,
    marginBottom: 16,
  },
  segmentItem: {
    paddingHorizontal: 18,
    paddingVertical: 6,
    borderRadius: 20,
    justifyContent: 'center',
    alignItems: 'center',
  },
  segmentItemActive: {
    backgroundColor: '#0EAD9A',
  },
  segmentText: {
    fontSize: 12,
    color: '#4B5563',
    fontWeight: '500',
  },
  segmentTextActive: {
    color: '#FFFFFF',
  },

  searchRow: {
    flexDirection: 'row',
    alignItems: 'center',
    marginBottom: 8,
  },
  searchInput: {
    flex: 1,
    backgroundColor: '#FFFFFF',
    borderRadius: 12,
    paddingHorizontal: 12,
    paddingVertical: 8,
    fontSize: 14,
    borderWidth: 1,
    borderColor: '#E5E7EB',
  },
  searchCancel: {
    marginLeft: 8,
  },
  searchCancelText: {
    fontSize: 14,
    color: '#0EAD9A',
    fontWeight: '500',
  },

  dayStripContainer: {
    marginBottom: 16,
  },
  dayItem: {
    width: 70,
    paddingVertical: 8,
    marginRight: 8,
    borderRadius: 16,
    backgroundColor: '#FFFFFF',
    justifyContent: 'center',
    alignItems: 'center',
  },
  dayItemActive: {
    backgroundColor: '#0EAD9A',
  },
  dayName: {
    fontSize: 11,
    color: '#6B7280',
  },
  dayNameActive: {
    color: '#FFFFFF',
  },
  dayNumber: {
    fontSize: 16,
    fontWeight: '700',
    color: '#111827',
  },
  dayNumberActive: {
    color: '#FFFFFF',
  },
  monthName: {
    fontSize: 11,
    color: '#6B7280',
  },
  monthNameActive: {
    color: '#FFFFFF',
  },

  listContent: {
    paddingBottom: 96,
  },

  card: {
    backgroundColor: '#FFFFFF',
    borderRadius: 16,
    padding: 14,
    marginBottom: 12,
    shadowColor: '#000',
    shadowOpacity: 0.06,
    shadowRadius: 6,
    shadowOffset: { width: 0, height: 2 },
    elevation: 2,
  },
  title: {
    fontSize: 15,
    fontWeight: '700',
    marginBottom: 8,
    color: '#111827',
  },

  statusRow: {
    marginBottom: 8,
  },
  statusText: {
    fontSize: 14,
    fontWeight: '700',
  },

  infoRow: {
    flexDirection: 'row',
    justifyContent: 'space-between',
    marginBottom: 4,
  },
  infoLabel: {
    fontSize: 12,
    color: '#6B7280',
  },
  infoValue: {
    fontSize: 12,
    color: '#111827',
    fontWeight: '500',
  },

  comments: {
    marginTop: 8,
    fontSize: 12,
    color: '#6B7280',
  },

  actionsRow: {
    flexDirection: 'row',
    justifyContent: 'space-between',
    marginTop: 12,
  },
  actionButton: {
    flex: 1,
    marginHorizontal: 3,
    paddingVertical: 8,
    borderRadius: 10,
    alignItems: 'center',
  },
  actionButtonText: {
    fontSize: 11,
    color: '#FFFFFF',
    fontWeight: '600',
  },
  completedButton: {
    backgroundColor: '#10B981',
  },
  postponedButton: {
    backgroundColor: '#F59E0B',
  },
  dnaButton: {
    backgroundColor: '#EF4444',
  },

  emptyContainer: {
    flexGrow: 1,
    justifyContent: 'center',
    alignItems: 'center',
  },
  emptyText: {
    color: '#6B7280',
  },

  errorBar: {
    backgroundColor: '#EF4444',
    padding: 8,
  },
  errorText: {
    color: 'white',
    textAlign: 'center',
    fontSize: 12,
  },

  bottomNav: {
    flexDirection: 'row',
    alignItems: 'center',
    justifyContent: 'space-around',
    borderTopWidth: 1,
    borderTopColor: theme.colors.border,
    marginTop: 8,
    paddingVertical: theme.spacing.sm,
    backgroundColor: theme.colors.card,
  },
  bottomItem: {
    flex: 1,
    alignItems: 'center',
  },
});