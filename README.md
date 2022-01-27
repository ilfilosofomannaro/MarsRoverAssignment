# MarsRoverAssignment
## Introduction
The project is a simple console application to learn and test Command and State pattern.

### Requirements
You’re part of the team that explores Mars by sending remotely controlled vehicles to the surface of the planet. Develop an API that translates the commands sent from earth to instructions that are understood by the rover.
1. You are given the initial starting point (x,y) of a rover and the direction (N,S,E,W) it is facing.
2. The rover receives a character array of commands.
3. Implement commands that move the rover forward/backward (f,b).
4. Implement commands that turn the rover left/right (l,r).
5. Implement wrapping from one edge of the grid to another. (planets are spheres after all)
6. Implement obstacle detection before each move to a new square. If a given sequence of commands encounters an obstacle, the rover moves up to the last possible point, aborts the sequence and reports the obstacle.
