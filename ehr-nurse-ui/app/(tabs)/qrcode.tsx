import React, { useState, useRef } from "react";
import { View, Text, StyleSheet, Alert, Pressable } from "react-native";
import { CameraView, useCameraPermissions } from "expo-camera";
import { router } from "expo-router";
import * as Haptics from "expo-haptics";

export default function QRCodeScreen() {
  const [permission, requestPermission] = useCameraPermissions();

  
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
    <View style={{ flex: 1 }}>
      {/* Exit button -> Home */}
      <Pressable
        style={styles.exitButton}
        onPress={() => router.replace("/home")}
      >
        <Text style={styles.exitText}>✕</Text>
      </Pressable>

      {/* Scanner */}
      <CameraView
        style={{ flex: 1 }}
        barcodeScannerSettings={{ barcodeTypes: ["qr"] }}
        onBarcodeScanned={handleBarCodeScanned}
      />
    </View>
  );
}

const styles = StyleSheet.create({
  exitButton: {
    position: "absolute",
    top: 50,
    right: 20,
    zIndex: 10,
    backgroundColor: "rgba(0,0,0,0.6)",
    padding: 10,
    borderRadius: 20,
  },
  exitText: {
    color: "white",
    fontSize: 18,
    fontWeight: "bold",
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
    fontSize: 14,
  },
});
