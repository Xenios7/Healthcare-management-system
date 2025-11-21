import React, { useState, useEffect } from "react";
import {
  View,
  Text,
  StyleSheet,
  ScrollView,
  Pressable,
} from "react-native";
import { Ionicons, MaterialCommunityIcons } from "@expo/vector-icons";
import { theme } from "../styles/theme";
import { Link, router } from "expo-router";
import AsyncStorage from "@react-native-async-storage/async-storage";
import { SafeAreaView } from "react-native-safe-area-context";

export default function HomeScreen() {
  const [userName, setUserName] = useState<string>("User");

  // 1ο κουτάκι: μικρό "Log out"
  const [showLogoutMenu, setShowLogoutMenu] = useState(false);
  // 2ο κουτάκι: confirm μήνυμα
  const [showConfirm, setShowConfirm] = useState(false);

  useEffect(() => {
    const loadUserName = async () => {
      try {
        const storedName = await AsyncStorage.getItem("user_first_name");
        if (storedName) setUserName(storedName);
      } catch (e) {
        console.log("Failed to load user name", e);
      }
    };

    loadUserName();
  }, []);

  const handleLogout = async () => {
    try {
      await AsyncStorage.multiRemove([
        "user_first_name",
        "auth_token",
        "user_id",
      ]);
    } catch (e) {
      console.log("Failed to clear storage on logout", e);
    }

    router.replace("/login");
  };

  const closeAllLogoutUi = () => {
    setShowLogoutMenu(false);
    setShowConfirm(false);
  };

  return (
    <SafeAreaView
      style={styles.screen}
      edges={["top", "bottom", "left", "right"]}
    >
      <View style={styles.panel}>
        <ScrollView
          style={styles.content}
          contentContainerStyle={[
            styles.contentContainer,
            { paddingBottom: theme.spacing.lg + 60 },
          ]}
        >
          {/* ---------- HEADER ---------- */}
          <View style={styles.headerRow}>
            <Pressable
              onPress={() => {
                // toggle πρώτο κουτί
                setShowConfirm(false);
                setShowLogoutMenu((prev) => !prev);
              }}
              style={styles.headerIconCircle}
            >
              <Ionicons
                name="person-outline"
                size={34}
                color={theme.colors.primaryDark}
              />
            </Pressable>

            <View>
              <Text style={styles.headerTitle}>Hello {userName}</Text>
            </View>
          </View>

          {/* ---------- 1ο ΚΟΥΤΙ: μικρό "Log out" ---------- */}
          {showLogoutMenu && !showConfirm && (
            <View style={styles.logoutBoxWrapper}>
              <View style={styles.logoutBox}>
                <Pressable
                  style={styles.logoutMainButton}
                  onPress={() => {
                    setShowLogoutMenu(false);
                    setShowConfirm(true);
                  }}
                >
                  <Text style={styles.logoutMainButtonText}>Log out</Text>
                </Pressable>
              </View>
            </View>
          )}

          {/* ---------- 2ο ΚΟΥΤΙ: μήνυμα + Cancel / Log out ---------- */}
          {showConfirm && (
            <View style={styles.logoutBoxWrapper}>
              <View style={styles.confirmBox}>
                <Text style={styles.logoutTitle}>Log Out?</Text>
                <Text style={styles.logoutMessage}>
                  Are you sure you want to log out?
                </Text>

                <View style={styles.logoutButtonsRow}>
                  <Pressable
                    style={[styles.logoutBtn, styles.logoutCancelBtn]}
                    onPress={closeAllLogoutUi}
                  >
                    <Text style={styles.logoutCancelText}>Cancel</Text>
                  </Pressable>

                  <Pressable
                    style={[styles.logoutBtn, styles.logoutConfirmBtn]}
                    onPress={handleLogout}
                  >
                    <Text style={styles.logoutConfirmText}>Log out</Text>
                  </Pressable>
                </View>
              </View>
            </View>
          )}

          {/* ---------- Υπόλοιπο περιεχόμενο ---------- */}
          <Text style={styles.sectionTitle}>Today's Overview</Text>

          <View style={styles.overviewRow}>
            {overviewItem(0, 15, "Given", "pill", "#e53935", "warning")}
            {overviewItem(
              3,
              15,
              "Given",
              "silverware-fork-knife",
              "#fb8c00",
              "warning"
            )}
            {overviewItem(
              15,
              15,
              "Checked",
              "clipboard-text-outline",
              theme.colors.primaryDark,
              "check"
            )}
            {overviewItem(
              15,
              15,
              "Appointments",
              "calendar-month-outline",
              theme.colors.primaryDark,
              "check"
            )}
          </View>

          <Text
            style={[styles.sectionTitle, { marginTop: theme.spacing.lg }]}
          >
            Quick Actions
          </Text>

          <View style={styles.quickActionsRow}>
            <Link href="/qrcode" asChild>
              <Pressable style={styles.quickActionCard}>
                <View style={styles.quickIconWrapper}>
                  <Ionicons
                    name="qr-code-outline"
                    size={32}
                    color={theme.colors.primaryDark}
                  />
                </View>
                <Text style={styles.quickActionText}>Scan patient</Text>
              </Pressable>
            </Link>
          </View>

          <Text
            style={[styles.sectionTitle, { marginTop: theme.spacing.lg }]}
          >
            Alerts
          </Text>

          <View style={styles.alertsContainer}>
            {alertItem("Patient #102 missed Paracetamol", "warning")}
            {alertItem(
              "Patient #104 has 3 days since last eaten",
              "warning"
            )}
            {alertItem("Patient #3278 has missed meds", "warning")}
            {alertItem(
              "Patient #105 is admitted for the last 725 days",
              "warning"
            )}
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

          {/* SHIFT MANAGEMENT */}
          <Text
            style={[styles.sectionTitle, { marginTop: theme.spacing.lg }]}
          >
            Shift Management
          </Text>
          <ShiftManagementCard />
        </ScrollView>

        {/* ---------- BOTTOM NAV ---------- */}
        <View style={styles.bottomNav}>
          <Pressable style={styles.bottomItem}>
            <Ionicons
              name="home"
              size={26}
              color={theme.colors.primary}
            />
          </Pressable>
          <Pressable style={styles.bottomItem}>
            <MaterialCommunityIcons
              name="clipboard-text-outline"
              size={26}
              color={theme.colors.mutedText}
            />
          </Pressable>
          <Pressable style={styles.bottomItem}>
            <MaterialCommunityIcons
              name="pill"
              size={26}
              color={theme.colors.mutedText}
            />
          </Pressable>
          <Pressable style={styles.bottomItem}>
            <MaterialCommunityIcons
              name="silverware-fork-knife"
              size={26}
              color={theme.colors.mutedText}
            />
          </Pressable>
          <Pressable style={styles.bottomItem}>
            <Ionicons
              name="calendar-outline"
              size={26}
              color={theme.colors.mutedText}
            />
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
            <Text
              style={[
                styles.overviewCountMain,
                { color: highlightColor },
              ]}
            >
              {current}
            </Text>
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
          <Ionicons
            name="checkmark-circle-outline"
            size={18}
            color={theme.colors.primary}
          />
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

/* ---------- Shift Management Card ---------- */

function ShiftManagementCard() {
  const [isActive, setIsActive] = useState(false);
  const [startTime, setStartTime] = useState<number | null>(null);
  const [elapsedMs, setElapsedMs] = useState(0);

  useEffect(() => {
    let interval: ReturnType<typeof setInterval> | undefined;

    if (isActive && startTime) {
      interval = setInterval(() => {
        setElapsedMs(Date.now() - startTime);
      }, 1000);
    } else {
      setElapsedMs(0);
    }

    return () => {
      if (interval) clearInterval(interval);
    };
  }, [isActive, startTime]);

  const handleClockIn = () => {
    setIsActive(true);
    setStartTime(Date.now());
  };

  const handleClockOut = () => {
    setIsActive(false);
    setStartTime(null);
  };

  const formatDuration = (ms: number) => {
    const totalSeconds = Math.floor(ms / 1000);
    const hours = Math.floor(totalSeconds / 3600);
    const minutes = Math.floor((totalSeconds % 3600) / 60);
    const seconds = totalSeconds % 60;

    const pad = (n: number) => n.toString().padStart(2, "0");
    return `${pad(hours)}:${pad(minutes)}:${pad(seconds)}`;
  };

  return (
    <View style={styles.shiftWrapper}>
      <View style={styles.shiftCard}>
        <View style={styles.shiftTopRow}>
          <View style={styles.shiftIconCircle}>
            <Ionicons
              name="time-outline"
              size={26}
              color="#1f6d5c"
            />
          </View>

          <View style={styles.shiftTextBlock}>
            <Text style={styles.shiftTitleText}>
              {isActive ? "Active Shift" : "Ready to Start?"}
            </Text>
            <Text style={styles.shiftSubtitleText}>
              {isActive
                ? `Duration: ${formatDuration(elapsedMs)}`
                : "Begin your shift now"}
            </Text>
          </View>
        </View>

        <Pressable
          style={[
            styles.shiftButton,
            isActive ? styles.shiftButtonOut : styles.shiftButtonIn,
          ]}
          onPress={isActive ? handleClockOut : handleClockIn}
        >
          <View style={styles.shiftButtonContent}>
            <Ionicons
              name={isActive ? "log-out-outline" : "log-in-outline"}
              size={20}
              color="#ffffff"
              style={{ marginRight: 8 }}
            />
            <Text style={styles.shiftButtonText}>
              {isActive ? "Clock Out" : "Clock In"}
            </Text>
          </View>
        </Pressable>
      </View>
    </View>
  );
}

/* ---------- styles ---------- */

const styles = StyleSheet.create({
  screen: {
    flex: 1,
    backgroundColor: theme.colors.card,
  },

  panel: {
    flex: 1,
    paddingHorizontal: theme.spacing.lg,
    backgroundColor: theme.colors.card,
  },

  content: {
    flex: 1,
  },
  contentContainer: {
    flexGrow: 1,
  },

  /* HEADER */
  headerRow: {
    flexDirection: "row",
    alignItems: "center",
    marginBottom: theme.spacing.md,
  },
  headerIconCircle: {
    width: 48,
    height: 48,
    borderRadius: 24,
    backgroundColor: theme.colors.primary + "22",
    alignItems: "center",
    justifyContent: "center",
    marginRight: theme.spacing.md,
  },
  headerTitle: {
    fontSize: theme.font.xl ?? 22,
    fontWeight: "700",
    color: theme.colors.text,
  },

  /* 1ο μικρό κουτί Logout */
  logoutBoxWrapper: {
    alignSelf: "flex-start",
    marginLeft: 6,
    marginBottom: theme.spacing.md,
  },
  logoutBox: {
    backgroundColor: "#ffffff",
    borderRadius: 16,
    paddingHorizontal: 16,
    paddingVertical: 10,
    minWidth: 170,
    shadowColor: "#000",
    shadowOpacity: 0.15,
    shadowRadius: 10,
    shadowOffset: { width: 0, height: 4 },
    elevation: 4,
  },
  logoutMainButton: {
    alignSelf: "center",
    paddingHorizontal: 28,
    paddingVertical: 8,
    borderRadius: 999,
    backgroundColor: "#c2410c",
  },
  logoutMainButtonText: {
    color: "#ffffff",
    fontWeight: "600",
    fontSize: theme.font.sm,
  },

  /* 2ο κουτί confirm */
  confirmBox: {
    backgroundColor: "#ffffff",
    borderRadius: 16,
    paddingHorizontal: 16,
    paddingVertical: 12,
    minWidth: 200,
    maxWidth: 240,
    shadowColor: "#000",
    shadowOpacity: 0.15,
    shadowRadius: 10,
    shadowOffset: { width: 0, height: 4 },
    elevation: 4,
  },
  logoutTitle: {
    fontSize: theme.font.sm,
    fontWeight: "700",
    color: "#111827",
    marginBottom: 4,
  },
  logoutMessage: {
    fontSize: theme.font.sm,
    color: "#4b5563",
    marginBottom: 12,
  },
  logoutButtonsRow: {
    flexDirection: "row",
    justifyContent: "flex-end",
  },
  logoutBtn: {
    paddingHorizontal: 14,
    paddingVertical: 6,
    borderRadius: 999,
    minWidth: 80,
    alignItems: "center",
    justifyContent: "center",
    marginLeft: 8,
  },
  logoutCancelBtn: {
    backgroundColor: "#e5e7eb",
  },
  logoutConfirmBtn: {
    backgroundColor: "#c2410c",
  },
  logoutCancelText: {
    fontSize: theme.font.sm,
    color: "#111827",
    fontWeight: "500",
  },
  logoutConfirmText: {
    fontSize: theme.font.sm,
    color: "#ffffff",
    fontWeight: "600",
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
    flexDirection: "row",
    alignItems: "center",
    paddingHorizontal: theme.spacing.md,
    paddingVertical: theme.spacing.sm,
    borderRadius: theme.radii.md,
    borderWidth: 1,
    borderColor: theme.colors.border,
    backgroundColor: theme.colors.card,
    alignSelf: "flex-start",
  },

  quickIconWrapper: {
    padding: 6,
    borderRadius: 8,
    backgroundColor: theme.colors.primary + "22",
    alignItems: "center",
    justifyContent: "center",
    marginRight: theme.spacing.sm,
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

  /* SHIFT MANAGEMENT */
  shiftWrapper: {
    marginTop: theme.spacing.sm,
    width: "100%",
    alignItems: "flex-start",
  },
  shiftCard: {
    width: "100%",
    borderRadius: 16,
    backgroundColor: "#ffffff",
    padding: theme.spacing.md,
    shadowColor: "#000",
    shadowOpacity: 0.08,
    shadowRadius: 10,
    shadowOffset: { width: 0, height: 4 },
    elevation: 3,
  },
  shiftTopRow: {
    flexDirection: "row",
    alignItems: "center",
    marginBottom: theme.spacing.md,
  },
  shiftIconCircle: {
    width: 48,
    height: 48,
    borderRadius: 24,
    backgroundColor: "#E6F5F2",
    alignItems: "center",
    justifyContent: "center",
    marginRight: theme.spacing.md,
  },
  shiftTextBlock: {
    flex: 1,
  },
  shiftTitleText: {
    fontSize: theme.font.sm,
    fontWeight: "700",
    color: "#111827",
  },
  shiftSubtitleText: {
    marginTop: 2,
    fontSize: 11,
    color: "#9CA3AF",
  },
  shiftButton: {
    borderRadius: 12,
    overflow: "hidden",
  },
  shiftButtonIn: {
    backgroundColor: "#039488",
  },
  shiftButtonOut: {
    backgroundColor: "#ff6b6b",
  },
  shiftButtonContent: {
    flexDirection: "row",
    alignItems: "center",
    justifyContent: "center",
    paddingVertical: 12,
  },
  shiftButtonText: {
    fontSize: theme.font.sm,
    fontWeight: "600",
    color: "#ffffff",
  },

  bottomNav: {
    flexDirection: "row",
    alignItems: "center",
    justifyContent: "space-around",
    borderTopWidth: 1,
    borderTopColor: theme.colors.border,
    marginTop: theme.spacing.sm,
    paddingVertical: theme.spacing.sm,
  },
  bottomItem: {
    flex: 1,
    alignItems: "center",
  },
});
