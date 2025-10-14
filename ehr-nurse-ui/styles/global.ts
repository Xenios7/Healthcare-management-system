// styles/global.ts
import { StyleSheet } from 'react-native';
import { theme } from './theme';

export const g = StyleSheet.create({
    screen: {
        flex: 1,
        justifyContent: 'center',
        alignItems: 'center',
        backgroundColor: theme.colors.bg,
    },
    card: {
        width: '85%',
        maxWidth: 500,
        minHeight: 380,
        justifyContent: 'center',
        alignItems: 'center',
        backgroundColor: theme.colors.card,
        borderRadius: theme.radii.lg,
        paddingVertical: theme.spacing.lg,
        ...theme.shadow.card,
    },
    rowCenterBetween: {
        flexDirection: 'row',
        alignItems: 'center',
        justifyContent: 'space-between',
    },
});
