import React, { useRef } from "react";
import { View, Text, StyleSheet, Alert, Pressable } from "react-native";
import { CameraView, useCameraPermissions } from "expo-camera";
import { router } from "expo-router";
import * as Haptics from "expo-haptics";
import { SafeAreaView, useSafeAreaInsets } from "react-native-safe-area-context";

export default function QRCodeScreen() {
  const [permission, requestPermission] = useCameraPermissions();
  const insets = useSafeAreaInsets();
  const hasHandledScan = useRef(false);

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

  const handleBarCodeScanned = ({ data }: { data: string }) => {
    if (hasHandledScan.current) return;
    hasHandledScan.current = true;

    Haptics.notificationAsync(Haptics.NotificationFeedbackType.Success);

    Alert.alert("Scanned!", data, [
      {
        text: "OK",
        onPress: () => {
          router.replace("/home");
        },
      },
    ]);
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
        onBarcodeScanned={handleBarCodeScanned}
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
    lineHeight: 28, // ΤΕΛΕΙΑ ΚΕΝΤΡΑΡΙΣΜΕΝΟ ΣΕ ΟΛΕΣ ΤΙΣ ΣΥΣΚΕΥΕΣ
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
