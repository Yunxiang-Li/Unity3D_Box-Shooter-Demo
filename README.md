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
This is a very simple 3D box shooter game made by Unity3D according to the [Michigan State University](https://msu.edu/)'s coursera course [Introduction to Game Development](https://www-cloudfront-alias.coursera.org/learn/game-development/home/welcome).

This game altogether has 2 levels. For each level, player needs to collect specific amount of scores(50 scores in both level) by shooting moving targets to win the level. Both levels have time limit, 15 seconds for level one and 10 seconds for level two. The player can shoot green targets to earn 5 scores each, shoot white targets to earn 3 seconds each and lose 3 seconds if shooting red targets.

Player can press wasd or arrow buttons to move, player can also press left mouse button or space button to shoot. If time is up then the game ends, player can shoot rotating buttons to restart, go to next level or play again.

## Exhibition

![Level One Win](https://github.com/Yunxiang-Li/Unity3D_Box-Shooter/blob/master/Screenshots%20and%20GIFs/Level1%20win.gif)

![Level Two Fail](https://github.com/Yunxiang-Li/Unity3D_Box-Shooter/blob/master/Screenshots%20and%20GIFs/Level2%20fail.gif)

![Level One](https://github.com/Yunxiang-Li/Unity3D_Box-Shooter/blob/master/Screenshots%20and%20GIFs/Level%201.PNG)

![Level Two](https://github.com/Yunxiang-Li/Unity3D_Box-Shooter/blob/master/Screenshots%20and%20GIFs/Level%202.PNG)

## Install

I use Unity2018.2.19 and JetBrain's Rider IDE for this project under Windows 10 environment.<br>
[Unity and Unity hub download](https://unity3d.com/get-unity/download)<br>
[archived Unity download ](https://unity3d.com/get-unity/download/archive)<br>
[Jetbrains Rider download](https://www.jetbrains.com/rider/download/#section=windows)

## Usage

1. Download this repo, open(or zip and open) the **Unity3D_Box-Shooter** folder.

2. Open the **Unity Hub**, from the Home Screen, click **Projects** to view the **Projects** tab.

3. To open an existing Unity Project stored on your computer, click the Project name in the **Projects** tab, or click **Open** to browse your computer for the Project folder.

4. Note that a Unity Project is a collection of files and directories, rather than just one specific Unity Project file. To open a Project, you must select the main Project folder, rather than a specific file).

5. For this game, just select the **Unity3D_Box-Shooter** folder and open this project.

**If an error is threw out when you click next level button, go to File -> Build Settings, delete all scenes and put level One first and then level Two to rebuild, everything should be okay then.**

## Structure

The whole project in Unity contains two main folders, **Assets** folder and **Package** folder.

Under **Assets** folder, there are altogether **9** subfolders:

1. Animation folder: contains **3** animation for targets and one target animation controller.

2. Audio folder: contains all **5** sounds files including background music, laser, bonus hit music and so on.

3. Materials folder: contains all **8** materials need for player, targets, bumpers and so on.

4. Plugins folder: Plugins/Editor/JetBrains, creates for JetBrains Rider IDE.

5. Prefabs folder: contains all **15** prefabs I will use in this game, including Projectile(bullet), Target Negative Explosion, Player and so on.

6. Scences folder: contains **2** scenes, one for level one, the other one for level two.

7. Scripts folder: contains all **12** customized C# scripts. I also use several scripts(ContrastEnhance.cs, Bloom.cs and so on) from **Standard Assets** folder provided by Unity.

8. Standard Assets folder: provided by Unity, this will be handy and help us a lot when creating a game demo.

9. Textures folder: including textures for skybox and crosshair.

## Maintainers

[@Yunxiang-Li](https://github.com/Yunxiang-Li).

## License

[MIT license](https://github.com/Yunxiang-Li/CS61B/blob/master/LICENSE)
