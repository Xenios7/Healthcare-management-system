import { Platform } from "react-native";

export const API_BASE_URL = Platform.select({
    web: "http://localhost:5164",
    default: "http://172.25.152.57:5164",
}) as string;