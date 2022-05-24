Random randomGenerator = new Random();
int Number = randomGenerator.Next(1, 100);

int Guess = 0;
int count = 0;

Console.WriteLine($"The magic number is {Number}");

Console.WriteLine("What is your guess?: ");

while (Guess != Number) 
{
    Guess = Convert.ToInt32(Console.ReadLine());
    count++;

    if (Guess < Number)
    {
        Console.Write("Nope, guess higher.");
        Console.WriteLine(" Take another guess: ");
    }

        else if (Guess > Number)
    {
        Console.Write("Nope, guess lower.");
        Console.WriteLine(" Take another guess: ");
    }
}

Console.WriteLine($"Well done! The answer was {Number}.");
Console.WriteLine($"You did it in {count} guesses!");
Console.ReadLine();









// Console.Write($"The magic number is {number}");

// Console.WriteLine();
// Console.Write("What is your guess? ");
// string guess = Console.ReadLine();
// int x = int.Parse(guess);

// Console.WriteLine(x);

// while (x != number) {

//     if (x > number) {
//         Console.Write("higher");
//         Console.Write("What is your guess?: ");
//         string guess = Console.ReadLine();
//     }
    
//     else {
//         Console.Write("lower");
//     }

// }


// Console.Write("Enter the first number: ");
// string first = Console.ReadLine();
// int x = int.Parse(first);

// Console.Write("Enter the second number: ");
// string second = Console.ReadLine();
// int y = int.Parse(second);

// Console.Write("Enter the third number: ");
// string third = Console.ReadLine();
// int z = int.Parse(third);

// int answer = (x + y) * z;
// int answer2 = x * y + y * z;

// Console.WriteLine($"Result of the specified numbers: {answer} and {answer2}");