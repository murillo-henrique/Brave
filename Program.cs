using Brave.Entities.Classes;
using Brave.Entities.Match;

namespace Brave;

class Program
{
    static void Main(string[] args)
    {
        var player = new Warrior("Murillo");
        var match = new Match(player);

        while (!match.Ended)
        {
            match.MakePlay();
        }

    }
}
