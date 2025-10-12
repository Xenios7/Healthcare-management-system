import React, { useState } from "react";
import { View, Text, StyleSheet, Image, TextInput, Button, TouchableOpacity } from "react-native";
import { MaterialIcons } from '@expo/vector-icons'

export default function Login() {
  const [email, setEmail] = useState("");
  const [password, setPassword] = useState("");
  const [showPassword, setShowPassword] = useState(false);

  return (
    <View style={styles.container}>
      <View style={styles.loginBox}>

        <Image
          source={require('../../assets/images/alasia_logo.png')}
          style={styles.logo}
        />

        <Text style={styles.title}>Welcome to
          <Text style={styles.titleBlue}> Alasia </Text>
          <Text style={styles.titleGreen}>GO</Text>
        </Text>

        <View style={styles.inputBox}>

          <MaterialIcons name="email" size={22} color="#9c9b96" style={styles.smallIcons} />

          <TextInput
            style={styles.input}
            placeholder="Enter your email"
            value={email}
            onChangeText={setEmail}
            autoCapitalize="none"
          />
        </View>

        <View style={styles.inputBox}>
          <MaterialIcons name="lock" size={22} color="#9c9b96" style={styles.smallIcons} />
          <TextInput
            style={styles.input}
            placeholder="Enter your password"
            value={password}
            onChangeText={setPassword}
            autoCapitalize="none"
            secureTextEntry={!showPassword}
          />

          <MaterialIcons
            name={showPassword ? "visibility" : "visibility-off"} // 👁️ toggle icon
            size={22}
            color="#9c9b96"
            onPress={() => setShowPassword(!showPassword)}        // 👈 toggles visibility
          />
        </View>

        <TouchableOpacity
          style={styles.loginButton}
          onPress={() => console.log("Login pressed")}
        >
          <Text style={styles.loginButtonText}>Login</Text>
        </TouchableOpacity>

        <TouchableOpacity
          style={styles.forgotPasswordButton}
          onPress={() => console.log("Forgot password pressed")}
        >
          <Text style={styles.forgotPasswordText}>I forgot my password <Text style={styles.arrowIcon}>→</Text></Text>
        </TouchableOpacity>

      </View>
    </View>
  );
}

const styles = StyleSheet.create({
  container: {
    flex: 1,
    justifyContent: "center", // vertical center
    alignItems: "center",     // horizontal center
    backgroundColor: "#ffffff",
  },

  loginBox: {
    width: "85%",
    maxWidth: 500,
    height: "60%",
    maxHeight: 600,
    justifyContent: "center",
    alignItems: "center",
    backgroundColor: "#ffffff",
    borderRadius: 20,

    shadowColor: "#000",
    shadowOffset: { width: 3, height: 5 },
    shadowOpacity: 0.2,
    shadowRadius: 6,

    elevation: 6,
  },

  logo: {
    width: "80%",
    height: "50%",
    resizeMode: "contain",
    marginBottom: -60,
    marginTop: -40,
  },

  inputBox: {
    flexDirection: "row",
    alignItems: "center",
    justifyContent: "space-between",
    width: "85%",
    height: 50,
    borderWidth: 1,
    borderColor: "#ccc",
    borderRadius: 10,
    backgroundColor: "#f6f7f9",
    paddingHorizontal: 10,
    marginTop: 10,
  },


  loginButton: {
    marginTop: 35,
    width: "70%",
    height: 45,
    backgroundColor: "#6fb6b0",
    borderRadius: 25,
    justifyContent: "center",
    alignItems: "center",
    shadowColor: "#000",
    shadowOffset: { width: 2, height: 4 },
    shadowOpacity: 0.2,
    shadowRadius: 4,
    elevation: 3,
  },

  loginButtonText: {
    color: "#ffff",
    fontSize: 16,
  },

  title: {
    textAlign: "center",
    fontSize: 20,
    fontWeight: "bold",
    marginBottom: 20,
    marginTop: 5,
  },

  titleGreen: {
    textAlign: "center",
    fontSize: 20,
    color: "#6fb6b0",
  },

  titleBlue: {
    textAlign: "center",
    fontSize: 20,
    color: "#1a495f",
  },

  input: {
    flex: 1,
    fontSize: 16,
  },

  forgotPasswordButton: {
    color: "#1a495f",
    fontSize: 14,
    textDecorationLine: "underline",

  },

  forgotPasswordText: {
    marginTop: 20,
    color: "#6fb6b0",
    alignSelf: "flex-end",
  },

  smallIcons: {
    marginRight: 8,
  },

  arrowIcon: {
    fontSize: 18,
    color: "#6fb6b0",
    marginLeft: 5,
  }

});
