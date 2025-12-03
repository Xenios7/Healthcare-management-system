import React, { useEffect, useState, useCallback } from "react";
import {
  View,
  Text,
  FlatList,
  TouchableOpacity,
  ActivityIndicator,
  StyleSheet,
  TextInput,
  RefreshControl,
  useWindowDimensions,
} from "react-native";

import Animated, {
  useSharedValue,
  useAnimatedStyle,
  withTiming,
  SharedValue,
} from "react-native-reanimated";

import FeatherIcon from "react-native-vector-icons/Feather";
import { Ionicons, MaterialCommunityIcons } from "@expo/vector-icons";
import { router } from "expo-router";
import { SafeAreaView } from "react-native-safe-area-context";
import { theme } from "../../styles/theme";
import {
  getMedicationSchedule,
  MedicationFilter,
  MedicationListItemDto,
} from "../utils/medicationsApi";

const PAST_DAYS = 30;
const FUTURE_DAYS = 120;

function buildCalendarDays(): Date[] {
  const today = new Date();
  const days: Date[] = [];

  for (let i = PAST_DAYS; i > 0; i--) {
    const d = new Date(today);
    d.setDate(today.getDate() - i);
    days.push(d);
  }

  for (let i = 0; i <= FUTURE_DAYS; i++) {
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

function getFilterLabel(f: MedicationFilter) {
  if (f === "all") return "All";
  if (f === "not_given") return "Not Given";
  if (f === "given") return "Given";
  return f;
}

type DayItemAnimatedProps = {
  date: Date;
  isActive: boolean;
  onSelect: () => void;
  selectedScale: SharedValue<number>;
  width: number;
};

const DayItemAnimated: React.FC<DayItemAnimatedProps> = ({
  date,
  isActive,
  onSelect,
  selectedScale,
  width,
}) => {
  const animatedStyle = useAnimatedStyle(() => ({
    transform: [{ scale: isActive ? selectedScale.value : 1 }],
    opacity: isActive ? selectedScale.value : 0.85,
  }));

  const monthStr = date.toLocaleDateString(undefined, { month: "short" });

  return (
    <Animated.View style={[animatedStyle, { width }]}>
      <TouchableOpacity
        style={[styles.dayItem, isActive && styles.dayItemActive]}
        onPress={onSelect}
      >
        <Text style={[styles.dayName, isActive && styles.dayNameActive]}>
          {date.toLocaleDateString(undefined, { weekday: "short" })}
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

export default function MedicationScreen() {
  const [filter, setFilter] = useState<MedicationFilter>("all");
  const [meds, setMeds] = useState<MedicationListItemDto[]>([]);
  const { width: windowWidth } = useWindowDimensions();
  const dayWidth = Math.min(82, (windowWidth - 32) / 4.5);
  const [loading, setLoading] = useState(false);
  const [refreshing, setRefreshing] = useState(false);
  const [error, setError] = useState<string | null>(null);

  const [days] = useState<Date[]>(() => buildCalendarDays());
  const [selectedDate, setSelectedDate] = useState<Date | null>(null);

  const [isSearching, setIsSearching] = useState(false);
  const [searchQuery, setSearchQuery] = useState("");

  const selectedScale = useSharedValue(1);
  const [lastSynced] = useState(new Date());

  const [localChecks, setLocalChecks] = useState<Record<number, boolean>>({});

  const loadMeds = useCallback(
    async (isRefresh = false) => {
      if (!selectedDate) return;

      try {
        setError(null);
        if (!isRefresh) setLoading(true);

        const data = await getMedicationSchedule(
          filter,
          selectedDate,
          searchQuery
        );

        setMeds(data);
      } catch (e: any) {
        console.log("Error loading meds", e);
        setError(e?.message ?? "Failed to load medications");
        setMeds([]);
      } finally {
        if (!isRefresh) setLoading(false);
      }
    },
    [filter, selectedDate, searchQuery]
  );

  useEffect(() => {
    if (!selectedDate && days.length > 0) {
      setSelectedDate(days[PAST_DAYS]);
    }
  }, [selectedDate, days]);

  useEffect(() => {
    if (selectedDate) {
      loadMeds();
    }
  }, [selectedDate, filter, searchQuery, loadMeds]);

  const onRefresh = useCallback(async () => {
    try {
      setRefreshing(true);
      await loadMeds(true);
    } finally {
      setRefreshing(false);
    }
  }, [loadMeds]);

  const handleSearchPress = () => {
    setIsSearching(true);
  };

  const cancelSearch = () => {
    setIsSearching(false);
    setSearchQuery("");
  };

  const onSelectDate = (d: Date) => {
    setSelectedDate(d);
    selectedScale.value = 0.8;
    selectedScale.value = withTiming(1, { duration: 160 });
  };

  const toggleReminder = (medicationId: number) => {
    setMeds((prev) =>
      prev.map((m) =>
        m.medicationId === medicationId
          ? { ...m, hasReminder: !m.hasReminder }
          : m
      )
    );
  };

  const renderFilterButtons = () => (
    <View style={styles.segmentContainer}>
      {(["all", "not_given", "given"] as MedicationFilter[]).map((f) => {
        const active = filter === f;
        const label = getFilterLabel(f);

        return (
          <TouchableOpacity
            key={f}
            style={[styles.segmentItem, active && styles.segmentItemActive]}
            onPress={() => {
              setFilter(f);
              setIsSearching(false);
              setSearchQuery("");
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
        keyExtractor={(item) => item.toISOString()}
        showsHorizontalScrollIndicator={false}
        initialScrollIndex={PAST_DAYS}
        getItemLayout={(_, index) => ({
          length: dayWidth,
          offset: dayWidth * index,
          index,
        })}
        contentContainerStyle={{ paddingRight: 12 }}
        renderItem={({ item: d }) => {
          const active = selectedDate && isSameDay(d, selectedDate);
          return (
            <DayItemAnimated
              date={d}
              isActive={!!active}
              onSelect={() => onSelectDate(d)}
              selectedScale={selectedScale}
              width={dayWidth}
            />
          );
        }}
      />
    </View>
  );

  const renderMedItem = ({ item: med }: { item: MedicationListItemDto }) => {
    const isChecked = !!localChecks[med.medicationId];

    return (
      <View style={styles.medCard}>
        <View style={styles.medTopRow}>
          <View style={styles.avatarCircle}>
            <Text style={styles.avatarInitial}>
              {med.patientName.charAt(0)}
            </Text>
          </View>

          <View style={{ flex: 1 }}>
            <View
              style={{
                flexDirection: "row",
                justifyContent: "space-between",
                alignItems: "center",
              }}
            >
              <Text style={styles.patientName} numberOfLines={1}>
                {med.patientName} ({med.patientAge ?? "?"}yo)
              </Text>

              <Ionicons
                name="chevron-forward"
                size={20}
                color={theme.colors.mutedText}
              />
            </View>

            <View style={styles.patientMetaRow}>
              <MaterialCommunityIcons
                name="hospital-building"
                size={14}
                color={theme.colors.mutedText}
              />
              <Text style={styles.patientMetaText}>WARD – {med.ward}</Text>

              <Text
                style={{
                  marginHorizontal: 6,
                  color: theme.colors.mutedText,
                }}
              >
                |
              </Text>

              <MaterialCommunityIcons
                name="bed-outline"
                size={14}
                color={theme.colors.mutedText}
              />
              <Text style={styles.patientMetaText}>{med.bed}</Text>
            </View>

            <View
              style={{ flexDirection: "row", alignItems: "center", marginTop: 2 }}
            >
              <Ionicons
                name="calendar-outline"
                size={14}
                color={theme.colors.mutedText}
              />
              <Text style={styles.patientMetaText}>
                {med.daysInWard} days
              </Text>
            </View>
          </View>
        </View>

        <View style={styles.topSeparator} />

        <View style={styles.medInfoBlock}>
          <View style={styles.medNameRow}>
            <MaterialCommunityIcons
              name="pill"
              size={18}
              color={theme.colors.primaryDark}
              style={{ marginRight: 6 }}
            />
            <Text style={styles.medName}>{med.productName}</Text>
          </View>
          <Text style={styles.doseText}>
            {med.quantity} {med.quantityUnit} • {med.frequencyAmount}{" "}
            {med.frequencyUnit}
          </Text>
        </View>

        <View style={styles.medNotes}>
          <Text style={styles.medNotesText}>
            - Instructions: {med.instructionPatient ?? "None"}
          </Text>
          <Text style={styles.medNotesText}>
            - End Date: {med.endDate ? med.endDate.slice(0, 10) : "n/a"}
          </Text>
        </View>

        <View style={styles.medBottomRow}>
          <TouchableOpacity
            style={styles.addReminderWrapper}
            onPress={() => toggleReminder(med.medicationId)}
          >
            <Ionicons
              name={med.hasReminder ? "notifications" : "notifications-outline"}
              size={18}
              color={theme.colors.primaryDark}
              style={{ marginRight: 4 }}
            />
            <Text
              style={[
                styles.addReminderText,
                med.hasReminder && styles.addReminderTextActive,
              ]}
            >
              {med.hasReminder ? "Remove reminder" : "Add reminder"}
            </Text>
          </TouchableOpacity>

          <TouchableOpacity
            onPress={() =>
              setLocalChecks((prev) => ({
                ...prev,
                [med.medicationId]: !prev[med.medicationId],
              }))
            }
            style={[
              styles.checkButton,
              isChecked && styles.checkButtonActive,
            ]}
          >
            {isChecked && (
              <Ionicons name="checkmark" size={18} color="#FFFFFF" />
            )}
          </TouchableOpacity>
        </View>
      </View>
    );
  };

  const placeholderText = `Search ${getFilterLabel(filter).toLowerCase()} medications`;
  const visibleMeds = meds;

  return (
    <SafeAreaView
      style={styles.safeContainer}
      edges={["top", "left", "right"]}
    >
      <View style={styles.inner}>
        <View style={styles.header}>
          <View style={{ flexDirection: "row", alignItems: "center" }}>
            <TouchableOpacity
              style={{ marginRight: 8 }}
              onPress={() => router.replace("/home")}
            >
              <Ionicons name="chevron-back" size={22} color="#111827" />
            </TouchableOpacity>

            <View>
              <Text style={styles.headerTitle}>Medication</Text>
              <Text style={styles.headerSubtitle}>
                Last synced: {lastSynced.toLocaleDateString()} ,{" "}
                {lastSynced.toLocaleTimeString()}
              </Text>
            </View>
          </View>

          <View style={styles.headerIcons}>
            <TouchableOpacity
              style={styles.headerIcon}
              onPress={handleSearchPress}
            >
              <FeatherIcon name="search" size={18} color="#111827" />
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
            data={visibleMeds}
            keyExtractor={(item) => item.medicationId.toString()}
            renderItem={renderMedItem}
            contentContainerStyle={
              visibleMeds.length === 0
                ? styles.emptyContainer
                : styles.listContent
            }
            refreshControl={
              <RefreshControl refreshing={refreshing} onRefresh={onRefresh} />
            }
            ListEmptyComponent={
              !loading ? (
                <Text style={styles.emptyText}>
                  No medications found for this date.
                </Text>
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
    </SafeAreaView>
  );
}

const styles = StyleSheet.create({
  safeContainer: {
    flex: 1,
    backgroundColor: "#F4F6F8",
  },
  inner: {
    flex: 1,
    paddingTop: 8,
    paddingHorizontal: 16,
    maxWidth: 600,
    alignSelf: "center",
    width: "100%",
  },
  container: {
    flex: 1,
  },
  center: { flex: 1, justifyContent: "center", alignItems: "center" },

  header: {
    flexDirection: "row",
    alignItems: "center",
    justifyContent: "space-between",
    marginBottom: 16,
  },
  headerTitle: {
    fontSize: 22,
    fontWeight: "700",
    color: "#111827",
  },
  headerSubtitle: {
    marginTop: 4,
    fontSize: 11,
    color: "#6B7280",
  },
  headerIcons: {
    flexDirection: "row",
    alignItems: "center",
  },
  headerIcon: {
    width: 32,
    height: 32,
    borderRadius: 10,
    borderWidth: 1,
    borderColor: "#D1D5DB",
    marginLeft: 8,
    alignItems: "center",
    justifyContent: "center",
    backgroundColor: "#FFFFFF",
  },

  segmentContainer: {
    flexDirection: "row",
    alignSelf: "center",
    backgroundColor: "#E5E7EB",
    borderRadius: 24,
    padding: 2,
    marginBottom: 16,
  },
  segmentItem: {
    paddingHorizontal: 18,
    paddingVertical: 6,
    borderRadius: 20,
    justifyContent: "center",
    alignItems: "center",
  },
  segmentItemActive: {
    backgroundColor: "#0EAD9A",
  },
  segmentText: {
    fontSize: 12,
    color: "#4B5563",
    fontWeight: "500",
  },
  segmentTextActive: {
    color: "#FFFFFF",
  },

  searchRow: {
    flexDirection: "row",
    alignItems: "center",
    marginBottom: 8,
  },
  searchInput: {
    flex: 1,
    backgroundColor: "#FFFFFF",
    borderRadius: 12,
    paddingHorizontal: 12,
    paddingVertical: 8,
    fontSize: 14,
    borderWidth: 1,
    borderColor: "#E5E7EB",
  },
  searchCancel: {
    marginLeft: 8,
  },
  searchCancelText: {
    fontSize: 14,
    color: "#0EAD9A",
    fontWeight: "500",
  },

  dayStripContainer: {
    marginBottom: 16,
  },
  dayItem: {
    paddingVertical: 8,
    marginRight: 8,
    borderRadius: 16,
    backgroundColor: "#FFFFFF",
    justifyContent: "center",
    alignItems: "center",
  },
  dayItemActive: {
    backgroundColor: "#0EAD9A",
  },
  dayName: {
    fontSize: 11,
    color: "#6B7280",
  },
  dayNameActive: {
    color: "#FFFFFF",
  },
  dayNumber: {
    fontSize: 16,
    fontWeight: "700",
    color: "#111827",
  },
  dayNumberActive: {
    color: "#FFFFFF",
  },
  monthName: {
    fontSize: 11,
    color: "#6B7280",
  },
  monthNameActive: {
    color: "#FFFFFF",
  },

  listContent: {
    paddingBottom: 120,
  },
  emptyContainer: {
    flexGrow: 1,
    justifyContent: "center",
    alignItems: "center",
    paddingBottom: 120,
  },
  emptyText: {
    color: "#6B7280",
  },

  medCard: {
    backgroundColor: "#FFFFFF",
    borderRadius: 16,
    padding: 14,
    marginBottom: 12,
    shadowColor: "#000",
    shadowOpacity: 0.06,
    shadowRadius: 6,
    shadowOffset: { width: 0, height: 2 },
    elevation: 2,
  },
  medTopRow: {
    flexDirection: "row",
    alignItems: "flex-start",
  },
  avatarCircle: {
    width: 40,
    height: 40,
    borderRadius: 20,
    backgroundColor: "#E5E7EB",
    alignItems: "center",
    justifyContent: "center",
    marginRight: 10,
  },
  avatarInitial: {
    fontSize: 16,
    fontWeight: "700",
    color: "#111827",
  },
  patientName: {
    fontSize: 15,
    fontWeight: "700",
    color: "#111827",
  },
  patientMetaRow: {
    flexDirection: "row",
    alignItems: "center",
    marginTop: 2,
  },
  patientMetaText: {
    fontSize: 11,
    color: "#6B7280",
    marginLeft: 4,
  },
  topSeparator: {
    height: 1,
    backgroundColor: "#E5E7EB",
    marginVertical: 10,
  },
  medInfoBlock: {
    marginBottom: 8,
  },
  medNameRow: {
    flexDirection: "row",
    alignItems: "center",
  },
  medName: {
    fontSize: 15,
    fontWeight: "700",
    color: "#111827",
  },
  doseText: {
    marginTop: 2,
    fontSize: 12,
    color: "#0EAD9A",
  },
  medNotes: {
    marginBottom: 8,
  },
  medNotesText: {
    fontSize: 11,
    color: "#6B7280",
  },
  medBottomRow: {
    flexDirection: "row",
    justifyContent: "space-between",
    borderTopWidth: 1,
    borderTopColor: "#E5E7EB",
    paddingTop: 8,
    alignItems: "center",
  },
  addReminderWrapper: {
    flexDirection: "row",
    alignItems: "center",
  },
  addReminderText: {
    fontSize: 12,
    color: theme.colors.primaryDark,
  },
  addReminderTextActive: {
    fontWeight: "800",
  },

  checkButton: {
    width: 28,
    height: 28,
    borderRadius: 6,
    borderWidth: 2,
    borderColor: theme.colors.primary,
    alignItems: "center",
    justifyContent: "center",
    backgroundColor: "#FFFFFF",
  },
  checkButtonActive: {
    backgroundColor: theme.colors.primary,
    borderColor: theme.colors.primary,
  },

  errorBar: {
    backgroundColor: "#EF4444",
    padding: 8,
  },
  errorText: {
    color: "white",
    textAlign: "center",
    fontSize: 12,
  },
});
