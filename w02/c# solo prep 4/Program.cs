// List<string> words = new List<string>();

// words.Add("phone");
// words.Add("keyboard");
// words.Add("mouse");

// // foreach (string word in words) 
// // { 
// //     Console.WriteLine(word);
// // }

// for (int i = 0; i < words.Count; i++)
// {
//     Console.WriteLine(words[i]);
// }


List<int> numbers = new List<int>();

int userNumber = -1;

while (userNumber != 0)
{
    Console.Write("Enter a number (press 0 to quit): ");

    string userResponse = Console.ReadLine();
    userNumber = int.Parse(userResponse);

    numbers.Add(userNumber);
}

int sum = 0;
foreach (int number in numbers)
{
    sum += number;
}

int min = numbers[0];
// foreach 

numbers.Sort();
Console.WriteLine("Your ordered list of numbers is: ");
Console.WriteLine(string.Join(",", numbers));
Console.WriteLine($"The sum of your numbers is: {sum}");


// foreach (int number in numbers)
// {
//     Console.WriteLine(number);
// }