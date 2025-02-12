# AIUtils
AIUtils is a program which automatically calculates the coordinates for Alien Isolation levels in order to use them in OpenCAGE.

## Features
* select field for the different levels
* shows the current player coordinates
* displays translated coordinates to use in OpenCAGE SCRIPT_STORYMISSION

#### This is how the window looks like:
![Menu](https://github.com/Oliver2Goetz/AIUtils/blob/master/images/window.png)

## Usage

### General
Alien Isolation has to be opened first, then start AIUtils. After loading into a level select it in the dropdown list if apparent. The normal coordinates and translated coordinates for OpenCAGE will be shown in their respective fields. Keep in mind only levels with offsets are selectable. Other levels are categorized in the "-" option.<br>
As it seems right now the left coordinates are for objects inside the AYZ composite. The OpenCAGE coordinates are usually what to use in the SCRIPT_STORYMISSION composite.<br>
Known levels with offsets: ENG_REACTOR_CORE (PT1), HAB_AIRPORT (M17), HAB_CORPORATEPENT, SCI_HOSPITALUPPER

### Refresh
Refresh updates the AI process.<br>
Similar to reattaching the game in Cheat Engine through the process list, this is needed after restarting the game.

### Show window on top
It does what it says

## Problems
If you face the problem that the coordinates are not getting updated try clicking the "refresh" button or it might be a bug. If so, gladly let me know.

### Special Credits
Data for the offsets were gathered by using the modding tool [OpenCAGE](https://github.com/MattFiler/OpenCAGE) developed by [MattFiler](https://github.com/MattFiler).
