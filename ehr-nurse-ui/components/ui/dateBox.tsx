import React from "react";
import { Pressable, View, StyleSheet } from "react-native";

import { ThemedText } from "@/components/themed-text";

const TURQUOISE_LIGHT = "#E9F3F2";
const TURQUOISE_BRIGHT = "#1B998E";

type DateBoxProps = {
  day: string;
  date: string;
  selected: boolean;
  onPress: () => void;
};

export function DateBox({ day, date, selected, onPress }: DateBoxProps) {
  return (
    <Pressable onPress={onPress}>
      <View
        style={[
          styles.dateBox,
          selected && styles.dateBoxSelected,
        ]}
      >
        <ThemedText
          style={[
            styles.daySmall,
            selected && styles.daySmallSelected,
          ]}
        >
          {day}
        </ThemedText>

        <ThemedText
          style={[
            styles.dateBig,
            selected && styles.dateBigSelected,
          ]}
        >
          {date}
        </ThemedText>
      </View>
    </Pressable>
  );
}

const styles = StyleSheet.create({
  dateBox: {
    width: 60,
    alignItems: "center",
    paddingVertical: 10,
    borderRadius: 12,
    backgroundColor: "FFFFFF",

    borderWidth: 2,
    borderColor: TURQUOISE_LIGHT, 

  },

  dateBoxSelected: {
    backgroundColor: TURQUOISE_BRIGHT,
  },

  daySmall: {
    fontSize: 12,
    fontWeight: "600",
    color: "#9E9E9E",
  },
  daySmallSelected: {
    color: "#FFFFFF",
  },

  dateBig: {
    marginTop: -2,
    fontSize: 22,
    fontWeight: "800",
    color: "#242329",
  },
  dateBigSelected: {
    color: "#FFFFFF",
  },
});