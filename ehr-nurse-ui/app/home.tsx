import React from "react";
import {
  View,
  Text,
  StyleSheet,
  ScrollView,
  Pressable,
  SafeAreaView,
} from "react-native";
import { Ionicons, MaterialCommunityIcons } from "@expo/vector-icons";
import { theme } from "../styles/theme";
import { Link } from "expo-router";

export default function HomeScreen() {
  return (
    <SafeAreaView style={styles.screen}>
      <View style={styles.panel}>
        <ScrollView
          style={styles.content}
          contentContainerStyle={{ paddingBottom: theme.spacing.md }}
        >
          <Text style={styles.sectionTitle}>Today's Overview</Text>

          <View style={styles.overviewRow}>
            {overviewItem(0, 15, "Given", "pill", "#e53935", "warning")}
            {overviewItem(3, 15, "Given", "silverware-fork-knife", "#fb8c00", "warning")}
            {overviewItem(15, 15, "Checked", "clipboard-text-outline", theme.colors.primaryDark, "check")}
            {overviewItem(15, 15, "Appointments", "calendar-month-outline", theme.colors.primaryDark, "check")}
          </View>

          <Text style={[styles.sectionTitle, { marginTop: theme.spacing.lg }]}>
            Quick Actions
          </Text>

          <View style={styles.quickActionsRow}>
            <Link href="/qrcode" asChild> 
              <Pressable style={styles.quickActionCard}>
                <View style={styles.quickIconWrapper}>
                  <Ionicons name="qr-code-outline" size={32} color={theme.colors.primaryDark} />
                </View>
                <Text style={styles.quickActionText}>Scan patient</Text>
              </Pressable>
            </Link>

            <View style={{ flex: 1 }} />
          </View>

          <Text style={[styles.sectionTitle, { marginTop: theme.spacing.lg }]}>
            Alerts
          </Text>

          <View style={styles.alertsContainer}>
            {alertItem("Patient #102 missed Paracetamol", "warning")}
            {alertItem("Patient #104 has 3 days since last eaten", "warning")}
            {alertItem("Patient #3278 has missed meds", "warning")}
            {alertItem("Patient #105 is admitted for the last 725 days", "warning")}
            {alertItem("Admin has added a new meeting for you", "info")}
            {alertItem(
              "Nurse Maria is on sick leave. You are replacing Maria for the rest of the week",
              "info"
            )}
            {alertItem(
              "Doctor Kostakis is sick. Doctor Yiannakis is replacing Kostakis for today",
              "info"
            )}
          </View>
        </ScrollView>

        <View style={styles.bottomNav}>
          <Pressable style={styles.bottomItem}>
            <Ionicons name="home" size={26} color={theme.colors.primary} />
          </Pressable>
          <Pressable style={styles.bottomItem}>
            <MaterialCommunityIcons name="clipboard-text-outline" size={26} color={theme.colors.mutedText} />
          </Pressable>
          <Pressable style={styles.bottomItem}>
            <MaterialCommunityIcons name="pill" size={26} color={theme.colors.mutedText} />
          </Pressable>
          <Pressable style={styles.bottomItem}>
            <MaterialCommunityIcons name="silverware-fork-knife" size={26} color={theme.colors.mutedText} />
          </Pressable>
          <Pressable style={styles.bottomItem}>
            <Ionicons name="calendar-outline" size={26} color={theme.colors.mutedText} />
          </Pressable>
        </View>
      </View>
    </SafeAreaView>
  );
}

/* ---------- helper components ---------- */

type OverviewStatus = "warning" | "check" | "none";

function overviewItem(
  current: number,
  total: number,
  label: string,
  icon: keyof typeof MaterialCommunityIcons.glyphMap,
  highlightColor: string,
  status: OverviewStatus
) {
  return (
    <View style={styles.overviewCard}>
      <View style={styles.overviewLeft}>
        <View style={styles.overviewIconCircle}>
          <MaterialCommunityIcons name={icon} size={20} color="#ffffff" />
        </View>

        <View style={styles.overviewTextBlock}>
          <View style={styles.overviewCountRow}>
            <Text style={[styles.overviewCountMain, { color: highlightColor }]}>{current}</Text>
            <Text style={styles.overviewCountSlash}>/{total}</Text>
          </View>

          <Text style={styles.overviewLabel} numberOfLines={2}>
            {label}
          </Text>
        </View>
      </View>

      <View style={styles.overviewRight}>
        {status === "warning" && (
          <Ionicons name="warning" size={18} color="#fbbf24" />
        )}
        {status === "check" && (
          <Ionicons name="checkmark-circle-outline" size={18} color={theme.colors.primary} />
        )}
      </View>
    </View>
  );
}

function alertItem(message: string, type: "warning" | "info" = "warning") {
  const isWarning = type === "warning";
  const iconName = isWarning ? "alert" : "information-outline";
  const iconColor = isWarning ? "#fbbf24" : theme.colors.primary;

  return (
    <View style={styles.alertItem}>
      <MaterialCommunityIcons
        name={iconName}
        size={18}
        color={iconColor}
        style={{ marginRight: theme.spacing.sm }}
      />
      <Text style={styles.alertText}>{message}</Text>
    </View>
  );
}

/* ---------- styles ---------- */

const styles = StyleSheet.create({
  screen: {
    flex: 1,
    backgroundColor: theme.colors.inputBg,
  },
  panel: {
    flex: 1,
    marginHorizontal: theme.spacing.lg,
    marginVertical: theme.spacing.lg,
    borderRadius: theme.radii.lg,
    backgroundColor: theme.colors.card,
    padding: theme.spacing.lg,
    ...theme.shadow.card,
  },
  content: {
    flex: 1,
  },
  sectionTitle: {
    fontSize: theme.font.lg,
    fontWeight: "800",
    marginBottom: theme.spacing.sm,
    color: "rgba(15, 23, 42, 0.85)",
  },
  overviewRow: {
    flexDirection: "row",
    flexWrap: "wrap",
    justifyContent: "space-between",
    paddingHorizontal: theme.spacing.xs,
    marginBottom: theme.spacing.md,
  },
  overviewCard: {
    width: "48%",
    marginBottom: theme.spacing.sm,
    flexDirection: "row",
    alignItems: "center",
    borderRadius: theme.radii.md,
    borderWidth: 1,
    borderColor: theme.colors.border,
    backgroundColor: theme.colors.inputBg,
    paddingVertical: theme.spacing.xs,
    minHeight: 60,
  },
  overviewLeft: {
    flexDirection: "row",
    alignItems: "center",
    flex: 1,
    paddingLeft: theme.spacing.sm,
  },
  overviewRight: {
    width: 28,
    alignItems: "center",
    justifyContent: "center",
    marginRight: theme.spacing.sm,
  },
  overviewIconCircle: {
    width: 30,
    height: 30,
    borderRadius: 15,
    backgroundColor: theme.colors.primary,
    alignItems: "center",
    justifyContent: "center",
    marginRight: theme.spacing.sm,
  },
  overviewTextBlock: {
    flex: 1,
    flexShrink: 1,
  },
  overviewCountRow: {
    flexDirection: "row",
    alignItems: "baseline",
  },
  overviewCountMain: {
    fontSize: theme.font.sm,
    fontWeight: "800",
  },
  overviewCountSlash: {
    fontSize: theme.font.sm,
    fontWeight: "700",
    color: theme.colors.text,
    marginLeft: 2,
  },
  overviewLabel: {
    fontSize: 11,
    lineHeight: 14,
    color: theme.colors.mutedText,
  },
  quickActionsRow: {
    flexDirection: "row",
    marginTop: theme.spacing.xs,
  },
  quickActionCard: {
    flex: 1,
    maxWidth: 220,
    height: 100,
    borderRadius: theme.radii.md,
    borderWidth: 1,
    borderColor: theme.colors.border,
    backgroundColor: theme.colors.card,
    paddingHorizontal: theme.spacing.md,
    paddingVertical: theme.spacing.sm,
    alignItems: "flex-start",
    justifyContent: "space-between",
  },
  quickIconWrapper: {
    width: 36,
    height: 36,
    borderRadius: theme.radii.sm,
    backgroundColor: theme.colors.primary + "22",
    alignItems: "center",
    justifyContent: "center",
    marginBottom: theme.spacing.xs,
  },
  quickActionText: {
    fontSize: theme.font.sm,
    fontWeight: "500",
    color: theme.colors.text,
  },
  alertsContainer: {
    marginTop: theme.spacing.sm,
  },
  alertItem: {
    flexDirection: "row",
    alignItems: "center",
    paddingVertical: 4,
  },
  alertText: {
    flex: 1,
    fontSize: theme.font.sm,
    color: theme.colors.text,
  },
  bottomNav: {
    flexDirection: "row",
    alignItems: "center",
    justifyContent: "space-around",
    paddingVertical: theme.spacing.sm,
    borderTopWidth: 1,
    borderTopColor: theme.colors.border,
    marginTop: theme.spacing.sm,
  },
  bottomItem: {
    flex: 1,
    alignItems: "center",
  },
});
