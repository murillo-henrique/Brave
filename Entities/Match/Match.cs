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
        _playerTurn();
    }


    private void _botTurn()
    {
        Random random = new Random();
        char[] availableBotChoices = {'A'};
        int selectedChoice = random.Next(0, availableBotChoices.Length);

        System.Console.WriteLine($"Bot choice: {availableBotChoices[selectedChoice]}");
        Ended = true;
    }
    private void _playerTurn()
    {
        if (!PlayerTurn) { _botTurn(); return; }

        char playerChoice;

        Screen.DisplayMatch(this);
        playerChoice = char.Parse(Console.ReadLine().ToLower());
        _handleChoice(playerChoice);
        System.Console.WriteLine("Player attacked");
        PlayerTurn = false;
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