<<<<<<< HEAD
import { Tabs } from "expo-router";
import { MaterialCommunityIcons, Ionicons } from "@expo/vector-icons";
import { theme } from "../../styles/theme";
import React from "react";
=======
import { Tabs } from 'expo-router';
import { MaterialIcons } from '@expo/vector-icons';
import { theme } from '../../styles/theme';
import React from 'react';
>>>>>>> origin/main

export default function TabsLayout() {
  return (
    <Tabs
      screenOptions={{
        headerShown: false,
        tabBarShowLabel: false,
        tabBarActiveTintColor: theme.colors.primary,
        tabBarInactiveTintColor: theme.colors.mutedText,
        tabBarStyle: {
          backgroundColor: theme.colors.card,
          borderTopWidth: 1,
          borderTopColor: theme.colors.border,
          height: 70,
          paddingBottom: 10,
          paddingTop: 10,
        },
      }}
    >
      {/* Home Screen */}
      <Tabs.Screen
        name="index"
        options={{
          tabBarIcon: ({ color }) => (
            <Ionicons name="home" size={26} color={color} />
          ),
        }}
      />

<<<<<<< HEAD
=======
      {/* Profile Screen */}
>>>>>>> origin/main
      <Tabs.Screen
        name="patients"
        options={{
          tabBarIcon: ({ color }) => (
            <MaterialCommunityIcons
              name="clipboard-text-outline"
              size={26}
              color={color}
            />
          ),
        }}
      />

      <Tabs.Screen
        name="medication"
        options={{
          tabBarIcon: ({ color }) => (
            <MaterialCommunityIcons name="pill" size={26} color={color} />
          ),
        }}
      />

      <Tabs.Screen
        name="nutrition"
        options={{
          tabBarIcon: ({ color }) => (
            <MaterialCommunityIcons
              name="silverware-fork-knife"
              size={26}
              color={color}
            />
          ),
        }}
      />

      <Tabs.Screen
        name="calendar"
        options={{
          tabBarIcon: ({ color }) => (
            <Ionicons name="calendar-outline" size={26} color={color} />
          ),
        }}
      />

      {/* QR Code Scanner Screen  */}
      <Tabs.Screen
        name="qrcode"
        options={{
          href: null,                     
          tabBarStyle: { display: "none" },  
        }}
      />
    </Tabs>
  );
}
