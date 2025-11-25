import React, { useState, useEffect } from "react";
import {
  View,
  Text,
  StyleSheet,
  ScrollView,
  TextInput,
  Pressable,
  SafeAreaView,
} from "react-native";
import { Ionicons, MaterialCommunityIcons } from "@expo/vector-icons";
import { theme } from "../../styles/theme";
import { router } from "expo-router";

export default function PatientsScreen() {
  const [searchOpen, setSearchOpen] = useState(false);
  const [search, setSearch] = useState("");
  const [lastSynced, setLastSynced] = useState("");

  const patients = [
    { id: 1, name: "John Smith", age: 66, ward: "WARD – 1", room: "101", days: 88 },
    { id: 2, name: "Maria Georgiou", age: 74, ward: "WARD – 2", room: "210", days: 23 },
    { id: 3, name: "Test Patient2", age: 66, ward: "WARD – 1", room: "101", days: 88 },
    { id: 4, name: "Test Patient2", age: 66, ward: "WARD – 1", room: "101", days: 88 },
    { id: 5, name: "Test Patient2", age: 66, ward: "WARD – 1", room: "101", days: 88 },
  ];

  useEffect(() => {
    const now = new Date();
    setLastSynced(`${now.toLocaleDateString()} , ${now.toLocaleTimeString()}`);
  }, []);

  const filteredPatients = patients.filter((p) =>
    p.name.toLowerCase().includes(search.toLowerCase())
  );

  return (
    <SafeAreaView style={styles.screen}>
      <View style={styles.panel}>
        <View style={styles.headerRow}>
          <Pressable onPress={() => router.push("/(tabs)")}>
            <Ionicons name="chevron-back" size={26} color={theme.colors.text} />
          </Pressable>

          {!searchOpen && (
            <Text style={styles.headerTitle}>In Patients</Text>
          )}

          {!searchOpen && (
            <View style={styles.headerIcons}>
              <Pressable onPress={() => setSearchOpen(true)}>
                <Ionicons name="search" size={22} color={theme.colors.text} />
              </Pressable>
            </View>
          )}

          {searchOpen && (
            <View style={styles.searchBar}>
              <Ionicons name="search" size={20} color={theme.colors.mutedText} />

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
                  setSearch("");
                  setSearchOpen(false);
                }}
              >
                <Ionicons name="close" size={22} color={theme.colors.mutedText} />
              </Pressable>
            </View>
          )}
        </View>

        <Text style={styles.lastSynced}>Last synced: {lastSynced}</Text>

        <ScrollView style={{ flex: 1 }} contentContainerStyle={{ paddingBottom: 40 }}>
          {filteredPatients.map((p) => (
            <Pressable key={p.id} style={styles.card}>
              <View style={styles.avatarCircle}>
                <Text style={styles.avatarLetter}>{p.name.charAt(0)}</Text>
              </View>

              <View style={styles.infoArea}>
                <Text style={styles.nameText}>
                  {p.name} ({p.age}yo)
                </Text>

                <View style={styles.row}>
                  <MaterialCommunityIcons
                    name="hospital-building"
                    size={18}
                    color={theme.colors.mutedText}
                  />
                  <Text style={styles.infoText}>{p.ward}</Text>

                  <Text style={styles.separator}>|</Text>

                  <MaterialCommunityIcons
                    name="bed"
                    size={18}
                    color={theme.colors.mutedText}
                  />
                  <Text style={styles.infoText}>{p.room}</Text>
                </View>

                <View style={styles.row}>
                  <Ionicons
                    name="calendar-outline"
                    size={18}
                    color={theme.colors.mutedText}
                  />
                  <Text style={styles.infoText}>{p.days} days</Text>
                </View>
              </View>

              <Ionicons
                name="chevron-forward"
                size={26}
                color={theme.colors.mutedText}
              />
            </Pressable>
          ))}
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
  headerRow: {
    flexDirection: "row",
    alignItems: "center",
  },

  headerTitle: {
    fontSize: theme.font.xl,
    fontWeight: "700",
    color: theme.colors.text,
    marginLeft: theme.spacing.sm,
    flex: 1,
  },

  headerIcons: {
    flexDirection: "row",
    alignItems: "center",
  },

  searchBar: {
    flexDirection: "row",
    flex: 1,
    backgroundColor: theme.colors.inputBg,
    borderRadius: theme.radii.md,
    paddingHorizontal: theme.spacing.md,
    paddingVertical: 6,
    borderWidth: 1,
    borderColor: theme.colors.border,
    marginLeft: theme.spacing.md,
    alignItems: "center",
  },

  searchInput: {
    flex: 1,
    marginLeft: 6,
    color: theme.colors.text,
    fontSize: theme.font.md,
  },

  lastSynced: {
    marginTop: 8,
    marginBottom: theme.spacing.md,
    color: theme.colors.mutedText,
    fontSize: theme.font.sm,
  },

  card: {
    flexDirection: "row",
    alignItems: "center",
    backgroundColor: theme.colors.card,
    padding: theme.spacing.md,
    borderRadius: theme.radii.md,
    borderWidth: 1,
    borderColor: theme.colors.border,
    marginBottom: theme.spacing.md,
  },

  avatarCircle: {
    width: 48,
    height: 48,
    borderRadius: 24,
    backgroundColor: "#e5e7eb",
    justifyContent: "center",
    alignItems: "center",
    marginRight: theme.spacing.md,
  },

  avatarLetter: {
    fontSize: 20,
    fontWeight: "700",
    color: theme.colors.text,
  },

  infoArea: {
    flex: 1,
  },

  nameText: {
    fontWeight: "700",
    fontSize: theme.font.md,
    marginBottom: 3,
  },

  row: {
    flexDirection: "row",
    alignItems: "center",
    marginBottom: 2,
  },

  infoText: {
    marginLeft: 6,
    color: theme.colors.mutedText,
    fontSize: theme.font.sm,
  },

  separator: {
    marginHorizontal: 6,
    color: theme.colors.mutedText,
  },
});
