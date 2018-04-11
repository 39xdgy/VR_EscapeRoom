# Escape Room VR Project
By Dorothy Carmichael, Ben Gurka, Mark VanderNaald, and Jiashu Jason Wang

## Overview
An escape room game, originally popularized by online Flash games but recently recreated in real life, is an experience where a player is locked in a room and must use clues found within to unlock the door and escape. For our project, made for Ross Sowell's CSC 357 Virtual Reality class at Cornell College, we created a realistic escape room in virtual reality that could theoretically be reproduced in real life. The items and textures within the room are all free assets downloaded from the Unity Asset Store and TurboSquid, which our team augmented and added to with both the SteamVR package and scripts we wrote ourselves. To see a demonstration of the room, played by one of the developers, view the DEMO.flv file.

## How to Play
REQUIRED: SteamVR, HTC Vive  
### Setup
Download the .exe, .dll, and .zip files from the final release of the project. Extract the contents of the .zip file to the same directory as the .exe and .dll files. Run the .exe file to play the game.  
### Controls
Only one action can be done at a time with each controller.
#### Teleport
Press and hold the trackpad on either controller, and a green circle should appear on the floor where that controller is pointing. If the player points to a non-viable position, such as a wall or under a solid object, the circle will turn red. Release the trackpad when the circle is green to teleport to that location.
#### Interact
If the controller glows yellow, the object underneath it can be picked up. Pull and hold the trigger on that controller to pick up the object. Release the trigger to let go of the object. If the trigger is released while the controller is moving, the object will be thrown.
#### Open
The cabinet asset in the room is fully interactable. All doors and drawers can be opened by placing either controller on the handle of that door or drawer and pressing the trigger.
#### Press
To use the keypad next to the door, press a controller into one of the buttons. To enter a code, press the green button. To clear the code and start over, press the red button.

## Known Bugs
- Flashlight does not always turn on when picked up. Putting it down and picking it back up repeatedly usually solves the problem, though it may take several attempts. Overlapping the controller not holding the flashlight with the flashlight object usually works as well.
- Player can teleport outside the room if the controller is outside of the room or inside of a box collider in contact with the edge of the room.  
- Keypad cannot be used with both controllers simultaneously; all numbers and the green button must be pressed with the same controller for the code to work.

## Resources
### Assets
Door:     https://assetstore.unity.com/packages/3d/props/interior/tim-s-horror-assets-the-bloody-door-70847  
Cabinet:  https://assetstore.unity.com/packages/3d/props/furniture/pbr-old-cabinet-106249  
Chest:    https://assetstore.unity.com/packages/3d/props/animated-old-chest-20179  
Keypad:   https://www.turbosquid.com/3d-models/free-max-mode-keypad/786122  
Paper:    https://www.turbosquid.com/3d-models/note-a4-3d-model-1245425  
Wall:     https://www.turbosquid.com/FullPreview/Index.cfm/ID/243350  
Frame:    https://assetstore.unity.com/packages/3d/props/furniture/classic-picture-frame-59038  
Books:    https://assetstore.unity.com/packages/3d/props/elemental-tomes-112086  
Flash Light: https://www.turbosquid.com/3d-models/3d-flashlight-topex-1165829  
Key:      https://assetstore.unity.com/packages/3d/handpainted-keys-42044  
Bookshelf:  https://assetstore.unity.com/packages/3d/props/interior/worn-bookshelf-8458  
Boris:    https://assetstore.unity.com/packages/3d/characters/humanoids/boris-the-cagefighter-109610
### Code
https://forum.unity.com/threads/reveal-texture-only-when-light-falls-on-it.26639/  
http://forum.unity3d.com/threads/3d-text-that-takes-the-depth-buffer-into-account.9931/  
