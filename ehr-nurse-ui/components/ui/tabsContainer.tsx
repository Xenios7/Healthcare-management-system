import React from "react";
import {
  View,
  Pressable,
  ScrollView,
  StyleSheet,
  ViewStyle,
} from "react-native";
import { ThemedText } from "@/components/themed-text";

type TabsContainerProps = {
  tabs: string[];
  selectedTab: string;
  onSelect: (tab: string) => void;
};

export function TabsContainer({ tabs, selectedTab, onSelect }: TabsContainerProps) {
  return (
    <ScrollView
      horizontal
      showsHorizontalScrollIndicator={false}
      contentContainerStyle={styles.tabsRow as ViewStyle}
    >
      {tabs.map((tab: string) => (
        <Pressable key={tab} onPress={() => onSelect(tab)}>
          <View
            style={[
              styles.tabBox,
              selectedTab === tab && styles.tabBoxSelected,
              { marginRight: 8 },
            ]}
          >
            <ThemedText
              type="defaultSemiBold"
              style={[
                styles.tabText,
                selectedTab === tab && styles.tabTextSelected,
              ]}
            >
              {tab}
            </ThemedText>
          </View>
        </Pressable>
      ))}
    </ScrollView>
  );
}

const LIGHT_TURQUOISE = "#E3FBF9";
const BRIGHT_TURQUOISE = "#1B998E";

const styles = StyleSheet.create({
  tabsRow: {
    flexDirection: "row",
    paddingVertical: 8,
  },
  tabBox: {
    paddingVertical: 10,
    paddingHorizontal: 16,
    borderRadius: 20,
    backgroundColor: LIGHT_TURQUOISE,
  },
  tabBoxSelected: {
    backgroundColor: BRIGHT_TURQUOISE,
  },
  tabText: {
    color: "#000",
  },
  tabTextSelected: {
    color: "#fff",
    fontWeight: "700",
  },
});
