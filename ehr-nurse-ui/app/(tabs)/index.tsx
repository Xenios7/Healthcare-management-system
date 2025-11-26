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
          router.replace('/(auth)/login');
          return;
        }

       
        const ok = await biometricPrompt();

        if (!ok) {
          await clearToken();
          router.replace('/(auth)/login');
          return;
        } 
        router.replace('/(tabs)/home');
      } catch (error) {
        Alert.alert('Error', 'An unexpected error occurred. Please log in again.');
        await clearToken();
        router.replace('/(auth)/login');
      } finally {
        setChecking(false);
      }
          
    };


    run();
  }, []);

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