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

10. Packages folder: provided by Unity, needed for the game.

## Maintainers

[@Yunxiang-Li](https://github.com/Yunxiang-Li).

## License

[MIT license](https://github.com/Yunxiang-Li/CS61B/blob/master/LICENSE)
