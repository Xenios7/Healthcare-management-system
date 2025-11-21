// app/utils/biometricAuth.ts
import * as LocalAuthentication from 'expo-local-authentication';
import { Platform } from 'react-native';

// Check if fingerprint is available & enrolled (ANDROID ONLY)
export async function canUseFingerprint(): Promise<boolean> {
  if (Platform.OS !== 'android') return false;

  const hasHardware = await LocalAuthentication.hasHardwareAsync();
  if (!hasHardware) return false;

  const types = await LocalAuthentication.supportedAuthenticationTypesAsync();
  const hasFingerprint = types.includes(
    LocalAuthentication.AuthenticationType.FINGERPRINT
  );
  if (!hasFingerprint) return false;

  const enrolled = await LocalAuthentication.isEnrolledAsync();
  if (!enrolled) return false;

  return true;
}

export async function biometricPrompt() {
  const canUse = await canUseFingerprint();
  if (!canUse) {
    return { success: false, error: 'Fingerprint authentication not available.' };
  }

  const result = await LocalAuthentication.authenticateAsync({
    promptMessage: 'Authenticate with fingerprint',
    cancelLabel: 'Cancel',
    fallbackLabel: ' ',
    disableDeviceFallback: true,
  });

  return result;
}
