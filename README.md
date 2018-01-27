# DancingQueens
Exploring different ways to code GameObject paths in C#.

1. MovePositionScript <br> 
Add Rigidbody component to GameObject. Call Rigidbody.MovePosition to move object to the next position of the path.

2. MoveToScript <br>
Uses iTween plugin to move GameObject the same way as MovePositionScript. What's exciting about the iTween function MoveTo are all the different properties you can add to change the look and way your path flows. For example, change the "easetype" to "easeOutBounce" to give object path a more bouncy affect. To find more iTween functions, checkout: http://www.pixelplacement.com/itween/documentation.php

