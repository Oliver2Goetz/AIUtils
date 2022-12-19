# AIUtils
AIUtils is a program which automatically calculates the coordinates for Alien Isolation levels in order to use them in OpenCAGE.

## Features
* select field for the different levels
* Shows coordinates which we can see in the a Cheat Table
* Translated coordinates to use in OpenCAGE

#### This is how the window looks like:
![Menu](https://github.com/Oliver2Goetz/AIUtils/blob/master/images/window.png)

## Usage

### General
Alien Isolation has to be opened first, then start AIUtils. After loading into a level select it in the dropdown list. The normal coordinates and translated coordinated for OpenCAGE will be shown in their respective fields.<br>
As it seems right now the left coordinates are for objects inside the AYZ composite. The OpenCAGE coordinates are usually what to use in the SCRIPT_STORYMISSION composite.<br>
Currently SCI_HOSPITALUPPER is the only known level to have this.

### Refresh
Refresh updates the AI process. This is needed after restarting the game.<br>
This is similar to the Cheat Engine process list.

### Show window on top
It does what it says

## Problems
If you face the problem that the coordinates are not getting updated either try clicking the "refresh" button or reload the mission/level.
