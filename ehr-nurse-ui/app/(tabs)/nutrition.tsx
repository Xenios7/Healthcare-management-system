import React, { useState, useEffect } from "react";
import {
  View,
  Text,
  StyleSheet,
  ScrollView,
  TextInput,
  Pressable,
  SafeAreaView,
  ActivityIndicator,
  Platform,
} from "react-native";
import { Ionicons, MaterialCommunityIcons } from "@expo/vector-icons";
import { theme } from "../../styles/theme";
import { router } from "expo-router";

const API_BASE_URL = Platform.select({
  web: "http://localhost:5164",
  default: "http://172.22.240.1:5164",
});

type FilterType = "All" | "Not Given" | "Given";

type DayInfo = {
  key: string;
  label: string;
  dayNumber: number;
  isToday: boolean;
};

type MealCard = {
  FoodId: number;
  PatientId: number;
  PatientName: string;
  PatientAge: number | null;
  Ward: string;
  Bed: string;
  DaysInWard: number;
  MealType: string;
  MealName: string;
  Instructions: string | null;
  PortionSize: number | null;
  PortionEatenPercentage: number | null;
  Status: string;
  HasReminder: boolean;
};

function buildDaysAround(date: Date): DayInfo[] {
  const days: DayInfo[] = [];
  for (let offset = -2; offset <= 3; offset++) {
    const d = new Date(date);
    d.setDate(date.getDate() + offset);
    days.push({
      key: d.toISOString().substring(0, 10),
      label: d.toLocaleDateString(undefined, { weekday: "short" }),
      dayNumber: d.getDate(),
      isToday: offset === 0,
    });
  }
  return days;
}

export default function NutritionScreen() {
  const [lastSynced] = useState(new Date());
  const [selectedFilter, setSelectedFilter] = useState<FilterType>("All");
  const [days, setDays] = useState(() => buildDaysAround(new Date()));
  const [selectedDayKey, setSelectedDayKey] = useState(days[2].key);
  const [meals, setMeals] = useState<MealCard[]>([]);
  const [loading, setLoading] = useState(true);
  const [searchOpen, setSearchOpen] = useState(false);
  const [search, setSearch] = useState("");
  const [localChecks, setLocalChecks] = useState<Record<number, boolean>>({});

  const loadMeals = async () => {
    try {
      setLoading(true);
      const status =
        selectedFilter === "All"
          ? "all"
          : selectedFilter === "Given"
          ? "given"
          : "not_given";
      const url = `${API_BASE_URL}/api/Nutrition/schedule?status=${status}&search=${search}`;
      const response = await fetch(url);
      const data = await response.json();
      setMeals(data);
    } catch (err) {
      console.log("Error loading meals:", err);
    } finally {
      setLoading(false);
    }
  };

  useEffect(() => {
    loadMeals();
  }, [selectedDayKey, selectedFilter, search]);

  return (
    <SafeAreaView style={styles.screen}>
      <View style={styles.panel}>
        <ScrollView style={{ flex: 1 }} contentContainerStyle={styles.scrollContent}>
          <View style={styles.headerRow}>
            <Pressable onPress={() => router.push("/(tabs)")}>
              <Ionicons name="chevron-back" size={24} color={theme.colors.text} />
            </Pressable>

            {!searchOpen && (
              <View style={styles.headerTitleBlock}>
                <Text style={styles.headerTitle}>Today's Nutrition Intake</Text>
                <Text style={styles.headerSubtitle}>
                  Last synced: {lastSynced.toLocaleDateString()} ,{" "}
                  {lastSynced.toLocaleTimeString()}
                </Text>
              </View>
            )}

            {!searchOpen && (
              <View style={styles.headerRight}>
                <Pressable onPress={() => setSearchOpen(true)}>
                  <Ionicons name="search-outline" size={24} color={theme.colors.text} />
                </Pressable>
              </View>
            )}

            {searchOpen && (
              <View style={styles.searchBar}>
                <Ionicons name="search" size={18} color={theme.colors.mutedText} />
                <TextInput
                  style={styles.searchInput}
                  placeholder="Search patients..."
                  placeholderTextColor={theme.colors.mutedText}
                  value={search}
                  onChangeText={setSearch}
                  autoFocus
                />
                <Pressable
                  onPress={() => {
                    setSearchOpen(false);
                    setSearch("");
                  }}
                >
                  <Ionicons name="close" size={20} color={theme.colors.mutedText} />
                </Pressable>
              </View>
            )}
          </View>

          <View style={styles.filterRow}>
            {(["All", "Not Given", "Given"] as FilterType[]).map((f) => {
              const active = f === selectedFilter;
              return (
                <Pressable
                  key={f}
                  style={[styles.filterTab, active && styles.filterTabActive]}
                  onPress={() => setSelectedFilter(f)}
                >
                  <Text style={[styles.filterTabText, active && styles.filterTabTextActive]}>
                    {f}
                  </Text>
                </Pressable>
              );
            })}
          </View>

          <View style={{ marginTop: theme.spacing.md, width: "100%" }}>
            <ScrollView
              horizontal
              showsHorizontalScrollIndicator={false}
              contentContainerStyle={styles.dateRowContent}
            >
              {days.map((d) => {
                const active = d.key === selectedDayKey;
                return (
                  <Pressable
                    key={d.key}
                    onPress={() => {
                      setSelectedDayKey(d.key);
                      setDays(buildDaysAround(new Date(d.key)));
                    }}
                    style={[styles.dateCard, active && styles.dateCardActive]}
                  >
                    <Text style={[styles.dateLabel, active && styles.dateLabelActive]}>
                      {d.label}
                    </Text>
                    <Text style={[styles.dateNumber, active && styles.dateNumberActive]}>
                      {d.dayNumber}
                    </Text>
                  </Pressable>
                );
              })}
            </ScrollView>
          </View>

          <View style={styles.mealList}>
            {loading && (
              <ActivityIndicator
                size="large"
                color={theme.colors.primary}
                style={{ marginTop: 40 }}
              />
            )}

            {!loading && meals.length === 0 && (
              <Text style={{ textAlign: "center", marginTop: 30 }}>
                No meals found for this date.
              </Text>
            )}

            {!loading &&
              meals.map((meal) => (
                <View key={meal.FoodId} style={styles.mealCard}>
                  <View style={styles.mealTopRow}>
                    <View style={styles.avatarCircle}>
                      <Text style={styles.avatarInitial}>{meal.PatientName.charAt(0)}</Text>
                    </View>

                    <View style={{ flex: 1 }}>
                      <View
                        style={{
                          flexDirection: "row",
                          justifyContent: "space-between",
                          alignItems: "center",
                        }}
                      >
                        <Text style={styles.mealPatientName}>
                          {meal.PatientName} ({meal.PatientAge ?? "?"}yo)
                        </Text>
                        <Ionicons
                          name="chevron-forward"
                          size={20}
                          color={theme.colors.mutedText}
                        />
                      </View>

                      <View style={styles.mealMetaRow}>
                        <MaterialCommunityIcons
                          name="hospital-building"
                          size={14}
                          color={theme.colors.mutedText}
                        />
                        <Text style={styles.mealMetaText}>WARD – {meal.Ward}</Text>

                        <Text style={{ marginHorizontal: 6, color: theme.colors.mutedText }}>
                          |
                        </Text>

                        <MaterialCommunityIcons
                          name="bed-outline"
                          size={14}
                          color={theme.colors.mutedText}
                        />
                        <Text style={styles.mealMetaText}>{meal.Bed}</Text>
                      </View>

                      <View style={{ flexDirection: "row", alignItems: "center", marginTop: 2 }}>
                        <Ionicons
                          name="calendar-outline"
                          size={14}
                          color={theme.colors.mutedText}
                        />
                        <Text style={styles.mealMetaText}>{meal.DaysInWard}</Text>
                      </View>
                    </View>
                  </View>

                  <View style={styles.topSeparator} />

                  <View style={styles.medInfoBlock}>
                    <View style={styles.medNameRow}>
                      <MaterialCommunityIcons
                        name="silverware-fork-knife"
                        size={18}
                        color={theme.colors.primaryDark}
                        style={{ marginRight: 6 }}
                      />
                      <Text style={styles.medName}>{meal.MealName}</Text>
                    </View>
                    <Text style={styles.doseText}>{meal.MealType}</Text>
                  </View>

                  <View style={styles.mealNotes}>
                    <Text style={styles.mealNotesText}>
                      - Instructions: {meal.Instructions ?? "None"}
                    </Text>
                  </View>

                  <View style={styles.mealBottomRow}>
                    <Pressable style={styles.addReminderWrapper}>
                      <Ionicons
                        name={meal.HasReminder ? "notifications" : "notifications-outline"}
                        size={18}
                        color={theme.colors.primaryDark}
                        style={{ marginRight: 4 }}
                      />
                      <Text
                        style={[
                          styles.addReminderText,
                          meal.HasReminder && styles.addReminderTextActive,
                        ]}
                      >
                        {meal.HasReminder ? "Remove reminder" : "Add reminder"}
                      </Text>
                    </Pressable>

                    <Pressable
                      onPress={() =>
                        setLocalChecks((prev) => ({
                          ...prev,
                          [meal.FoodId]: !prev[meal.FoodId],
                        }))
                      }
                      style={[
                        styles.checkButton,
                        localChecks[meal.FoodId] && styles.checkButtonActive,
                      ]}
                    >
                      {localChecks[meal.FoodId] && (
                        <Ionicons
                          name="checkmark"
                          size={18}
                          color={theme.colors.primaryDark}
                        />
                      )}
                    </Pressable>
                  </View>
                </View>
              ))}
          </View>
        </ScrollView>
      </View>
    </SafeAreaView>
  );
}

const styles = StyleSheet.create({
  screen: {
    flex: 1,
    backgroundColor: theme.colors.card,
  },
  panel: {
    flex: 1,
    backgroundColor: theme.colors.card,
    paddingHorizontal: theme.spacing.lg,
  },
  scrollContent: {
    paddingBottom: theme.spacing.lg,
  },
  headerRow: {
    flexDirection: "row",
    alignItems: "center",
    marginBottom: theme.spacing.md,
  },
  headerTitleBlock: {
    flex: 1,
    marginLeft: theme.spacing.sm,
  },
  headerTitle: {
    fontSize: theme.font.lg,
    fontWeight: "800",
    color: theme.colors.text,
  },
  headerSubtitle: {
    fontSize: theme.font.sm - 2,
    color: theme.colors.mutedText,
  },
  headerRight: {
    flexDirection: "row",
    alignItems: "center",
    marginLeft: theme.spacing.sm,
  },
  searchBar: {
    flexDirection: "row",
    backgroundColor: theme.colors.inputBg,
    borderRadius: theme.radii.md,
    paddingHorizontal: 10,
    paddingVertical: 6,
    borderWidth: 1,
    borderColor: theme.colors.border,
    alignItems: "center",
    flex: 1,
    marginLeft: theme.spacing.sm,
  },
  searchInput: {
    flex: 1,
    marginLeft: 6,
    color: theme.colors.text,
    fontSize: theme.font.md,
  },
  filterRow: {
    flexDirection: "row",
    borderRadius: theme.radii.md,
    backgroundColor: theme.colors.inputBg,
    marginBottom: theme.spacing.sm,
    overflow: "hidden",
  },
  filterTab: {
    flex: 1,
    paddingVertical: 10,
    alignItems: "center",
  },
  filterTabActive: {
    backgroundColor: theme.colors.primary,
  },
  filterTabText: {
    fontSize: theme.font.sm,
    fontWeight: "600",
    color: theme.colors.mutedText,
  },
  filterTabTextActive: {
    color: "#fff",
  },
  dateRowContent: {
    paddingTop: theme.spacing.sm,
    paddingRight: theme.spacing.sm,
  },
  dateCard: {
    minWidth: 64,
    height: 76,
    paddingHorizontal: theme.spacing.md,
    borderRadius: theme.radii.md,
    borderWidth: 1,
    borderColor: theme.colors.border,
    backgroundColor: theme.colors.card,
    justifyContent: "center",
    alignItems: "center",
    marginRight: theme.spacing.sm,
  },
  dateCardActive: {
    backgroundColor: theme.colors.primary,
  },
  dateLabel: {
    fontSize: theme.font.sm - 2,
    color: theme.colors.mutedText,
  },
  dateLabelActive: {
    color: "#fff",
  },
  dateNumber: {
    fontSize: theme.font.md,
    fontWeight: "700",
    marginTop: 4,
    color: theme.colors.text,
  },
  dateNumberActive: {
    color: "#fff",
  },
  mealList: {
    marginTop: theme.spacing.sm,
  },
  mealCard: {
    borderRadius: theme.radii.md,
    borderWidth: 1,
    borderColor: theme.colors.border,
    padding: theme.spacing.md,
    marginBottom: theme.spacing.sm,
    backgroundColor: theme.colors.card,
  },
  mealTopRow: {
    flexDirection: "row",
    alignItems: "flex-start",
  },
  avatarCircle: {
    width: 40,
    height: 40,
    borderRadius: 20,
    backgroundColor: theme.colors.inputBg,
    alignItems: "center",
    justifyContent: "center",
    marginRight: theme.spacing.sm,
  },
  avatarInitial: {
    fontSize: theme.font.md,
    fontWeight: "700",
    color: theme.colors.text,
  },
  mealPatientName: {
    fontSize: theme.font.sm,
    fontWeight: "700",
    color: theme.colors.text,
  },
  mealMetaRow: {
    flexDirection: "row",
    alignItems: "center",
    marginTop: 2,
  },
  mealMetaText: {
    fontSize: theme.font.sm - 2,
    color: theme.colors.mutedText,
  },
  topSeparator: {
    height: 1,
    backgroundColor: theme.colors.border,
    marginVertical: theme.spacing.sm,
  },
  medInfoBlock: {
    marginBottom: theme.spacing.sm,
  },
  medNameRow: {
    flexDirection: "row",
    alignItems: "center",
  },
  medName: {
    fontSize: theme.font.md,
    fontWeight: "700",
    color: theme.colors.text,
  },
  doseText: {
    fontSize: theme.font.sm - 1,
    color: theme.colors.primaryDark,
  },
  mealNotes: {
    marginBottom: theme.spacing.sm,
  },
  mealNotesText: {
    fontSize: theme.font.sm - 2,
    color: theme.colors.mutedText,
  },
  mealBottomRow: {
    flexDirection: "row",
    justifyContent: "space-between",
    borderTopWidth: 1,
    borderTopColor: theme.colors.border,
    paddingTop: theme.spacing.sm,
  },
  addReminderWrapper: {
    flexDirection: "row",
    alignItems: "center",
  },
  addReminderText: {
    fontSize: theme.font.sm,
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
  },
  checkButtonActive: {
    backgroundColor: "#e5f4f1",
  },
});
