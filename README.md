# Solar System VR Game 🌌

A Unity-based VR project that lets players explore the solar system, observe orbiting celestial bodies, and view detailed planetary information when flying close. This project is designed for Oculus VR but also includes keyboard support for testing.

---

## 🚀 Features

- **Fly Through the Solar System**  
  Explore planets and moons as they rotate and orbit the Sun.

- **Dynamic Planet Information Display**  
  Planet details appear when the player gets close to each celestial body.

- **Realistic Orbits and Rotations**  
  Planets and moons orbit their parent objects and rotate on their axes with realistic speeds.

- **VR Ready**  
  Optimized for Oculus VR controllers and compatible with desktop testing.

---

## 🛠 Open in Unity

1. **Open the Project**  
   Open the project in Unity (recommended version: 2021.3 or later).

2. **Configure GameObjects**  
   - Assign planetary display objects to the `SolarManager` script in the Unity Editor.
   - Configure the `RotatorScript` by assigning parent objects (`WhoToOrbit`) and setting rotation speeds.

3. **Build and Test**  
   - Build the project for VR platforms (Oculus/Meta).  
   - Use the Unity Editor to test with desktop inputs.

---

## 🎮 Controls

- **Oculus VR**:  
  - **Left Index Trigger** or **Right Index Trigger**: Show planetary details.  
- **Desktop Testing**:  
  - Press the **`B` Key** to show planetary details.

---

## 📜 Scripts

### `SolarManager.cs`  
Handles the visibility of planetary information displays.

**Key Highlights**:  
- Activates or deactivates information displays for each celestial body.  
- Supports Oculus inputs and desktop testing using the `B` key.

---

### `RotatorScript.cs`  
Controls the orbit and self-rotation of planets and moons.

**Key Highlights**:  
- Orbits around a parent object (`WhoToOrbit`) at the specified `OrbitSpeed`.  
- Rotates around its own axis at `SelfRotateSpeed`.  
- Uses `Time.deltaTime` for smooth, frame-independent movement.

---

### `Lookat.cs`  
Ensures objects dynamically face a target.

**Key Highlights**:  
- Adjusts rotation to make objects look at a `target` object.  
- Includes an offset for proper alignment.
