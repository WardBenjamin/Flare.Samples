using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Flare;

namespace FlareDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game("Game1", 800, 600);
            game.IsMouseVisible = true;
            Console.WriteLine(game.Window.Icon);
            game.Run();
        }
    }
}
