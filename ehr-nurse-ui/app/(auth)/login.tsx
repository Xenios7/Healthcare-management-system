import React, { useState, useRef, useEffect } from 'react';
import {
  View,
  Text,
  StyleSheet,
  Image,
  TextInput,
  Pressable,
  Animated,
  KeyboardAvoidingView,
  Platform,
  SafeAreaView,
  ActivityIndicator,
  Alert,
} from 'react-native';
import { MaterialIcons } from '@expo/vector-icons';
import { MaterialCommunityIcons } from '@expo/vector-icons';
import { g } from '../../styles/global';
import { theme } from '../../styles/theme';
import { router } from 'expo-router';
import AsyncStorage from '@react-native-async-storage/async-storage';
import { getToken, saveToken } from '../utils/authStorage';
import { biometricPrompt, canUseFingerprint } from '../utils/biometricAuth';

const API_BASE_URL = Platform.select({
  web: 'http://localhost:5164',
  default: 'http://172.20.10.2:5164',
});

const PASSWORD_LOGIN_FLAG_KEY = 'has_completed_password_login';

export default function Login() {
  const [email, setEmail] = useState('');
  const [password, setPassword] = useState('');
  const [showPassword, setShowPassword] = useState(false);
  const [loading, setLoading] = useState(false);
  const [hovered, setHovered] = useState(false);

  // 🔹 ΝΕΑ state για fingerprint λογική
  const [biometricAvailable, setBiometricAvailable] = useState(false);
  const [hasCompletedPasswordLogin, setHasCompletedPasswordLogin] =
    useState(false);

  const scaleAnim = useRef(new Animated.Value(1)).current;

  const handleHoverIn = () => {
    setHovered(true);
    Animated.spring(scaleAnim, {
      toValue: 1.05,
      useNativeDriver: true,
    }).start();
  };

  const handleHoverOut = () => {
    setHovered(false);
    Animated.spring(scaleAnim, {
      toValue: 1,
      useNativeDriver: true,
    }).start();
  };

  useEffect(() => {
    (async () => {
      // ❗ Αν δεν είναι ANDROID, δεν ασχολούμαστε καν με fingerprint
      if (Platform.OS !== 'android') return;

      // Έλεγχος αν υπάρχει fingerprint hardware / permissions
      const fingerprintAvailable = await canUseFingerprint();
      setBiometricAvailable(fingerprintAvailable);

      // Έλεγχος αν έχει ξανακάνει login με password
      const passwordFlag = await AsyncStorage.getItem(PASSWORD_LOGIN_FLAG_KEY);
      setHasCompletedPasswordLogin(passwordFlag === 'true');
    })();
  }, []);

  const onLogin = async () => {
    if (!email || !password) {
      Alert.alert('Missing fields', 'Please enter both email and password.');
      return;
    }

    try {
      setLoading(true);

      const response = await fetch(`${API_BASE_URL}/api/Auth/login`, {
        method: 'POST',
        headers: {
          'Content-Type': 'application/json',
        },
        body: JSON.stringify({ email, password }),
      });

      if (!response.ok) throw new Error('Invalid email or password.');

      const data = await response.json();
      if (!data.token) throw new Error('Login failed: no token received.');

      // 🔹 Αποθήκευση first name (όπως πριν)
      const firstNameFromApi =
        data.user?.firstName ||
        data.firstName ||
        data.name ||
        '';

      if (firstNameFromApi) {
        await AsyncStorage.setItem('user_first_name', firstNameFromApi);
      }

      await saveToken(data.token);
      await AsyncStorage.setItem('auth_token', data.token);
<<<<<<< HEAD
      router.replace('/(tabs)');
=======

      // 🔐 ΕΔΩ ΣΗΜΕΙΩΝΟΥΜΕ ΟΤΙ ΕΚΑΝΕ LOGIN ΜΕ ΚΩΔΙΚΟ
      await AsyncStorage.setItem(PASSWORD_LOGIN_FLAG_KEY, 'true');
      setHasCompletedPasswordLogin(true); // ενημερώνουμε και το state αμέσως

      // Αν είμαστε σε Android, ενημερώνουμε αν υπάρχει fingerprint
      if (Platform.OS === 'android') {
        const fingerprintAvailable = await canUseFingerprint();
        setBiometricAvailable(fingerprintAvailable);
      }

      router.replace('/home');
>>>>>>> origin/main
    } catch (error: any) {
      Alert.alert('Login failed', error.message || 'An error occurred.');
      console.error('Login error:', error);
    } finally {
      setLoading(false);
    }
  };

  const onForgot = () => {
    Alert.alert('Forgot Password', 'This feature is not yet implemented.');
  };

  // ✅ ΤΟ ΚΛΕΙΔΙ: Fingerprint φαίνεται ΜΟΝΟ αν:
  // - είναι Android
  // - υπάρχει hardware fingerprint
  // - έχει γίνει πρώτα login με password
  const showFingerprint =
    Platform.OS === 'android' && biometricAvailable && hasCompletedPasswordLogin;

  return (
    <SafeAreaView style={g.screen}>
      <KeyboardAvoidingView
        style={{ width: '100%', alignItems: 'center' }}
        behavior={Platform.select({ ios: 'padding', android: undefined })}
      >
        <View style={g.card}>
          <Image
            source={require('../../assets/images/alasia_logo.png')}
            style={styles.logo}
          />

          <Text style={styles.title}>
            Welcome to
            <Text style={styles.titleBlue}> Alasia </Text>
            <Text style={styles.titleGreen}>GO</Text>
          </Text>

          <View style={[styles.inputBox]}>
            <MaterialIcons
              name="email"
              size={22}
              color={theme.colors.mutedText}
              style={styles.leftIcon}
            />
            <TextInput
              style={styles.input}
              placeholder="Enter your email"
              value={email}
              onChangeText={setEmail}
              autoCapitalize="none"
              keyboardType="email-address"
              placeholderTextColor={theme.colors.mutedText}
            />
          </View>

          <View style={[styles.inputBox]}>
            <MaterialIcons
              name="lock"
              size={22}
              color={theme.colors.mutedText}
              style={styles.leftIcon}
            />
            <TextInput
              style={styles.input}
              placeholder="Enter your password"
              value={password}
              onChangeText={setPassword}
              autoCapitalize="none"
              secureTextEntry={!showPassword}
              placeholderTextColor={theme.colors.mutedText}
            />
            <Pressable onPress={() => setShowPassword(!showPassword)}>
              <MaterialIcons
                name={showPassword ? 'visibility' : 'visibility-off'}
                size={22}
                color={theme.colors.mutedText}
              />
            </Pressable>
          </View>

          <View style={{ width: '70%', alignItems: 'center' }}>
            <Pressable
              onPress={onLogin}
              disabled={loading}
              onHoverIn={handleHoverIn}
              onHoverOut={handleHoverOut}
              onPressIn={handleHoverIn}
              onPressOut={handleHoverOut}
              style={{ width: '100%' }}
            >
              <Animated.View
                style={[
                  styles.loginButton,
                  {
                    transform: [{ scale: scaleAnim }],
                    backgroundColor: hovered
                      ? theme.colors.primaryDark
                      : theme.colors.primary,
                    shadowOpacity: hovered ? 0.4 : 0.2,
                    elevation: hovered ? 6 : 3,
                    width: '100%',
                  },
                ]}
              >
                {loading ? (
                  <ActivityIndicator color="#fff" />
                ) : (
                  <Text style={styles.loginButtonText}>Login</Text>
                )}
              </Animated.View>
            </Pressable>
          </View>

          <Pressable style={styles.forgotPasswordButton} onPress={onForgot}>
            <Text style={styles.forgotPasswordText}>
              I forgot my password
            </Text>
          </Pressable>
        </View>
      </KeyboardAvoidingView>

      {/* 🔐 Fingerprint: ΜΟΝΟ Android + ΜΟΝΟ μετά από login με κωδικό */}
      {showFingerprint && (
        <>
          <Pressable
            onPress={async () => {
              // Extra safety: ξανατσεκάρουμε το flag
              const passwordFlag = await AsyncStorage.getItem(
                PASSWORD_LOGIN_FLAG_KEY
              );
              const hasCompleted = passwordFlag === 'true';

<<<<<<< HEAD
            const result = await biometricPrompt();

            if (result.success) {
              const storedToken = await getToken();
              if (storedToken) router.replace('/(tabs)');
              else Alert.alert('No saved session', 'Please log in first.');
            } else if (result.error) {
              Alert.alert('Biometric Error', result.error);
            }
          }}
          style={({ pressed }) => [
            styles.fingerprintButton,
            { opacity: pressed ? 0.8 : 1 },
          ]}
        >
          <MaterialCommunityIcons
            name="fingerprint"
            size={64}
            color={theme.colors.primaryDark}
          />
        </Pressable>
        <Text style={styles.fingerprintLabel}>Login with fingerprint</Text>
      </View> */}

      <Pressable
        onPress={async () => {
          const result = await biometricPrompt();

          if (result.success) {
            const storedToken = await getToken();
            if (storedToken) {
              router.replace('/(tabs)');
            } else {
              Alert.alert('No saved session', 'Please log in first with your credentials.');
            }
          } else {
            if (result.error === 'user_cancel' || result.error === 'system_cancel') {
              // user canceled
              console.log('User canceled biometric login. Showing password form.');
            } else {
              Alert.alert('Biometric Error', result.error || 'Authentication failed.');
            }
          }
        }}
        style={({ pressed }) => [
          styles.fingerprintButton,
          { opacity: pressed ? 0.8 : 1 },
        ]}
      >
        <MaterialCommunityIcons
          name="fingerprint"
          size={64}
          color={theme.colors.primaryDark}
        />
      </Pressable>
      <Text style={styles.fingerprintLabel}>Login with fingerprint</Text>
=======
              if (!hasCompleted) {
                Alert.alert(
                  'Fingerprint disabled',
                  'Please log in with your email and password first.'
                );
                return;
              }
>>>>>>> origin/main

              const result = await biometricPrompt();

              if (result.success) {
                const storedToken = await getToken();
                if (storedToken) {
                  router.replace('/home');
                } else {
                  Alert.alert(
                    'No saved session',
                    'Please log in first with your credentials.'
                  );
                }
              } else {
                if (
                  result.error === 'user_cancel' ||
                  result.error === 'system_cancel'
                ) {
                  console.log(
                    'User canceled biometric login. Showing password form.'
                  );
                } else {
                  Alert.alert(
                    'Biometric Error',
                    result.error || 'Authentication failed.'
                  );
                }
              }
            }}
            style={({ pressed }) => [
              styles.fingerprintButton,
              { opacity: pressed ? 0.8 : 1 },
            ]}
          >
            <MaterialCommunityIcons
              name="fingerprint"
              size={64}
              color={theme.colors.primaryDark}
            />
          </Pressable>
          <Text style={styles.fingerprintLabel}>Login with fingerprint</Text>
        </>
      )}
    </SafeAreaView>
  );
}

const styles = StyleSheet.create({
  logo: {
    width: '80%',
    height: 160,
    resizeMode: 'contain',
    marginBottom: -theme.spacing.xl,
    marginTop: -theme.spacing.lg,
  },
  title: {
    textAlign: 'center',
    fontSize: theme.font.lg,
    fontWeight: 'bold',
    marginBottom: theme.spacing.lg,
    marginTop: theme.spacing.sm,
    color: theme.colors.text,
  },
  titleGreen: {
    fontSize: theme.font.lg,
    color: theme.colors.primary,
  },
  titleBlue: {
    fontSize: theme.font.lg,
    color: theme.colors.primaryDark,
  },
  inputBox: {
    ...g.rowCenterBetween,
    width: '85%',
    height: 50,
    borderWidth: 1,
    borderColor: theme.colors.border,
    borderRadius: theme.radii.md,
    backgroundColor: theme.colors.inputBg,
    paddingHorizontal: theme.spacing.md,
    marginTop: theme.spacing.sm,
    gap: theme.spacing.sm,
  },
  leftIcon: { marginRight: theme.spacing.xs },
  input: {
    flex: 1,
    fontSize: theme.font.md,
    color: theme.colors.text,
  },
  loginButton: {
    marginTop: theme.spacing.xxl,
    width: '70%',
    height: 45,
    borderRadius: theme.radii.pill,
    justifyContent: 'center',
    alignItems: 'center',
    ...theme.shadow.button,
  },
  loginButtonText: {
    color: '#fff',
    fontSize: theme.font.md,
    fontWeight: '600',
  },
  forgotPasswordButton: {},
  forgotPasswordText: {
    marginTop: theme.spacing.lg,
    color: theme.colors.primary,
    alignSelf: 'flex-end',
    fontSize: theme.font.sm,
    textDecorationLine: 'underline',
  },
  arrowIcon: {
    fontSize: 18,
    color: theme.colors.primary,
    marginLeft: 5,
  },
  fingerprintContainer: {
    alignItems: 'center',
    justifyContent: 'center',
    marginTop: theme.spacing.xl,
  },
  fingerprintButton: {
    width: 90,
    height: 90,
    borderRadius: 45,
    backgroundColor: '#f6f7f9',
    justifyContent: 'center',
    alignItems: 'center',
    ...theme.shadow.card,
  },
  fingerprintLabel: {
    marginTop: theme.spacing.sm,
    color: theme.colors.mutedText,
    fontSize: theme.font.sm,
  },
});
