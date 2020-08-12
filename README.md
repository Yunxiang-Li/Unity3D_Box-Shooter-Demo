# Unity3D_Box-Shooter

[![standard-readme compliant](https://img.shields.io/badge/readme%20style-standard-brightgreen.svg?style=flat-square)](https://github.com/RichardLitt/standard-readme)

A simple box shooter game based on Unity3D game engine.

## Table of Contents

- [Background](#Background)
- [Exhibition](#Exhibition)
- [Install](#install)
- [Usage](#usage)
- [Structure](#Structure)
- [Maintainers](#Maintainers)
- [License](#license)

## Background
This is a very simple 3D roller ball game made by Unity3D according to the [Michigan State University](https://msu.edu/)'s coursera course [Introduction to Game Development](https://www-cloudfront-alias.coursera.org/learn/game-development/home/welcome).

This game altogether has 2 levels. For each level, player needs to collect specific amount of coins to win the level, 5 coins need to be collected in level one and 10 coins need to be collected in level two.

Player can press wasd or arrow buttons to move the roller ball, player can also press space button to jump only in level two. There will be enemies spawning and chasing the player(the ball), if player is collided with enemies or death zone or just jumping out of the map, then the player is dead.

## Exhibition

![Level One Fail](https://github.com/Yunxiang-Li/Unity3D_Roller-Ball-Game/blob/master/Screenshots%20and%20GIFs/Level1%20fail.gif)

![Level One Win](https://github.com/Yunxiang-Li/Unity3D_Roller-Ball-Game/blob/master/Screenshots%20and%20GIFs/Level1%20succed.gif)

![Level Two Fail](https://github.com/Yunxiang-Li/Unity3D_Roller-Ball-Game/blob/master/Screenshots%20and%20GIFs/Level2%20fail.gif)

![Level One png](https://github.com/Yunxiang-Li/Unity3D_Roller-Ball-Game/blob/master/Screenshots%20and%20GIFs/Level1.PNG)

![Level Two png](https://github.com/Yunxiang-Li/Unity3D_Roller-Ball-Game/blob/master/Screenshots%20and%20GIFs/Level2.PNG)

## Install

I use Unity2018.2.19 and JetBrain's Rider IDE for this project under Windows 10 environment.<br>
[Unity and Unity hub download](https://unity3d.com/get-unity/download)<br>
[archived Unity download ](https://unity3d.com/get-unity/download/archive)<br>
[Jetbrains Rider download](https://www.jetbrains.com/rider/download/#section=windows)

## Usage

1. Download this repo, open(or zip and open) the **Unity3D_Roller-Ball-Game** folder.

2. Open the **Unity Hub**, from the Home Screen, click **Projects** to view the **Projects** tab.

3. To open an existing Unity Project stored on your computer, click the Project name in the **Projects** tab, or click **Open** to browse your computer for the Project folder.

4. Note that a Unity Project is a collection of files and directories, rather than just one specific Unity Project file. To open a Project, you must select the main Project folder, rather than a specific file).

5. For this game, just select the **Unity3D_Roller-Ball-Game** folder and open this project.

**If an error is threw out when you click next level button, go to File -> Build Settings, delete all scenes and put level One first and then level Two to rebuild, everything should be okay then.**

## Structure

The whole project in Unity contains two main folders, **Assets** folder and **Package** folder.

Under **Assets** folder, there are altogether **8** subfolders:

1. Animation folder: contains animation for death zone.

2. Audio folder: contains all **6** sounds files including background music, game over music, explosion music and so on.

3. Materials folder: contains all **6** materials need for player(the ball), enemies, coins and bumpers.

4. Plugins folder: Plugins/Editor/JetBrains, creates for JetBrains Rider IDE.

5. Prefabs folder: contains all **16** prefabs I will use in this game, including Enemy Spawner, Death Zone, Long Wall and so on.

6. Scences folder: contains **2** scenes, one for level one, the other one for level two.

7. Scripts folder: contains all **10** customized C# scripts. I also use **3** scripts(SmoothFollow.cs, BallUserControl.cs and Ball.cs) from **Standard Assets** folder 's **Scripts** subfolder.

8. Standard Assets folder: provided by Unity, this will be handy and help us a lot when creating a game demo.

## Maintainers

[@Yunxiang-Li](https://github.com/Yunxiang-Li).

## License

[MIT license](https://github.com/Yunxiang-Li/CS61B/blob/master/LICENSE)
