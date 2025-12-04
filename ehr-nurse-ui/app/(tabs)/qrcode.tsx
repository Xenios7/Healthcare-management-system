import React, { useCallback, useRef, useState } from "react";
import { View, Text, StyleSheet, Alert, Pressable } from "react-native";
import {
  CameraView,
  useCameraPermissions,
  BarcodeScanningResult,
} from "expo-camera";
import { router, useFocusEffect } from "expo-router";
import * as Haptics from "expo-haptics";
import { SafeAreaView, useSafeAreaInsets } from "react-native-safe-area-context";
import { API_BASE_URL } from "./Api_Base_Url";

const PATIENT_DETAILS_PATH = "/inpatient2";

export default function QRCodeScreen() {
  const [permission, requestPermission] = useCameraPermissions();
  const insets = useSafeAreaInsets();

  const [scannerActive, setScannerActive] = useState(true);
  const hasHandledScan = useRef(false);

  useFocusEffect(
    useCallback(() => {
      setScannerActive(true);
      hasHandledScan.current = false;

      return () => {
        setScannerActive(false);
        hasHandledScan.current = false;
      };
    }, [])
  );

  if (!permission) return <View />;

  if (!permission.granted) {
    return (
      <View style={styles.center}>
        <Text>Camera permission is required.</Text>
        <Pressable onPress={requestPermission} style={styles.button}>
          <Text style={styles.buttonText}>Allow Camera</Text>
        </Pressable>
      </View>
    );
  }

  const handleBarCodeScanned = async ({ data }: BarcodeScanningResult) => {
    if (!scannerActive) return;
    if (hasHandledScan.current) return;

    hasHandledScan.current = true;
    setScannerActive(false);

    Haptics.notificationAsync(Haptics.NotificationFeedbackType.Success);

    try {
      const response = await fetch(`${API_BASE_URL}/api/barcode/scan`, {
        method: "POST",
        headers: { "Content-Type": "application/json" },
        body: JSON.stringify({ barcodeData: data }),
      });

      let result: any = {};
      try {
        result = await response.json();
      } catch {}

      // ---------- PATIENT QR ----------
      if (response.ok && result.success && result.type === "patient" && result.data) {
        const p = result.data;

        const name =
          (p.firstName || p.first_name || "") +
          " " +
          (p.lastName || p.last_name || "");

        const patientId = String(p.id ?? p.Id);
        const age = p.age ?? p.Age;

        const navParams: any = {
          patientId,
          name,
        };
        if (age != null) navParams.age = String(age);

        Alert.alert("Patient found", `Name: ${name}\nID: ${patientId}`, [
          {
            text: "Open details",
            onPress: () => {
              router.replace({
                pathname: PATIENT_DETAILS_PATH,
                params: navParams,
              });
            },
          },
          {
            text: "Cancel",
            onPress: () => {
              router.replace("/home");   // 🔙 ΠΑΕΙ HOME
            },
            style: "cancel",
          },
        ]);

        return;
      }

      // ---------- MEDICATION QR ----------
      if (response.ok && result.success && result.type === "medication") {
        const m = result.data;
        const medName = m.name || m.drugName || "Medication";
        Alert.alert("Medication found", `Medication: ${medName}`, [
          {
            text: "OK",
            onPress: () => {
              router.replace("/home");
            },
          },
        ]);
        return;
      }

      // ---------- WRONG QR ----------
      Alert.alert("Scan failed", result.message || "Invalid QR code", [
        {
          text: "Try again",
          onPress: () => {
            hasHandledScan.current = false;
            setScannerActive(true);
          },
        },
        {
          text: "Home",
          onPress: () => router.replace("/home"),
        },
      ]);
    } catch (error) {
      Alert.alert(
        "Network error",
        "Could not contact the server.",
        [
          {
            text: "Try again",
            onPress: () => {
              hasHandledScan.current = false;
              setScannerActive(true);
            },
          },
        ]
      );
    }
  };

  return (
    <SafeAreaView style={{ flex: 1 }}>
      <Pressable
        style={[
          styles.exitButton,
          { top: insets.top + 12, right: 16 },
        ]}
        onPress={() => router.replace("/home")}
      >
        <Text style={styles.exitText}>×</Text>
      </Pressable>

      <CameraView
        style={{ flex: 1 }}
        barcodeScannerSettings={{ barcodeTypes: ["qr"] }}
        onBarcodeScanned={scannerActive ? handleBarCodeScanned : undefined}
      />
    </SafeAreaView>
  );
}

const styles = StyleSheet.create({
  exitButton: {
    position: "absolute",
    zIndex: 20,
    width: 42,
    height: 42,
    borderRadius: 21,
    backgroundColor: "rgba(0,0,0,0.65)",
    alignItems: "center",
    justifyContent: "center",
  },
  exitText: {
    color: "white",
    fontSize: 26,
    lineHeight: 28,
    fontWeight: "600",
    textAlign: "center",
  },
  center: {
    flex: 1,
    justifyContent: "center",
    alignItems: "center",
  },
  button: {
    marginTop: 15,
    backgroundColor: "black",
    padding: 10,
    borderRadius: 6,
  },
  buttonText: {
    color: "white",
  },
});
