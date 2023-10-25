using System;
public class program
{
    static int highscore = 0;
    static string player = "";
    public static void update(int score, string playerName)
    {
        if (score > highscore)
        {
            highscore = score;
            player = playerName;
            Console.WriteLine("New highscore is " + score);
            Console.WriteLine("New highscore holder is " + playerName);
        }
        else
        {
            Console.WriteLine("The old highscore of " + highscore + " could not be broken and is still held by " + player);
        }
    }
    public static void Main(string[] args)
    {
        highscore = 100;
        player = "John";
        update(150, "Alice");
    }
}
