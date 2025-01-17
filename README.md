[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-22041afd0340ce965d47ae6ef1cefeee28c7c493a6346c4f15d667ab976d596c.svg)](https://classroom.github.com/a/MjLLqDcN)
# HW1
## W1L2 In-Class Activity
- Character Movement: Use WASD or arrow keys to control character movement.
- Place Seeds: Press SPACE to plant seeds and update the seed count and UI.
- Plants
  - Generate Plant: Generate a plant object (prefab) at the character's current position.
  - Plant Display: Simply display the plant model after planting.
- UI (Counter)
  - Show Remaining Seed Count: Dynamically update the remaining seed count.
  - Show planted seeds: Dynamically update the number of planted seeds.
- Core Interaction
  - Planting Logic: Detect the number of remaining seeds and decide whether they can be planted or not.
  - UI update: after planting, the display of remaining and planted seeds is updated in real time.
- Input Control
  - Movement Control: Control the character movement by keyboard input.
  - Behavior Trigger: Trigger planting operation by SPACE key.

## Devlog
This week, I've mainly broken down and developed the game's development into parts such as the seed planting mechanics, player movement, planting interactions and dynamic user interface updates. In the player movement section, it was implemented that you can move around using WASD or the arrow keys, and press the spacebar to plant seeds at the current location, provided they still have seeds. For the UI development, each time a seed is planted it decreases the number of remaining seeds in the counter and increases the number of seeds already planted, both of which are displayed in real time via the UI in the top left corner of the UI. I solved challenges such as text wrapping issues in the UI by resizing text boxes and disabling text box updates, and ensured accurate plant placement by using real-time updates of the player's exact position.

## Open-Source Assets
If you added any other outside assets, list them here!
- [Sprout Lands sprite asset pack](https://cupnooble.itch.io/sprout-lands-asset-pack) - character and item sprites

## Prof comments
I'm not able to give this Devlog full credit because you didn't mention anything specific from your code or Unity Scene, which was a requirement from the prompt.

For example, when you mention the player movement:

> it was implemented that you can move around using WASD or the arrow keys

You could have described that this was implemented in the HandleMovement method of the Player class by checking the return value of Unity's Input.GetKeyDown method. This description that connected your plans to your code would have fulfilled the requirements for this Devlog prompt. 

Please consider formatting your break-down activities with the hyphen '-' symbol as suggested above, and remove the prompts. This will make it a lot easier for me to read. See the [README formatting guide here](https://docs.github.com/en/get-started/writing-on-github/getting-started-with-writing-and-formatting-on-github/basic-writing-and-formatting-syntax).
