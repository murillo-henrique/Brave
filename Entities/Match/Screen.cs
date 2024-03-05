namespace Brave.Entities.Match;

class Screen
{
    public static void DisplayMatch(Match match)
    {
        Console.Clear();
        Console.WriteLine(@"
          ____  _____       __      ________ 
        |  _ \|  __ \     /\ \    / /  ____|
        | |_) | |__) |   /  \ \  / /| |__   
        |  _ <|  _  /   / /\ \ \/ / |  __|  
        | |_) | | \ \  / ____ \  /  | |____ 
        |____/|_|  \_\/_/    \_\/   |______|
        
        ");
        Console.WriteLine();
        Console.WriteLine($"         ┌─────────────────────────────────────────────────────────────────┐");
        Console.WriteLine($"         │ Jogador:  {match.Player.Name}");
        Console.WriteLine($"         │ Nível:    {0}");
        Console.WriteLine($"         │ Classe:   {0}");
        Console.WriteLine($"         │ Vida:     {match.Player.Health} / {match.Player.MaxHealth}");
        Console.WriteLine($"         │ Stamina:  {match.Player.Stamina} / {match.Player.MaxStamina}");
        Console.WriteLine($"         └─────────────────────────────────────────────────────────────────┘");
        Console.WriteLine();

        Console.WriteLine($"         ┌─────────────────────────────────────────────────────────────────┐");
        Console.WriteLine($"         │ Inimigo:  {match.Opponent.Name}");
        Console.WriteLine($"         │ Nível:    {0}");
        Console.WriteLine($"         │ Classe:   {0}");
        Console.WriteLine($"         │ Vida:     {match.Opponent.Health} / {match.Opponent.MaxHealth}");
        Console.WriteLine($"         │ Stamina:  {match.Opponent.Stamina} / {match.Opponent.MaxStamina}");
        Console.WriteLine($"         └─────────────────────────────────────────────────────────────────┘");
        DisplayOptions(match);
    }

    public static void DisplayOptions(Match match)
    {
        if (!match.PlayerTurn) { return; };

        string[] options = { "[A]: Attack", "[D]: Dodge", "[C]: Consumable" };
        System.Console.WriteLine();
        foreach (var phrase in options)
        {
            foreach (var letter in phrase)
            {
                Console.Write(letter);
                Thread.Sleep(50);
            }
            System.Console.WriteLine();
        }
    }
}