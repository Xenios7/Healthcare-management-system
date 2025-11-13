import React, { useState, useRef } from 'react';
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
import { g } from '../../styles/global';
import { theme } from '../../styles/theme';
import { router } from 'expo-router';
import AsyncStorage from '@react-native-async-storage/async-storage';

export default function Login() {
  const [email, setEmail] = useState('');
  const [password, setPassword] = useState('');
  const [showPassword, setShowPassword] = useState(false);
  const [loading, setLoading] = useState(false);
  const [hovered, setHovered] = useState(false);

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

  const onLogin = async () => {
    if (!email || !password) {
      Alert.alert('Missing fields', 'Please enter both email and password.');
      return;
    }

    try {
      setLoading(true);

      //  REMINDER : otan to API mas tha ine etimo tha kanoume allagi to URL
      const response = await fetch('http://localhost:5164/api/Auth/login', {
        method: 'POST',
        headers: {
          'Content-Type': 'application/json',
        },
        body: JSON.stringify({ email, password }),
      });

      if (!response.ok) throw new Error('Invalid email or password.');

      const data = await response.json();
      if (!data.token) throw new Error('Login failed: no token received.');

      await AsyncStorage.setItem('auth_token', data.token);
      router.replace('/(tabs)');
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

          {/* Email */}
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

          {/* Password */}
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


          {/* Forgot Password */}
          <Pressable style={styles.forgotPasswordButton} onPress={onForgot}>
            <Text style={styles.forgotPasswordText}>
              I forgot my password 
            </Text>
          </Pressable>
        </View>
      </KeyboardAvoidingView>
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
});
