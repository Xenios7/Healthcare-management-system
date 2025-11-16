// app/index.tsx
import React, { useEffect, useState } from 'react';
import { ActivityIndicator, View, StyleSheet, Alert } from 'react-native';
import { useRouter } from 'expo-router';
import { theme } from '../../styles/theme';

import { getToken, clearToken } from '../utils/authStorage';
import { biometricPrompt } from '../utils/biometricAuth';

export default function Index() {
  const [checking, setChecking] = useState(true);
  const router = useRouter();

  useEffect(() => {
    const run = async () => {
      try {
        
        const token = await getToken();

        if (!token) {
          // No session at all → go to normal login
          router.replace('/login');
          return;
        }

       
        const result = await biometricPrompt();

        if (result.success) {
          
          router.replace('/home');
        } else {
          
          await clearToken();
          Alert.alert(
            'Authentication required',
            'Please login with your email and password.',
          );
          router.replace('/login');
        }
      } catch (err) {
        console.warn('Auth / biometric check failed', err);
        router.replace('/login');
      } finally {
        setChecking(false);
      }
    };

    run();
  }, [router]);

  if (checking) {
    return (
      <View style={styles.loaderContainer}>
        <ActivityIndicator size="large" color={theme.colors.primary} />
      </View>
    );
  }

  return null;
}

const styles = StyleSheet.create({
  loaderContainer: {
    flex: 1,
    justifyContent: 'center',
    alignItems: 'center',
    backgroundColor: theme.colors.bg,
  },
});
