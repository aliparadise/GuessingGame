using System;


int secretNumber = 42;
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
}
guessNumber++;    
}


