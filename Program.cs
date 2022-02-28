using System;


int secretNumber = new Random().Next(1, 100);
int guessesLeft = 4;
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
    Console.WriteLine("Sorry, you are wrong");

    if (guessesLeft - guessNumber == 1) {
    Console.WriteLine($"You have 1 guess remaining.");
    }
    else
    {
    Console.WriteLine($"You have {guessesLeft - guessNumber} guesses remaining.");
    }
}
guessNumber++;    
}


