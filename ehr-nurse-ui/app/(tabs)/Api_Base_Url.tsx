import { Platform } from "react-native";

export const API_BASE_URL = Platform.select({
    web: "http://localhost:5164",
    default: "http://172.22.112.218:5164",
}) as string;