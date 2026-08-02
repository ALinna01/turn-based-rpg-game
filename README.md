# ⚔️ Turn-Based RPG Battle

A classic, console-based 1v1 RPG game written in modern C# using Top-Level Statements. Defend the village from a wild monster by strategically choosing when to strike and when to heal!

## 🎮 Features
- **Turn-Based Combat:** Choose to Attack for high damage or Heal to sustain yourself.
- **Dynamic Enemy AI:** The monster randomly decides whether to attack you back or heal itself.
- **Smart Logic:** Monster that are defeated mid-turn won't get a "revenge" strike! (the game end immedietly health is at 0 so no surprise attacks from the grave)
- **Bounded Health System:** Utilizes `Math.Clamp()` to ensure health bars never drop below 0 or exceed the 100 HP maximum.
- **Bulletproof Input:** Built-in validation loops prevent the game from crashing if you type the wrong key.
- **Infinite Replayability:** Automatically resets health bars and asks if you want to play again after a battle concludes.

## 🚀 How to Play
1. Make sure you have the [.NET SDK](https://dotnet.microsoft.com/download) installed.
2. Open your terminal and navigate to the game folder.
3. Run the following command:
   ```bash
   dotnet run
   ```
4. Follow the on-screen prompts (Type `1` to Attack, `2` to Heal).

## 🛠️ Built With
- **C#** 
- **.NET Console App** (Modern Template / Top-Level Statements)