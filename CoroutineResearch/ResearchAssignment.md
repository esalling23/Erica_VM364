#Research Assignment
###VM 364
###Erica Salling

My game, ReBirth, is a strategy game based a grid of objects with which the player can potentially interact. At the beginning of the game, the map is randomly spawned with random numbers of different species and objects, each taking up a single grid space. The game is based around a 24-hour clock, and the behavior of different game objects at different time intervals, such as a day change. As the player plays the game, each action they take costs a certain amount of fuel and takes a certain amount of time to complete. The time costs come into play as the day changes, and objects react to this change. Reeds grow to adjecent squares, potentially destroying mangroves. Trash shifts around in the grid, with a 50% chance to destroy a mangrove if next to it. Mangroves spawn algae on the day change, and will stack algae up to three total. 

They day-night system for the game was completed prior to this class, and rotates a light and changes that light's intensity as the day goes on, to simulate a sun rising and setting. While most of the game is played top-down, I wanted to enable the player to experience the day changing and the environment in the 3D world from within it rather than above it. The player chooses a tile and is transported down to that tile, where they may then choose their action and watch what happens before being sent back to their bird's eye view. 

When a player chooses an action, a function is called to increase the speed of the clock for the amount of time required for that action. However, my problem arose when trying to get the function to wait for the clock to reach the end of it's time requirement, before switching back to the bird's eye view. In researching how to get a function to wait, I discovered coroutines. 

