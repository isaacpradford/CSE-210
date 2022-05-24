public class Rules
{
    
    public int determineWinner(int player1Choice, int player2Choice)
    {
        
        //Player 1 wins if the following
        if (player1Choice == 1 && player2Choice == 3){
            Console.WriteLine("rock beats scissors; Player 1 wins!");
            return 1;
        }
        else if (player1Choice == 3 && player2Choice == 2)
        {
            Console.WriteLine("scissors beats paper; Player 1 wins!");
            return 1;
        }
        else if (player1Choice == 2 && player2Choice == 1)
        {
            Console.WriteLine("paper beats rock; Player 1 wins!");
            return 1;
        }

        //Player 2 wins if the following
        else if (player2Choice == 1 && player1Choice == 3){
            Console.WriteLine("rock beats scissors; Player 2 wins!");
            return 2;
        }
        else if (player2Choice == 3 && player1Choice == 2)
        {
            Console.WriteLine("scissors beats paper; Player 2 wins!");
            return 2;

        }
        else if (player2Choice == 2 && player1Choice == 1)
        {
            Console.WriteLine("paper beats rock; Player 2 wins!");
            return 2;
        }

        
    }
}
// rock = 1
// paper = 2
// scissors = 3