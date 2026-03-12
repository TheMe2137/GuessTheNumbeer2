namespace GuessTheNumber2;

public class Gui
{
    public  static int ShowMenu()   //method to print out menu using language class
    {
        int maxOption;
        Console.Clear();
        Console.WriteLine("=====================");
        Console.WriteLine(Language.Get("menu"));
        Console.WriteLine(Language.Get("choice_1"));
        Console.WriteLine(Language.Get("menu_play"));
        Console.WriteLine(Language.Get("menu_play2"));
        if (Leaderboard.HasScores())        //when leaderboard has scores, the option unlocks
        {
            maxOption = 5;
            Console.WriteLine(Language.Get("leaderboard"));
        }
        else
        {
            maxOption = 4;
        }
        
        Console.WriteLine(Language.Get("settings"));
        Console.WriteLine(Language.Get("exit"));
        Console.WriteLine("=====================");
        int menuChoice;
        while (!int.TryParse(Console.ReadLine(), out menuChoice) || menuChoice < 1 || menuChoice > maxOption+1)       //validate input
        {
            Console.WriteLine(Language.Get("invalid_selection"));
        }
        return menuChoice;
    }

    public static string PrintText(string text)     //method to print out texts in a pretty way
    {
        Console.Clear();
        Console.WriteLine("=====================");
        Console.WriteLine(text);
        Console.WriteLine("=====================");
        return text;
    }
    
}