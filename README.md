[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-22041afd0340ce965d47ae6ef1cefeee28c7c493a6346c4f15d667ab976d596c.svg)](https://classroom.github.com/a/MjLLqDcN)
# HW1
## W1L2 In-Class Activity


Character Movement: Use WASD or arrow keys to control character movement.
Place Seeds: Press SPACE to plant seeds and update the seed count and UI.
Plants
Generate Plant: Generate a plant object (prefab) at the character's current position.
Plant Display: Simply display the plant model after planting.
UI (Counter)
Show Remaining Seed Count: Dynamically update the remaining seed count.
Show planted seeds: Dynamically update the number of planted seeds.
Core Interaction
Planting Logic: Detect the number of remaining seeds and decide whether they can be planted or not.
UI update: after planting, the display of remaining and planted seeds is updated in real time.
Input Control
Movement Control: Control the character movement by keyboard input.
Behavior Trigger: Trigger planting operation by SPACE key.


## Devlog
Prompt: Include the HW1 break-down exercise you wrote during the Week 1 - Lecture 2 (Jan 9) in-class activity (above). If you did not attend and perform this activity, review the lecture slides and write your own plan for how you believe HW1 should be built. If your initially proposed plan turned out significantly different than the activity answers given by Prof Reid, you may want to note what was different. Then, write about how the plan you wrote in the break-down connects to the code you wrote. Cite specific class names and method names in the code and GameObjects in your Unity Scene.


Write your Devlog here!
This week, I've mainly broken down and developed the game's development into parts such as the seed planting mechanics, player movement, planting interactions and dynamic user interface updates. In the player movement section, it was implemented that you can move around using WASD or the arrow keys, and press the spacebar to plant seeds at the current location, provided they still have seeds. For the UI development, each time a seed is planted it decreases the number of remaining seeds in the counter and increases the number of seeds already planted, both of which are displayed in real time via the UI in the top left corner of the UI. I solved challenges such as text wrapping issues in the UI by resizing text boxes and disabling text box updates, and ensured accurate plant placement by using real-time updates of the player's exact position.

## Open-Source Assets
If you added any other outside assets, list them here!
- [Sprout Lands sprite asset pack](https://cupnooble.itch.io/sprout-lands-asset-pack) - character and item sprites
