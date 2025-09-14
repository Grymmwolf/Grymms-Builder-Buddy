## Features

**Build Anywhere**
- Allows you to place structures and paths anywhere. Want to put your woodcutters' hut inside a longhouse? Bad idea, but go for it! Want to place a dirth path through a wall or make a land bridge across a man-made ditch? Sure can buddy! (May require manual hoeing)
- Doesn’t alter settlement limits, resources, or costs—just the placement rule.  

**Bigger Terrain Brush**
- Skips the footprint validation that limits brush size so you can work on large areas. Think 100 cells for the terrain tool instead of the default 10.

---

## Notes & Compatibility

- Built for **ASKA PC** (tested on 1.20.\*) with **BepInEx 6 (Unity IL2CPP)** and **Harmony**.
- Tested alongside ASKA+ with no issues.

---

## FAQ

***Why is the ghost/preview still red?***  

So you can still see overlap with other structures or objects like stumps, trees, mushrooms, or buildings. Placement will still go through when you confirm.


***Can you add a toggle or config?***  

Eventually. For now, it’s always on when the mod is loaded.

***Is this mod safe to install/uninstall?***  

Yes. It patches rules at runtime only and doesn’t overwrite game assets. You can remove the DLL at any time. That said, always back up your saves before adding/removing mods.


---

## Changelog

### v1.2
- Initial public release.
- Build-anywhere during placement.
- Bypass terrain footprint validation for large brush areas.

---

## Credits

- Mod by **Grymm**.  
- Powered by **BepInEx**, **Harmony**, and a stubborn desire to put things exactly where I want them.

---

## Installation

1. Install **BepInEx 6 (Unity IL2CPP)**  
   Download from the official builds: https://builds.bepinex.dev/projects/bepinex_be  
   Get the file named: `BepInEx-Unity.IL2CPP-win-x64-6.*.zip` (Windows x64, **Unity IL2CPP**).
2. Extract the zip **directly into the ASKA game folder** (the same folder as `ASKA.exe`).
3. Launch the game once, then close it.  
   This lets BepInEx generate its folders and DLLs.4. Download the latest mod release from here Release
4. Download the latest **Grymm’s Builder Buddy** from the [Releases](../../releases) page.
5. Copy the DLL to:
   ```text
   <ASKA install path>\BepInEx\plugins\GrymmsBuilderBuddy.dll
6. Start the game and get creative :) 

---

### Uninstall
Delete the DLL from `ASKA/BepInEx/plugins` and restart the game.  
