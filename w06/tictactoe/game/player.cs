
// Rock is 1, Paper is 2, Scissors is 3

public class Player {

    public int playerOneWins = 0;
    public int playerTwoWins = 0;
    
    public int userGuess = 0;
    
    
    
    public int Choice() {
        try 
        {
            Console.Write("Select rock (1), paper(2) or scissors (3)!");
            userGuess = int.Parse(Console.ReadLine());

            if (userGuess > 3 || userGuess < 1)
            {
                Console.WriteLine("Invalid Input");
            }
            
        }
        catch{
            Console.WriteLine("Invalid Input");
        }
        return userGuess;
    }

    public int Wins() {
        Rules r = new Rules();
        
        if (r.determineWinner() == 1)
        {
            playerOneWins += 1;
            // playerOneWins = playerOneWins + 1;
            Console.WriteLine($"Player One has won {playerOneWins} times!");
        }
       else 
        {
            playerTwoWins += 1;
            // playerOneWins = playerOneWins + 1;
            Console.WriteLine($"Player Two has won {playerTwoWins} times!");
        }


    }
}


// Needs player wins, plays, select choice