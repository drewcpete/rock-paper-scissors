# Rock Paper Scissor

A PvP rock paper scissor game built during Epicodus' C# program. 

## Use

A rock paper scissor game that can be played in the console with 2 players. 

## Set up

- Enter 'dotnet restore' in the command line/ terminal from the RPS.Tests folder;
- Enter 'dotnet run' to launch the game;
- Enter 'Ctl + C' or 'Ctl + Z' to exit/stop the game;

## Specs

| Behavior | Input | Output |
|-|-|-|
| game should have two players as instances of a player class | player 1, player 2| "P1", "P2" |
| player class has fields for r, p, s that have bool values | "rock" | false| 
| will take player input as a string | "rock" | "P1 input hidden" |
| will assign true to the field by checking input | "rock" | true |
| will compare p1 and p2 inputs to determine winner | p1 rock, p2 scissor | p1 wins |


## Technologies

C#, MSTests, .NET

## Authors

Andrew Peterson
Loewy Malkovich

## License

Open source, 2019