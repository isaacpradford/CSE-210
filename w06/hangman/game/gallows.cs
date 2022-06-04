
// To print off the parachute/image display
public class gallows {
    public void printJumper(int wrong)
    {
        if (wrong == 0)
        {
            Console.WriteLine("  ___   ");
            Console.WriteLine("/     \\");
            Console.WriteLine("\\     / ");
            Console.WriteLine(" \\   /");
            Console.WriteLine("   O   ");
            Console.WriteLine("  /|\\   ");
            Console.WriteLine("  / \\    ");
        }
        else if (wrong == 1)
        {
            Console.WriteLine("       ");
            Console.WriteLine("/     \\");
            Console.WriteLine("\\     / ");
            Console.WriteLine(" \\   /");
            Console.WriteLine("   O   ");
            Console.WriteLine("  /|\\   ");
            Console.WriteLine("  / \\    ");
        }
        else if (wrong == 2)
        {
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine("\\     / ");
            Console.WriteLine(" \\   /");
            Console.WriteLine("   O   ");
            Console.WriteLine("  /|\\   ");
            Console.WriteLine("  / \\    ");
        }
        else if (wrong == 3)
        {
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" \\   /");
            Console.WriteLine("   O   ");
            Console.WriteLine("  /|\\   ");
            Console.WriteLine("  / \\    ");
        }
        else if (wrong == 4)
        {
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine("   O   ");
            Console.WriteLine("  /|\\   ");
            Console.WriteLine("  / \\    ");
        }
        else if (wrong == 5)
        {
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine("   ");
            Console.WriteLine("  /|\\   ");
            Console.WriteLine("  / \\    ");
            Console.WriteLine("Game over! Thanks for playing!");
            Environment.Exit(0);
        }
    }
}