# Dice Game

![Example GIF](https://i.imgur.com/qPRWlUb.gif)

## Summary
A simple console-based dice game where the player competes against the computer to reach the finish line first.

## How it works
- The game starts with both the player and the computer at position 0.
- Each turn, the player rolls the dice first, followed by the computer.
- Rolling the dice advances the player's position by a random number between 1 and 6.
- Certain positions trigger *special events*:
  - **Advancing Tiles**: Landing on some tiles moves the player forward.
  - **Retreating Tiles**: Landing on some other tiles moves the player backward.
- The first to reach or exceed position 30 wins the game.
- After the game ends, the player can choose to play again.

## Installation & Running
Clone this repository or download the source files:

```
git clone https://github.com/otaviobrignoni/dice-game.git 
```

Open the root folder:

```
cd dice-game
```
Restore dependencies:
```
dotnet restore
```

Build the solution in Release mode:
```
dotnet build --configuration Release
```

Execute the project using:
```
dotnet run --project DiceGame.ConsoleApp
```

Alternatively, run the compiled executable:

Navigate to `./DiceGame.ConsoleApp/bin/Release/net8.0/`
Open:
```
DiceGame.ConsoleApp.exe
```
## Requirements
- .NET SDK (Recommended: .NET 8.0 or later) for compiling and running the project.


