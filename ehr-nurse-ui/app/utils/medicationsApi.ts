
import { API_BASE_URL } from "../(tabs)/Api_Base_Url";
export type MedicationFilter = "all" | "not_given" | "given";

// utils/medicationsApi.ts
export type MedicationListItemDto = {
    medicationId: number;
    patientId: number;
    patientName: string;
    patientAge: number | null;
    ward: string;
    bed: string;
    daysInWard: number;

    productName: string;
    form: string | null;
    quantity: number;
    quantityUnit: string;
    frequencyAmount: number;
    frequencyUnit: string;
    durationAmount: number;
    durationUnit: string;
    route: string | null;

    instructionPatient: string | null;
    endDate: string | null;        // JSON date string
    status: string;
    hasReminder: boolean;
};


// utils/medicationsApi.ts
function formatDateKey(date: Date) {
    const year = date.getFullYear();
    const month = String(date.getMonth() + 1).padStart(2, "0");
    const day = String(date.getDate()).padStart(2, "0");
    return `${year}-${month}-${day}`; // e.g. "2025-11-26"
}


export async function getMedicationSchedule(
    filter: MedicationFilter,
    date: Date,
    search: string
): Promise<MedicationListItemDto[]> {
    const statusParam = filter;
    const dateKey = formatDateKey(date);

    const url =
        `${API_BASE_URL}/api/Medications/schedule` +
        `?status=${encodeURIComponent(statusParam)}` +
        `&date=${encodeURIComponent(dateKey)}` +
        `&search=${encodeURIComponent(search)}`;

    const res = await fetch(url);

    if (!res.ok) {
        const text = await res.text();
        throw new Error(`Failed to load medications (${res.status}): ${text}`);
    }

    const data = (await res.json()) as MedicationListItemDto[];
    return data;
}
