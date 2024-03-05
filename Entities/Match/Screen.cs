namespace Brave.Entities.Match;

class Screen
{
    public static void DisplayMatch(Match match)
    {
        Console.Clear();
        System.Console.WriteLine($"{match.Player.Name}\t{match.Player.Health} / {match.Player.MaxHealth}");
        System.Console.WriteLine("|");
        System.Console.WriteLine($"{match.Opponent.Name}\t{match.Opponent.Health} / {match.Opponent.MaxHealth}");

        DisplayOptions(match);
    }

    public static void DisplayOptions(Match match)
    {
        if (!match.PlayerTurn) { return; };

        System.Console.WriteLine();
        System.Console.WriteLine("[A]: Attack");
        System.Console.WriteLine("[D]: Dodge");
        System.Console.WriteLine("[C]: Consumable");
    }
}