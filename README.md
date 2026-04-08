# Calm City Simulation

A performance mod for Cities: Skylines that reduces how often citizens and tourists make decisions.

---

## 🚀 Features

- Reduces CPU load by lowering simulation frequency
- Citizens and tourists stay longer at locations
- Adjustable behavior via settings
- Helps improve FPS in large and complex cities

---

## ⚙️ How it works

Instead of updating every frame, the mod skips simulation steps using a configurable system.

This results in:
- Fewer pathfinding calculations
- Reduced AI updates
- More stable performance

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
