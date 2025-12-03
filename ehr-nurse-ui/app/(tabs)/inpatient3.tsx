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
import { router, useLocalSearchParams } from "expo-router";

import { theme } from "../../styles/theme";
import { API_BASE_URL } from "./Api_Base_Url";

// Ensure these components exist in your project, otherwise replace with simple Views
import { TabsContainer } from "@/components/ui/tabsContainer";
import { DaysContainer } from "@/components/ui/daysContainer";

// --- Types ---

type PatientCard = {
  id: number;
  name: string;
  age: number | null;
  ward: string;
  bed: string;
  daysInWard: number;
};

// Merged Type: Combines UI needs with Backend Data
type MedicationItem = {
  medicationId: number;
  patientId: number;
  productName: string;
  
  // UI Specific Fields (Mapped or Defaulted)
  form: string;
  quantity: number;
  quantityUnit: string;
  frequencyAmount: number;
  frequencyUnit: string;
  durationAmount: number;
  durationUnit: string;
  route?: string | null;
  instructionPatient?: string | null;
  endDate?: string | null;
  status: string; 
  hasReminder: boolean;
};

function getStr(value: any, fallback: string): string {
  if (Array.isArray(value)) return value[0] ?? fallback;
  if (typeof value === "string") return value;
  return fallback;
}

// Logic to convert "01" -> "2025-12-01"
function buildDateParamFromDay(dayStr: string): string {
  // Hardcoded Year/Month to match your Seed Data (Dec 2025)
  // In a real app, use new Date() logic, but for testing we force the seed month
  const year = 2025;
  const month = 11; // Month is 0-indexed (11 = Dec)
  const day = Number(dayStr);
  const d = new Date(year, month, day, 12, 0, 0); 
  return d.toISOString().split('T')[0]; // Returns YYYY-MM-DD
}

export default function Inpatient3Screen() {
  const params = useLocalSearchParams();

  const [lastSynced, setLastSynced] = useState("");
  // Removed state for patient to prevent infinite loops, replaced with useMemo below
  
  const [selectedTab, setSelectedTab] = useState("Medication");
  const [selectedDay, setSelectedDay] = useState("01"); 

  const [medications, setMedications] = useState<MedicationItem[]>([]);
  const [loading, setLoading] = useState(false);
  const [error, setError] = useState<string | null>(null);
  const [checked, setChecked] = useState<Record<number, boolean>>({});

  const tabs = [
    "Daily monitoring",
    "Medication",
    "Nutrition Intake",
    "Appointments",
  ];

  // Updated days to match December 2025 range
  const days = [
    { day: "Mon", date: "01" }, // Seed Data is here
    { day: "Tue", date: "02" },
    { day: "Wed", date: "03" },
    { day: "Thu", date: "04" },
    { day: "Fri", date: "05" },
    { day: "Sat", date: "06" },
  ];

  useEffect(() => {
    const now = new Date();
    setLastSynced(
      `${now.toLocaleDateString()} , ${now.toLocaleTimeString([], {
        hour: "2-digit",
        minute: "2-digit",
      })}`
    );
  }, []);

  // STABILIZE PATIENT DATA: Use useMemo instead of useEffect+useState to prevent infinite loops
  const patient = useMemo(() => {
    try {
      // Use "101" as default ID to match Seed Data
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
    } catch (e) {
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
    params.daysInWard
  ]);

  // LOAD MEDICATIONS (Merged Logic)
  useEffect(() => {
    if (!patient) return;

    const loadMeds = async () => {
      try {
        setError(null);
        setLoading(true);

        const dateParam = buildDateParamFromDay(selectedDay);
        
        // Use the working URL logic
        const url = `${API_BASE_URL}/api/Inpatients/${patient.id}/medication?date=${dateParam}&status=all`;
        console.log("Fetching Meds:", url);

        const res = await fetch(url);
        
        if (res.ok) {
            const rawData = await res.json();
            
            // MAP Backend Data -> Frontend UI Structure
            // Because backend doesn't send "frequency", "form", etc. yet, we default them.
            const mappedData: MedicationItem[] = Array.isArray(rawData) ? rawData.map((m: any) => ({
                medicationId: m.medicationId,
                patientId: m.patientId,
                productName: m.productName || "Unknown Med",
                
                // Fields from Backend
                quantity: m.quantity || 1,
                quantityUnit: m.quantityUnit || "tab",
                status: m.status?.toLowerCase() || "not_given",
                instructionPatient: m.instructionPatient || "No instructions",
                
                // UI Fields (Defaulted for now until Backend sends them)
                form: m.form || "Tablet", 
                frequencyAmount: 1, 
                frequencyUnit: "Day", 
                durationAmount: 1, 
                durationUnit: "Week", 
                route: "Oral",
                endDate: m.endDate || null,
                hasReminder: false
            })) : [];

            setMedications(mappedData);
            setChecked({});
        } else {
            throw new Error("API Failed");
        }

      } catch (e: any) {
        console.error("Fetch error:", e);
        setMedications([]); 
        setError("Could not load medications. Check server.");
      } finally {
        setLoading(false);
      }
    };

    loadMeds();
  }, [patient, selectedDay]); // Re-run when day changes

  const toggleCheck = (id: number) => {
    setChecked((prev) => ({
      ...prev,
      [id]: !prev[id],
    }));
  };

  const navParams =
    patient && {
      patientId: String(patient.id),
      name: patient.name,
      age: patient.age != null ? String(patient.age) : "",
      ward: patient.ward,
      bed: patient.bed,
      daysInWard: String(patient.daysInWard),
    };

  return (
    <SafeAreaView
      style={styles.safeContainer}
      edges={["top", "left", "right"]}
    >
      <View style={styles.inner}>
        <ScrollView
          style={styles.container}
          contentContainerStyle={{ paddingBottom: 120 }}
          showsVerticalScrollIndicator={false}
        >
          {/* Header */}
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

          {/* Patient Info */}
          <View style={styles.patientInfo}>
            <Image
              source={require("../../assets/images/user.png")}
              style={styles.userIcon}
            />

            <View style={{ flex: 1 }}>
              <Text style={styles.name}>
                {patient?.name ?? "John Smith"} ({patient?.age ?? "?"}yo)
              </Text>

              <View style={{ flexDirection: "row", alignItems: "center" }}>
                <MaterialCommunityIcons
                  name="doctor"
                  size={18}
                  color="#B0B0B0"
                />
                <Text style={[styles.subText, { marginLeft: 6 }]}>
                  Dr. Adamides
                </Text>
              </View>

              <View style={{ flexDirection: "row", alignItems: "center" }}>
                <FontAwesome name="bed" size={18} color="#B0B0B0" />
                <Text style={[styles.subText, { marginLeft: 6 }]}>
                  {patient?.ward ?? "Unassigned"} | {patient?.bed ?? "N/A"}
                </Text>
              </View>
            </View>
          </View>

          {/* Tabs */}
          <TabsContainer
            tabs={tabs}
            selectedTab={selectedTab}
            onSelect={(tab) => {
              setSelectedTab(tab);
              if (!navParams) return;

              // Navigation Logic
              if (tab === "Medication") {
                router.replace({
                  pathname: "/inpatient3", // medication
                  params: navParams,
                });
              }
              if (tab === "Nutrition Intake") {
                router.replace({
                  pathname: "/inpatient4", // nutrition screen
                  params: navParams,
                });
              }
               //if (tab === "Appointments") {
               // router.replace({
                //  pathname: "/inpatient5", // appointments
               // });
             // }
            }}
          />

          {/* Days */}
          <DaysContainer
            days={days}
            selectedDay={selectedDay}
            onSelect={(d) => setSelectedDay(d)}
          />

          <Text style={styles.sectionTitle}>Medication Schedule</Text>
          <View style={styles.line} />

          {/* Content */}
          {loading ? (
            <View style={{ marginTop: 24, alignItems: "center" }}>
              <ActivityIndicator size="large" color={theme.colors.primary} />
            </View>
          ) : medications.length === 0 ? (
            <View style={{ marginTop: 24, alignItems: "center" }}>
              <MaterialIcons
                name="search"
                size={60}
                color={theme.colors.primaryDark}
              />
              <Text style={styles.noMedsText}>No medication for Dec {selectedDay}.</Text>
            </View>
          ) : (
            medications.map((m) => {
              const isChecked =
                checked[m.medicationId] ?? (m.status === "given");

              const doseLine = `${m.quantity} ${m.quantityUnit} — ${m.form}`;

              const endDateStr = m.endDate
                ? new Date(m.endDate).toLocaleDateString()
                : "Ongoing";

              return (
                <View key={m.medicationId} style={styles.medCard}>
                  {/* Top Row */}
                  <View
                    style={{ flexDirection: "row", alignItems: "center" }}
                  >
                    <MaterialCommunityIcons
                      name="pill"
                      size={28}
                      color={theme.colors.primary}
                    />

                    <Text style={[styles.medTitle, { marginLeft: 10 }]}>
                      {m.productName.toUpperCase()}
                    </Text>
                  </View>

                  {/* Dose */}
                  <Text style={styles.medSub}>{doseLine}</Text>

                  <View style={styles.decorativeLine} />

                  {/* Notes */}
                  {m.instructionPatient ? (
                    <Text style={styles.medNote}>
                      • Instructions: {m.instructionPatient}
                    </Text>
                  ) : null}
                  <Text style={styles.medNote}>
                    • End Date: {endDateStr}
                  </Text>

                  {/* Footer */}
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
                      <Text
                        style={[styles.addReminder, { marginLeft: 6 }]}
                      >
                        Add reminder
                      </Text>
                    </View>

                    {/* Checkbox */}
                    <TouchableOpacity
                      onPress={() => toggleCheck(m.medicationId)}
                    >
                      <View
                        style={
                          isChecked
                            ? styles.checkActive
                            : styles.checkInactive
                        }
                      >
                        <MaterialIcons
                          name="check"
                          size={20}
                          color={isChecked ? "#FFFFFF" : "#7E7E7E"}
                        />
                      </View>
                    </TouchableOpacity>
                  </View>
                </View>
              );
            })
          )}

          {error && (
            <Text style={{ color: "red", marginTop: 8, fontSize: 12, textAlign: 'center' }}>
              {error}
            </Text>
          )}
        </ScrollView>
      </View>
    </SafeAreaView>
  );
}

// --- Styles (Kept exactly as requested) ---
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

  noMedsText: {
    marginTop: 8,
    fontSize: 13,
    color: theme.colors.mutedText,
  },

  medCard: {
    backgroundColor: "#FFFFFF",
    borderRadius: 14,
    padding: 16,
    marginBottom: 16,
    shadowColor: "#000",
    shadowOpacity: 0.08,
    shadowRadius: 5,
    shadowOffset: { width: 0, height: 2 },
    elevation: 4,
  },

  medTitle: {
    fontSize: 16,
    fontWeight: "700",
    color: theme.colors.text,
  },

  medSub: {
    color: theme.colors.primary,
    fontWeight: "700",
    marginTop: 10,
  },

  medNote: {
    color: theme.colors.mutedText,
    fontSize: 12,
    marginTop: 2,
  },

  decorativeLine: {
    height: 1,
    backgroundColor: "#d9d9d9",
    width: "100%",
    marginVertical: 8,
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