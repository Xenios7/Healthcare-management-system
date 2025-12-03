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

export default function QRCodeScreen() {
  const [permission, requestPermission] = useCameraPermissions();
  const insets = useSafeAreaInsets();

  const [scannerActive, setScannerActive] = useState(true);
  const hasHandledScan = useRef(false);

  useFocusEffect(
    useCallback(() => {
      console.log("[QR] Screen focused -> enable scanner");
      setScannerActive(true);
      hasHandledScan.current = false;

      return () => {
        console.log("[QR] Screen unfocused -> reset flags");
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
    console.log("[QR] onBarcodeScanned fired with data:", data);

    if (!scannerActive) {
      console.log("[QR] Ignored scan because scannerActive = false");
      return;
    }
    if (hasHandledScan.current) {
      console.log("[QR] Ignored scan because hasHandledScan = true");
      return;
    }

    hasHandledScan.current = true;
    setScannerActive(false);

    Haptics.notificationAsync(Haptics.NotificationFeedbackType.Success);

    try {
      console.log("[QR] Calling backend:", `${API_BASE_URL}/api/barcode/scan`);
      const response = await fetch(`${API_BASE_URL}/api/barcode/scan`, {
        method: "POST",
        headers: {
          "Content-Type": "application/json",
        },
        body: JSON.stringify({ barcodeData: data }),
      });

      console.log("[QR] Response status:", response.status);
      let result: any = {};
      try {
        result = await response.json();
      } catch (e) {
        console.log("[QR] Failed to parse JSON:", e);
      }
      console.log("[QR] Response body:", result);

      if (response.ok && result.success) {
        if (result.type === "patient" && result.data) {
          const p = result.data;
          const name =
            (p.firstName || p.first_name || "") +
            " " +
            (p.lastName || p.last_name || "");
          const id = p.id ?? p.Id;

          Alert.alert("Patient found", `Name: ${name}\nID: ${id}`, [
            {
              text: "OK",
              onPress: () => {
                router.replace("/home");
              },
            },
          ]);
        } else if (result.type === "medication" && result.data) {
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
        } else {
          Alert.alert("Scan result", result.message || "Success", [
            {
              text: "OK",
              onPress: () => {
                router.replace("/home");
              },
            },
          ]);
        }
      } else {
        Alert.alert(
          "Scan failed",
          result.message || "Could not process barcode",
          [
            {
              text: "Try again",
              onPress: () => {
                console.log("[QR] User pressed Try again");
                hasHandledScan.current = false;
                setScannerActive(true);
              },
            },
            {
              text: "Back to home",
              onPress: () => {
                router.replace("/home");
              },
            },
          ]
        );
      }
    } catch (error) {
      console.error("Error calling barcode API", error);
      Alert.alert(
        "Network error",
        "Could not contact the server. Make sure the backend is running and the URL is correct.",
        [
          {
            text: "Try again",
            onPress: () => {
              console.log("[QR] User pressed Try again after network error");
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
          {
            top: insets.top + 12,
            right: 16,
          },
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
