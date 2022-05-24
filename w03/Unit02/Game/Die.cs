using System;


namespace Unit02.Game
{

class die 
{
    public int num = 0;
    public int points = 0;

public void Roll() 
{
    Random rnd = new Random();

    int num = rnd.Next();

    // for (int j = 0; j++) {
    //     Console.WriteLine(rnd.Next());
    // }

    if (num == 1) {
        points = 100;
    } 

    else if (num == 5){
        points = 50;
    }

    else {
        points = 0;
    }

}
} 
}