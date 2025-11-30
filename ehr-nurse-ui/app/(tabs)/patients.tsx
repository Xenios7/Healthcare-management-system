import React, { useEffect, useMemo, useState } from "react";
import {
  View,
  Text,
  StyleSheet,
  ScrollView,
  TextInput,
  TouchableOpacity,
} from "react-native";
import { Ionicons, MaterialCommunityIcons } from "@expo/vector-icons";
import FeatherIcon from "react-native-vector-icons/Feather";
import { router } from "expo-router";
import { SafeAreaView } from "react-native-safe-area-context";
import { theme } from "../../styles/theme";
import { API_BASE_URL } from "./Api_Base_Url";

type PatientCard = {
  id: number;
  name: string;
  age: number | null;
  ward: string;
  bed: string;
  daysInWard: number;
};

export default function PatientsScreen() {
  const [searchOpen, setSearchOpen] = useState(false);
  const [search, setSearch] = useState("");
  const [lastSynced, setLastSynced] = useState("");
  const [patients, setPatients] = useState<PatientCard[]>([]);

  useEffect(() => {
    const now = new Date();
    setLastSynced(
      `${now.toLocaleDateString()} , ${now.toLocaleTimeString([], {
        hour: "2-digit",
        minute: "2-digit",
      })}`
    );
  }, []);

  useEffect(() => {
    const loadPatients = async () => {
      try {
        const url = `${API_BASE_URL}/api/Patients`;
        const res = await fetch(url);
        const data = (await res.json()) as PatientCard[];
        setPatients(data);
      } catch (e) {
        setPatients([
          {
            id: 1,
            name: "Test Patient2",
            age: 66,
            ward: "WARD - 1",
            bed: "101",
            daysInWard: 88,
          },
          {
            id: 2,
            name: "John Smith",
            age: 74,
            ward: "WARD - 2",
            bed: "210",
            daysInWard: 23,
          },
          {
            id: 3,
            name: "Maria Georgiou",
            age: 80,
            ward: "WARD - 3",
            bed: "305",
            daysInWard: 5,
          },
        ]);
      }
    };

    loadPatients();
  }, []);

  const filteredPatients = useMemo(
    () =>
      patients.filter((p) =>
        p.name.toLowerCase().includes(search.trim().toLowerCase())
      ),
    [patients, search]
  );

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
              <Ionicons
                name="chevron-back"
                size={24}
                color={theme.colors.text}
              />
            </TouchableOpacity>

            <View>
              <Text style={styles.headerTitle}>In Patients</Text>
              <Text style={styles.headerSubtitle}>
                Last synced: {lastSynced}
              </Text>
            </View>
          </View>

          <View style={styles.headerIcons}>
            {!searchOpen && (
              <TouchableOpacity
                style={styles.headerIcon}
                onPress={() => setSearchOpen(true)}
              >
                <FeatherIcon name="search" size={18} color={theme.colors.text} />
              </TouchableOpacity>
            )}

            <TouchableOpacity
              style={styles.headerIcon}
              onPress={() => router.push("/qrcode")}
            >
              <MaterialCommunityIcons
                name="qrcode-scan"
                size={20}
                color={theme.colors.text}
              />
            </TouchableOpacity>
          </View>
        </View>

        {searchOpen && (
          <View style={styles.searchRow}>
            <TextInput
              style={styles.searchInput}
              placeholder="Search patients..."
              value={search}
              onChangeText={setSearch}
            />
            <TouchableOpacity
              style={styles.searchCancel}
              onPress={() => {
                setSearch("");
                setSearchOpen(false);
              }}
            >
              <Text style={styles.searchCancelText}>Cancel</Text>
            </TouchableOpacity>
          </View>
        )}

        <ScrollView
          style={{ flex: 1 }}
          contentContainerStyle={{ paddingBottom: 110 }}
          showsVerticalScrollIndicator={false}
        >
          {filteredPatients.map((p) => (
            <TouchableOpacity key={p.id} style={styles.card}>
              <View style={styles.avatarCircle}>
                <Text style={styles.avatarLetter}>
                  {p.name.charAt(0).toUpperCase()}
                </Text>
              </View>

              <View style={styles.infoArea}>
                <Text style={styles.nameText}>
                  {p.name} ({p.age ?? "?"}yo)
                </Text>

                <View style={styles.row}>
                  <MaterialCommunityIcons
                    name="hospital-building"
                    size={16}
                    color={theme.colors.mutedText}
                  />
                  <Text style={styles.infoText}>
                    {p.ward} | {p.bed}
                  </Text>

                  <Text style={styles.separator}>|</Text>

                  <MaterialCommunityIcons
                    name="account-arrow-right-outline"
                    size={16}
                    color={theme.colors.mutedText}
                  />
                  <Text style={styles.infoText}>1</Text>
                </View>

                <View style={styles.row}>
                  <MaterialCommunityIcons
                    name="calendar-blank"
                    size={16}
                    color={theme.colors.mutedText}
                  />
                  <Text style={styles.infoText}>{p.daysInWard} days</Text>
                </View>
              </View>

              <Ionicons
                name="chevron-forward"
                size={26}
                color={theme.colors.mutedText}
              />
            </TouchableOpacity>
          ))}
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

  header: {
    flexDirection: "row",
    alignItems: "center",
    justifyContent: "space-between",
    marginBottom: 12,
  },
  headerTitle: {
    fontSize: 22,
    fontWeight: "700",
    color: theme.colors.text,
  },
  headerSubtitle: {
    marginTop: 4,
    fontSize: 11,
    color: theme.colors.mutedText,
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
    color: theme.colors.primary,
    fontWeight: "500",
  },

  card: {
    flexDirection: "row",
    alignItems: "center",
    backgroundColor: "#FFFFFF",
    padding: 14,
    borderRadius: 16,
    marginBottom: 10,
    shadowColor: "#000",
    shadowOpacity: 0.05,
    shadowRadius: 5,
    shadowOffset: { width: 0, height: 2 },
    elevation: 2,
  },
  avatarCircle: {
    width: 56,
    height: 56,
    borderRadius: 28,
    backgroundColor: "#10B981",
    justifyContent: "center",
    alignItems: "center",
    marginRight: 12,
  },
  avatarLetter: {
    fontSize: 24,
    fontWeight: "700",
    color: "#FFFFFF",
  },
  infoArea: {
    flex: 1,
  },
  nameText: {
    fontWeight: "700",
    fontSize: 14,
    marginBottom: 4,
    color: theme.colors.text,
  },
  row: {
    flexDirection: "row",
    alignItems: "center",
    marginBottom: 2,
  },
  infoText: {
    marginLeft: 6,
    color: theme.colors.mutedText,
    fontSize: 12,
  },
  separator: {
    marginHorizontal: 6,
    color: theme.colors.mutedText,
  },
});
