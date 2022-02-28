using System;

Console.WriteLine("Please choose a difficulty level: Easy(1), Medium(2), Hard(3).");

int chosenDifficulty = int.Parse(Console.ReadLine());

int secretNumber = new Random().Next(1, 100);
int guessesLeft = 0;

switch (chosenDifficulty) {
    case 1 :
    guessesLeft = 8;
    break;
    case 2 :
    guessesLeft = 6;
    break;
    case 3 :
    guessesLeft = 4;
    break;

    default: 
    guessesLeft = 1;
    break;
}

int guessNumber = 1;

while (guessNumber <= guessesLeft)
{
Console.WriteLine($"Your guess - {guessNumber}");
Console.WriteLine("Please guess the secret number");

int guess=int.Parse(Console.ReadLine());
if (guess==secretNumber){
    Console.WriteLine("You guessed right!");
    break;
}
else {
    if (guess<guessNumber){
    Console.WriteLine("Sorry, you guessed too low!");
    }

    if(guess-guessNumber==1)
    {
        Console.WriteLine("Sorry, you guessed too high!");
    }

    if (guessesLeft-guessNumber == 1) {
    Console.WriteLine($"You have 1 guess remaining.");
    }
    else
    {
    Console.WriteLine($"You have {guessesLeft - guessNumber} guesses remaining.");
    }
}
guessNumber++;    
}


