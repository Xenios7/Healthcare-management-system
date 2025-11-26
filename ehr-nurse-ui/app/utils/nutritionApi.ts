//reuse the API base URL from medicationsApi.ts
import { API_BASE_URL } from "../(tabs)/Api_Base_Url";

export type NutritionFilter = "all" | "not_given" | "given";

export type NutritionListItemDto = {
    foodId: number;
    patientId: number;

    patientName: string;
    patientAge: number | null;

    ward: string;
    bed: string;
    daysInWard: number;

    mealType: string;
    mealName: string;
    instructions: string | null;

    portionSize: number | null;
    portionEatenPercentage: number | null;

    status: string;
    hasReminder: boolean;
};

function formatDateKey(date: Date) {
    const year = date.getFullYear();
    const month = String(date.getMonth() + 1).padStart(2, "0");
    const day = String(date.getDate()).padStart(2, "0");
    return `${year}-${month}-${day}`; // yyyy-MM-dd
}

export async function getNutritionSchedule(
    filter: NutritionFilter,
    date: Date,
    search: string
): Promise<NutritionListItemDto[]> {
    const statusParam = filter;
    const dateKey = formatDateKey(date);

    const url =
        `${API_BASE_URL}/api/Nutrition/schedule` +
        `?status=${encodeURIComponent(statusParam)}` +
        `&date=${encodeURIComponent(dateKey)}` +
        `&search=${encodeURIComponent(search)}`;

    const res = await fetch(url);

    if (!res.ok) {
        const text = await res.text();
        throw new Error(`Failed to load meals (${res.status}): ${text}`);
    }

    const data = (await res.json()) as NutritionListItemDto[];
    return data;
}
