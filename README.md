# Unity-AOP-proof
I'm validating [H1M4W4R1](https://github.com/H1M4W4R1/) AOP project (https://github.com/H1M4W4R1/Unity-Aspect-Oriented-Programming/) with a non-intrusive profiling module.

The original project was taken from the description of this Unity video: https://www.youtube.com/watch?v=2qeNu2QApAM&ab_channel=Unity,
so then, I added [H1M4W4R1](https://github.com/H1M4W4R1/) repo as a submodule.

The code I added is under [Assets/Scripts/Profiling](Assets/Scripts/Profiling). Also, I had to decorate the target methods in [Assets/Scripts/Game/Movement.cs](Assets/Scripts/Game/Movement.cs) and [Assets/Scripts/Game/ParticleCollision.cs](Assets/Scripts/Game/ParticleCollision.cs).

## How to actually validate its results?
1. Open the project
2. Open the profiler (ctrl + 7)
3. From the top-left dropdown menu (in the profiler window), add "Player Stats"
4. Enable profiling recording in play mode
5. Enter play mode
6. move with 'a', 'd' and shoot with 'space'.
7. Note the information drawn in the profiler "player stats" module.
