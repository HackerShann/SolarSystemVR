Solar System VR Game
Welcome to the Solar System VR Game! This Unity-based virtual reality experience allows players to fly through the solar system, observe celestial bodies as they orbit the Sun, and view detailed information about planets when flying close to them. The game is designed for immersive exploration, offering a unique way to learn about our solar system.

Features
Fly Through the Solar System
Experience the grandeur of the solar system by flying close to planets and moons as they rotate and orbit the Sun.

Dynamic Planet Information Display
Planetary details dynamically appear when players fly close to a celestial body, offering educational insights.

Realistic Orbits and Rotation
Planets and moons orbit their designated parent objects with realistic rotation speeds.

VR Compatibility
Designed for VR headsets using Oculus VR inputs, but also includes keyboard testing functionality for desktop play.

Scripts Overview
1. SolarManager.cs
Handles the visibility of planetary details when the player triggers the display.

Key Functions:
Activates or deactivates planetary information displays using Oculus controller triggers or the B key for testing.
Each planet has an associated GameObject for its display.
2. RotatorScript.cs
Manages the orbit and self-rotation of celestial bodies.

Key Functions:
Objects orbit around their designated parent (WhoToOrbit) with a customizable OrbitSpeed.
Objects also rotate around their own axis with a customizable SelfRotateSpeed.
Utilizes Time.deltaTime to ensure smooth and frame-independent rotations.
3. Lookat.cs
Ensures objects consistently face a target, such as a player or another celestial body.

Key Functions:
Makes objects dynamically orient towards a target object.
Adjusts rotation to ensure proper alignment, incorporating an offset for correct facing direction.
Controls
Oculus VR Inputs:
Left Index Trigger or Right Index Trigger: Show planetary details.
Keyboard (for testing in Unity Editor):
Press B: Show planetary details.
Setup Instructions
Clone the Repository

bash
Copy code
git clone https://github.com/your-username/solar-system-vr-game.git
Open in Unity
Open the project in Unity (version 2021.3 or later is recommended).

Add Assets
Ensure you have models and textures for planets and the Sun in your Assets folder.

Assign GameObjects

In the Unity Editor, assign the planetary displays (GameObject) to the respective fields in the SolarManager script.
Assign the parent objects and rotation speeds in the RotatorScript.
Build and Run
Build the project for VR or test directly in the Unity Editor.

Future Enhancements
Add sound effects and background music for a more immersive experience.
Include additional educational content about planetary atmospheres, composition, and history.
Expand functionality for interactivity, such as quizzes or mini-games related to the solar system.
