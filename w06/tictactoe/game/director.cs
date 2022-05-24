
public class Director {
    // Console.WriteLine("You are playing rock, paper, scissors.");
    public int player1Choice = 0;
    public int player2Choice = 0;


    public void playGame() {
        Player p = new Player();
        

        Console.WriteLine("Player one guess");
        int player1Choice = p.Choice();
        
        Console.WriteLine("Player two guess");
        int player2Choice = p.Choice();
    }
    
}

