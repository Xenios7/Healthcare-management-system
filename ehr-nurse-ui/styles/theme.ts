// styles/theme.ts
export const theme = {
    colors: {
        bg: '#ffffff',
        text: '#0f172a',
        mutedText: '#9c9b96',
        primary: '#0EAD9A',
        primaryDark: '#1a495f',
        border: '#e5e7eb',
        card: '#ffffff',
        inputBg: '#f6f7f9',
        shadow: '#000000',
    },
    spacing: {
        xs: 4,
        sm: 8,
        md: 12,
        lg: 16,
        xl: 24,
        xxl: 32,
    },
    radii: {
        sm: 8,
        md: 12,
        lg: 20,
        pill: 999,
    },
    font: {
        sm: 14,
        md: 16,
        lg: 20,
        xl: 24,
    },
    shadow: {
        card: {
            shadowColor: '#000',
            shadowOffset: { width: 3, height: 5 },
            shadowOpacity: 0.2,
            shadowRadius: 6,
            elevation: 6,
        },
        button: {
            shadowColor: '#000',
            shadowOffset: { width: 2, height: 4 },
            shadowOpacity: 0.2,
            shadowRadius: 4,
            elevation: 3,
        },
    },
} as const;
