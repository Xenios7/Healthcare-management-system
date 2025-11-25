import { Tabs } from 'expo-router';
import { MaterialIcons } from '@expo/vector-icons';
import { theme } from '../../styles/theme';
import React from 'react';

export default function TabsLayout() {
  return (
    <Tabs
      screenOptions={{
        headerShown: false,
        tabBarStyle: { display: 'none' },
        tabBarActiveTintColor: theme.colors.primary,
        tabBarInactiveTintColor: theme.colors.mutedText,
      }}
    >
      <Tabs.Screen name="index" />
      <Tabs.Screen
        name="qrcode"
        options={{ href: null }}
      />
      <Tabs.Screen name="Appointments" />
    </Tabs>
  );
}
