using Brave.Entities.Classes;

namespace Brave.Entities.Match;

class Match
{
    public int Turn { get; set; }
    public bool PlayerTurn { get; set; }
    public Player Player { get; set; }
    public Bot Opponent { get; set; }
    public bool Ended { get; private set; }

    public Match(Player player)
    {
        Turn = 1;
        PlayerTurn = true;
        Player = player;
        Opponent = new Bot("Pokkoth", Player);
        Ended = false;
    }

    public void MakePlay()
    {
        _isEnded();
        if (PlayerTurn)
        {
            char playerChoice;

            Screen.DisplayMatch(this);
            playerChoice = char.Parse(Console.ReadLine().ToLower());
            _handleChoice(playerChoice);
            System.Console.WriteLine("Player attacked");
        }
    }

    private void _handleChoice(char choice)
    {
        switch (choice)
        {
            case 'a':
                {
                    Player.Attack(Opponent);
                    break;
                }
        }
    }
    private void _isEnded()
    {
        if (Player.Health <= 0 || Opponent.Health <= 0)
        {
            Ended = true;

            return;
        }
    }
}