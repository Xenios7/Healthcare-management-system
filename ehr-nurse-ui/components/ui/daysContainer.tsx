import React from "react";
import { ScrollView, StyleSheet } from "react-native";

import { DateBox } from "@/components/ui/dateBox";

type DayItem = {
  day: string;
  date: string;
};

type DaysContainerProps = {
  days: DayItem[];
  selectedDay: string;
  onSelect: (day: string) => void;
};

export function DaysContainer({ days, selectedDay, onSelect }: DaysContainerProps) {
  return (
    <ScrollView
      horizontal
      showsHorizontalScrollIndicator={false}
      contentContainerStyle={styles.daysRow}
    >
      {days.map((d) => (
        <DateBox
          key={d.date}
          day={d.day}
          date={d.date}
          selected={selectedDay === d.date}
          onPress={() => onSelect(d.date)}
        />
      ))}
    </ScrollView>
  );
}

const styles = StyleSheet.create({
  daysRow: {
    flexDirection: "row",
    gap: 12,
    paddingVertical: 12,
  },
});
