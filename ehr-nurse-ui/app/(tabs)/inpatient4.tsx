import React, { useEffect, useState, useMemo } from "react";
import {
  View,
  Text,
  StyleSheet,
  Image,
  ScrollView,
  TouchableOpacity,
  ActivityIndicator,
} from "react-native";
import {
  MaterialIcons,
  MaterialCommunityIcons,
  FontAwesome,
} from "@expo/vector-icons";
import { SafeAreaView } from "react-native-safe-area-context";
import { theme } from "../../styles/theme";

import { TabsContainer } from "@/components/ui/tabsContainer";
import { DaysContainer } from "@/components/ui/daysContainer";

import { router, useLocalSearchParams } from "expo-router";
import { API_BASE_URL } from "./Api_Base_Url";

type PatientCard = {
  id: number;
  name: string;
  age: number | null;
  ward: string;
  bed: string;
  daysInWard: number;
};

type NutritionItem = {
  foodId: number;
  patientId: number;
  patientName: string;
  patientAge: number | null;
  ward: string;
  bed: string;
  daysInWard: number;
  mealType: string;
  mealName: string;
  instructions: string | null;
  portionSize: number | null;
  portionEatenPercentage: number | null;
  status: string;
  hasReminder: boolean;
  onSetDateTime: string;
};

function getStr(value: any, fallback: string): string {
  if (Array.isArray(value)) return value[0] ?? fallback;
  if (typeof value === "string") return value;
  return fallback;
}

// Fixed date logic to match Dec 2025 seed data
function buildDateParamFromDay(dayStr: string): string {
  const year = 2025;
  const month = 11; // Dec
  const day = Number(dayStr);
  const d = new Date(year, month, day, 12, 0, 0); 
  return d.toISOString().split('T')[0];
}

export default function Inpatient4Screen() {
  const params = useLocalSearchParams();

  const [selectedTab, setSelectedTab] = useState("Nutrition Intake");
  // Default to "01" for seed data
  const [selectedDay, setSelectedDay] = useState("01");
  const [checked, setChecked] = useState<boolean[]>([]);
  const [lastSynced, setLastSynced] = useState("");

  const [meals, setMeals] = useState<NutritionItem[]>([]);
  const [loading, setLoading] = useState(false);
  const [error, setError] = useState<string | null>(null);

  const tabs = [
    "Daily monitoring",
    "Medication",
    "Nutrition Intake",
    "Appointments",
  ];

  // Updated days to match December 2025 range
  const days = [
    { day: "Mon", date: "01" },
    { day: "Tue", date: "02" },
    { day: "Wed", date: "03" },
    { day: "Thu", date: "04" },
    { day: "Fri", date: "05" },
    { day: "Sat", date: "06" },
  ];

  const toggleCheck = (index: number) => {
    setChecked((prev) => {
      const updated = [...prev];
      updated[index] = !updated[index];
      return updated;
    });
  };

  useEffect(() => {
    const now = new Date();
    setLastSynced(
      `${now.toLocaleDateString()} , ${now.toLocaleTimeString([], {
        hour: "2-digit",
        minute: "2-digit",
      })}`
    );
  }, []);

  // FIX: Use useMemo to prevent infinite loop
  const patient = useMemo(() => {
    try {
      const idStr = getStr(
        (params as any).patientId ?? (params as any).id,
        "101"
      );
      const name = getStr((params as any).name, "John Smith");
      const ageStr = getStr((params as any).age, "66");
      const ward = getStr((params as any).ward, "WARD - 1");
      const bed = getStr((params as any).bed, "101");
      const daysStr = getStr((params as any).daysInWard, "0");

      return {
        id: Number(idStr),
        name,
        age: Number(ageStr),
        ward,
        bed,
        daysInWard: Number(daysStr),
      };
    } catch {
      return {
        id: 101,
        name: "John Smith",
        age: 66,
        ward: "Unassigned",
        bed: "N/A",
        daysInWard: 0,
      };
    }
  }, [
    params.patientId,
    params.id,
    params.name,
    params.age,
    params.ward,
    params.bed,
    params.daysInWard,
  ]);

  const navParams =
    patient && {
      patientId: String(patient.id),
      name: patient.name,
      age: patient.age != null ? String(patient.age) : "",
      ward: patient.ward,
      bed: patient.bed,
      daysInWard: String(patient.daysInWard),
    };

  useEffect(() => {
    if (!patient) return;

    const loadMeals = async () => {
      try {
        setError(null);
        setLoading(true);

        const dateParam = buildDateParamFromDay(selectedDay);
        const url = `${API_BASE_URL}/api/Inpatients/${patient.id}/nutrition?date=${dateParam}&status=all`;
        
        console.log("Fetching Nutrition:", url);
        const res = await fetch(url);
        
        if (res.ok) {
            const data = (await res.json()) as any[];
            
            // Map backend data to UI structure
            const mappedMeals: NutritionItem[] = data.map((n) => ({
                foodId: n.foodId,
                patientId: n.patientId,
                patientName: n.patientName,
                patientAge: n.patientAge,
                ward: n.ward,
                bed: n.bed,
                daysInWard: n.daysInWard,
                // Map fields from your updated Service
                mealType: n.mealType || "Unknown", // Title (e.g. OATMEAL)
                mealName: n.mealName || "",
                instructions: n.instructions || "", // Body (e.g. BREAKFAST)
                portionSize: n.portionSize,
                portionEatenPercentage: n.portionEatenPercentage,
                status: n.status,
                hasReminder: n.hasReminder,
                onSetDateTime: n.onSetDateTime
            }));

            setMeals(mappedMeals);
            // Initialize checkboxes based on data length
            setChecked(new Array(mappedMeals.length).fill(false));
        } else {
            throw new Error("API Failed");
        }
      } catch (e) {
        console.error(e);
        // Demo fallback
        setMeals([
          {
            foodId: 1,
            patientId: patient.id,
            patientName: patient.name,
            patientAge: patient.age,
            ward: patient.ward,
            bed: patient.bed,
            daysInWard: patient.daysInWard,
            mealType: "BREAKFAST",
            mealName: "CHICKEN WITH RICE",
            instructions: "Put them in the mixer. Serve cold",
            portionSize: 250,
            portionEatenPercentage: 100,
            status: "not_given",
            hasReminder: false,
            onSetDateTime: new Date().toISOString()
          },
        ]);
        setError("Showing demo nutrition data (API error).");
      } finally {
        setLoading(false);
      }
    };

    loadMeals();
  }, [patient, selectedDay]);

  return (
    <SafeAreaView style={styles.safeContainer} edges={["top", "left", "right"]}>
      <View style={styles.inner}>
      <ScrollView
        style={styles.container}
        contentContainerStyle={{ paddingBottom: 120 }}
      >
        {/* header*/}
        <View style={styles.header}>
          <TouchableOpacity onPress={() => router.back()}>
            <MaterialIcons
              name="arrow-back-ios"
              size={20}
              color={theme.colors.text}
            />
          </TouchableOpacity>
          <Text style={styles.headerTitle}>Patient Details</Text>
        </View>

        <Text style={styles.syncedText}>Last synced: {lastSynced}</Text>

        {/* patient info - top section */}
        <View style={styles.patientInfo}>
          <Image
            source={require("../../assets/images/user.png")}
            style={styles.userIcon}
          />

          <View style={{ flex: 1 }}>
            <Text style={styles.name}>
              {patient?.name ?? "Test Patient2"} (
              {patient?.age ?? "?"}
              yo)
            </Text>

            <View style={{ flexDirection: "row", alignItems: "center" }}>
              <MaterialCommunityIcons name="doctor" size={18} color="#B0B0B0" />
              <Text style={[styles.subText, { marginLeft: 6 }]}>
                Dr. Adamides
              </Text>
            </View>

            <View style={{ flexDirection: "row", alignItems: "center" }}>
              <FontAwesome name="bed" size={18} color="#B0B0B0" />
              <Text style={[styles.subText, { marginLeft: 6 }]}>
                {patient?.ward ?? "Ward - 1"} | {patient?.bed ?? "101"} |{" "}
                {patient?.daysInWard ?? 0} days
              </Text>
            </View>
          </View>
        </View>

        {/* tabs */}
        <TabsContainer
          tabs={tabs}
          selectedTab={selectedTab}
          onSelect={(tab) => {
            setSelectedTab(tab);

            if (!navParams) return;

            if (tab === "Daily monitoring") {
              router.replace({
                pathname: "/inpatients2-1" as any,
                params: navParams,
              });
              return;
            }

            if (tab === "Medication") {
              router.replace({
                pathname: "/inpatient3" as any,
                params: navParams,
              });
              return;
            }

            // Already here
            if (tab === "Nutrition Intake") {
               return;
            }

            if (tab === "Appointments") {
              router.replace({
                pathname: "/inpatient5" as any,
                params: navParams,
              });
              return;
            }
          }}
        />

        {/* days section */}
        <DaysContainer
          days={days}
          selectedDay={selectedDay}
          onSelect={setSelectedDay}
        />

        <Text style={styles.sectionTitle}>Nutrition Schedule</Text>
        <View style={styles.line} />

        {loading ? (
          <View style={{ marginTop: 24, alignItems: "center" }}>
            <ActivityIndicator color={theme.colors.primary} />
          </View>
        ) : meals.length === 0 ? (
          <View style={{ marginTop: 24, alignItems: "center" }}>
            <MaterialIcons
              name="search"
              size={60}
              color={theme.colors.primaryDark}
            />
            <Text style={{ marginTop: 8, color: theme.colors.mutedText }}>
              No meals found for Dec {selectedDay}.
            </Text>
          </View>
        ) : (
          meals.map((meal, i) => (
            <View key={meal.foodId ?? i} style={styles.mealCard}>
              {/* top row */}
              <View style={{ flexDirection: "row", alignItems: "center" }}>
                <MaterialCommunityIcons
                  name="silverware-fork-knife"
                  size={30}
                  color={theme.colors.primary}
                />

                {/* meal title */}
                <Text style={[styles.mealTitle, { marginLeft: 10 }]}>
                  {meal.mealType.toUpperCase()}
                </Text>
              </View>

              {/* which meal (e.g. BREAKFAST) */}
              <Text style={styles.mealSubtitle}>
                {meal.instructions ? meal.instructions.toUpperCase() : "MEAL"}
              </Text>

              <View style={styles.decorativeLine} />

              {/* notes for meal */}
              <Text style={styles.mealNote}>
                • Time: {meal.onSetDateTime ? new Date(meal.onSetDateTime).toLocaleTimeString([], {hour: '2-digit', minute:'2-digit'}) : "TBD"}
              </Text>
              <Text style={styles.mealNote}>
                • Instructions: {meal.mealName || "Standard"}
              </Text>
              <Text style={styles.mealNote}>
                • Portion:{" "}
                {meal.portionSize != null ? `${meal.portionSize}g` : "n/a"}
                {meal.portionEatenPercentage != null
                  ? ` • Eaten: ${meal.portionEatenPercentage}%`
                  : ""}
              </Text>

              {/* reminder and checkbox */}
              <View style={styles.cardFooter}>
                <View
                  style={{
                    flex: 1,
                    flexDirection: "row",
                    justifyContent: "center",
                    alignItems: "center",
                  }}
                >
                  <MaterialIcons
                    name="notifications-none"
                    size={20}
                    color={theme.colors.primary}
                  />
                  <Text style={[styles.addReminder, { marginLeft: 6 }]}>
                    Add reminder
                  </Text>
                </View>

                <TouchableOpacity onPress={() => toggleCheck(i)}>
                  <View
                    style={checked[i] ? styles.checkActive : styles.checkInactive}
                  >
                    <MaterialIcons
                      name="check"
                      size={20}
                      color={checked[i] ? "#FFFFFF" : "#7E7E7E"}
                    />
                  </View>
                </TouchableOpacity>
              </View>
            </View>
          ))
        )}

        {error && (
          <Text style={{ color: "red", marginTop: 8, fontSize: 12, textAlign:'center' }}>
            {error}
          </Text>
        )}
      </ScrollView>
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
    backgroundColor: theme.colors.bg,
    padding: theme.spacing.md,
  },

  header: {
    flexDirection: "row",
    alignItems: "center",
    marginBottom: theme.spacing.xs,
  },
  headerTitle: {
    fontSize: theme.font.lg,
    fontWeight: "700",
    marginLeft: theme.spacing.xs,
    color: theme.colors.text,
  },
  syncedText: {
    fontSize: theme.font.sm,
    color: theme.colors.mutedText,
    marginBottom: theme.spacing.md,
  },

  patientInfo: {
    flexDirection: "row",
    alignItems: "center",
    marginBottom: theme.spacing.lg,
  },
  userIcon: {
    width: 60,
    height: 60,
    marginRight: theme.spacing.md,
  },
  name: {
    fontSize: theme.font.md,
    fontWeight: "700",
    color: theme.colors.text,
    marginBottom: 3,
  },
  subText: {
    fontSize: theme.font.sm,
    color: theme.colors.mutedText,
  },

  sectionTitle: {
    fontSize: theme.font.md,
    fontWeight: "600",
    marginBottom: 4,
  },
  line: {
    height: 1,
    backgroundColor: theme.colors.border,
    marginBottom: theme.spacing.lg,
  },

  mealCard: {
    backgroundColor: "#FFF",
    borderRadius: 14,
    padding: 16,
    marginBottom: 16,
    shadowColor: "#000",
    shadowOpacity: 0.08,
    shadowRadius: 5,
    shadowOffset: { width: 0, height: 2 },
    elevation: 4,
  },
  mealTitle: {
    fontSize: 16,
    fontWeight: "700",
    color: theme.colors.text,
  },

  mealSubtitle: {
    color: theme.colors.primary,
    fontWeight: "700",
    marginTop: 10,
    marginLeft: 0,
  },

  decorativeLine: {
    height: 1,
    backgroundColor: "#d9d9d9",
    width: "100%",
    marginVertical: 8,
    marginLeft: 0,
  },

  mealNote: {
    color: theme.colors.mutedText,
    fontSize: 12,
    marginTop: 2,
  },

  cardFooter: {
    marginTop: 12,
    flexDirection: "row",
    alignItems: "center",
  },

  addReminder: {
    color: theme.colors.primary,
    fontWeight: "600",
  },
  checkInactive: {
    width: 34,
    height: 34,
    borderRadius: 8,
    backgroundColor: "#E6E6E6",
    borderWidth: 2,
    borderColor: "#B5B5B5",
    justifyContent: "center",
    alignItems: "center",
  },

  checkActive: {
    width: 34,
    height: 34,
    borderRadius: 8,
    backgroundColor: theme.colors.primary,
    borderWidth: 2,
    borderColor: theme.colors.primary,
    justifyContent: "center",
    alignItems: "center",
  },
});