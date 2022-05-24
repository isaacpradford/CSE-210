
// Isaac Radford
// April 30th, 2022
// CSE210 - Programming with classes
// Made with help from https://www.c-sharpcorner.com/UploadFile/75a48f/tic-tac-toe-game-in-C-Sharp/

class Program
{
    //making array
    static char[] arr = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
    static int player = 1;
    
    // While choice = 1, someone has won, -1 then it's a draw, while 0, game is still running
    static int choice; 
    static int flag = 0;
    static void Main(string[] args)
    {

            // Draw the board, fill with the new contents of array each runthrough
            static void Board()
        {
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", arr[1], arr[2], arr[3]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", arr[4], arr[5], arr[6]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", arr[7], arr[8], arr[9]);
            Console.WriteLine("     |     |      ");
        }
        
        // DO/WHILE loop that does all the turnbased stuff
        do
        {
            Console.Clear();
            Console.WriteLine("TIC TAC TOE: ");
            Console.WriteLine("Get three in a row to win!");
            Console.WriteLine("\n");
            Console.WriteLine("Player1 is X and Player2 is O");
            Board();
            Console.WriteLine($"It's player {player}'s turn!: ");
            choice = int.Parse(Console.ReadLine());

        while (arr[choice] != 'X' && arr[choice] != 'O')
        {
            if (player % 2 == 0)
            {
                arr[choice] = 'O';
                player--;
                Console.ForegroundColor = ConsoleColor.Red;
            }
            else
            {
                arr[choice] = 'X';
                player++;
                Console.ForegroundColor = ConsoleColor.Green;
            }
        }
        flag = CheckWin();
    }
        while (flag != 1 && flag != -1);

            if (flag == 1)
            {
                Console.WriteLine("Congratulations, player {0} has won!", (player % 2) + 1);
            }
            else
            {
                Console.WriteLine("It's a draw!");
            }
            Console.ReadLine();
    }

    //Check win conditions
    private static int CheckWin()
    {
        #region Winning Condtions
        if (arr[1] == arr[2] && arr[2] == arr[3])
        {
            return 1;
        }
        else if (arr[4] == arr[5] && arr[5] == arr[6])
        {
            return 1;
        }
        else if (arr[6] == arr[7] && arr[7] == arr[8])
        {
            return 1;
        }
        else if (arr[1] == arr[4] && arr[4] == arr[7])
        {
            return 1;
        }
        else if (arr[2] == arr[5] && arr[5] == arr[8])
        {
            return 1;
        }
        else if (arr[3] == arr[6] && arr[6] == arr[9])
        {
            return 1;
        }

        else if (arr[1] == arr[5] && arr[5] == arr[9])
        {
            return 1;
        }
        else if (arr[3] == arr[5] && arr[5] == arr[7])
        {
            return 1;
        }

        // Tie
        else if (arr[1] != '1' && arr[2] != '2' && arr[3] != '3' && arr[4] != '4' && arr[5] != '5' && arr[6] != '6' && arr[7] != '7' && arr[8] != '8' && arr[9] != '9')
        {
            return -1;
        }
        else
        {
            return 0;
        }
        #endregion
    }
}