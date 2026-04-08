# Calm City Simulation

A performance-focused simulation mod for Cities: Skylines that reduces how often citizens and tourists make decisions.

Instead of constant updates, the mod introduces a cooldown-based system that keeps the simulation responsive while significantly lowering CPU load.
---

## 🚀 Features

- Reduces CPU load by lowering simulation frequency
- Citizens and tourists stay longer at locations
- Adjustable behavior via settings
- Helps improve FPS in large and complex cities

---

## ⚙️ How it works

Instead of updating every frame, the mod introduces a cooldown system.
Each citizen or tourist can only update after a certain time has passed.

This reduces unnecessary simulation updates while keeping the city alive.

- **Citizen Mode**  
  Controls how often citizens update their simulation state.

- **Tourist Mode**  
  Adjusts update frequency for tourists.

- Higher values = fewer updates = better performance
- Lower values = more responsive simulation

---

## 📊 Performance

In complex areas (e.g. large train stations or dense downtown areas), improvements of around **3–5 FPS** have been observed.

> ⚠️ Performance gains depend on hardware, camera angle, and city complexity.

---

## ⚠️ Important Notes

- Simulation reacts more slowly
- Changes are not immediately visible
- Citizens may stay longer at locations
- Designed for performance, not realism

---

## 🛠️ Installation

### Option 1 (Recommended)
Download the latest release:
👉 https://github.com/Wiwi-CS/CalmCitySimulation/releases

1. Download `CalmCity.dll`
2. Place it in: Cities Skylines/Files/Mods/

3. Enable the mod in-game

---

## ⚙️ Settings

The mod includes adjustable parameters such as:

- **Citizen Mode**
- **Tourist Behavior**
- Simulation frequency control

(Details depend on your current implementation)

---

## 🧠 Technical Details

- Uses Harmony patches to modify simulation behavior
- Targets:
- `ResidentAI.UpdateLocation`
- `TouristAI.UpdateLocation`
- Reduces update frequency to lower CPU usage

---

## 📌 Status

Recently implemented:

- Cooldown-based simulation system (replacing the previous probability approach)
- Smoother divisor scaling for more natural behavior
- Improved balance between performance and simulation realism

---

## 🚧 Future Plans

- More granular control options
- Optional UI for in-game configuration
- Further performance optimizations

---

## 🐞 Feedback & Issues

Found a bug or have an idea?

👉 Open an issue on GitHub:
https://github.com/Wiwi-CS/CalmCitySimulation/issues

---

## ❤️ Credits

Created by Wiwi-CS

---

## 📄 License

This project is licensed under the MIT License.
