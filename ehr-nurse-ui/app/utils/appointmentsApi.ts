import { Platform } from "react-native";

const API_BASE_URL = Platform.select({
    web: 'http://localhost:5164',
    default: 'http://192.168.27.134:5164',
});

export type AppointmentFilter = 'upcoming' | 'completed' | 'all';

export interface AppointmentPatientDto {
    id: number;
    title: string;
    comments: string | null;
    startDate: string;
    isRejected: boolean;
    patientId: number;
    doctorId: string | null;
    statusCode: string | null;    // "SCHEDULED" | "COMPLETED" | "POSTPONED" | "DNA"
    statusDisplay: string | null;
}

// Status codes that the backend expects from the frontend
export type AppointmentStatusFrontendCode = 'COMPLETED' | 'POSTPONED' | 'DNA';

async function handleResponse<T>(res: Response): Promise<T> {
    if (!res.ok) {
        const text = await res.text().catch(() => '');
        throw new Error(text || `Request failed with status ${res.status}`);
    }
    return res.json() as Promise<T>;
}

export async function getAppointments(
    filter: AppointmentFilter = 'upcoming',
    patientId?: number,
): Promise<AppointmentPatientDto[]> {
    const params = new URLSearchParams();
    params.append('filter', filter);
    if (patientId !== undefined) {
        params.append('patientId', String(patientId));
    }

    const res = await fetch(`${API_BASE_URL}/ehr/Appointments?${params.toString()}`);
    return handleResponse<AppointmentPatientDto[]>(res);
}

export async function getAppointment(
    id: number,
): Promise<AppointmentPatientDto> {
    const res = await fetch(`${API_BASE_URL}/ehr/Appointments/${id}`);
    return handleResponse<AppointmentPatientDto>(res);
}

export async function updateAppointmentStatus(
    appointmentId: number,
    statusCode: AppointmentStatusFrontendCode,
): Promise<void> {
    const res = await fetch(`${API_BASE_URL}/ehr/Appointments/${appointmentId}/status`, {
        method: 'PUT',
        headers: {
            'Content-Type': 'application/json',
        },
        body: JSON.stringify({ statusCode }),
    });

    if (!res.ok) {
        const text = await res.text().catch(() => '');
        throw new Error(text || `Update failed with status ${res.status}`);
    }
}

export const markCompleted = (id: number) =>
    updateAppointmentStatus(id, 'COMPLETED');

export const markPostponed = (id: number) =>
    updateAppointmentStatus(id, 'POSTPONED');

export const markDoNotAttempt = (id: number) =>
    updateAppointmentStatus(id, 'DNA');
