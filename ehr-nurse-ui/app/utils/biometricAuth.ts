import * as LocalAuthentication from 'expo-local-authentication';

export async function biometricPrompt() {
  const hasHardware = await LocalAuthentication.hasHardwareAsync();
  if (!hasHardware) return { success: false, error: 'Biometric hardware not available.' };

  const enrolled = await LocalAuthentication.isEnrolledAsync();
  if (!enrolled) return { success: false, error: 'No biometrics enrolled.' };

  const result = await LocalAuthentication.authenticateAsync({
    promptMessage: 'Authenticate with fingerprint',
    cancelLabel: 'Cancel',
    fallbackLabel: ' ',
    disableDeviceFallback: true,
  });

  return result;
}
