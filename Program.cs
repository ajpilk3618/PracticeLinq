using System;
using System.Collections.Generic;
using System.Linq;

namespace PracticeLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] games = {"Chess", "Scrable", "Poker", "Football",
                              "Soccer", "Halo", "Monopoly", "Golf"};

            var gameList = new List<string>(games);


            gameList.ForEach(Console.WriteLine);

            Console.WriteLine("#################################");

            var sortedGames = new List<string>();
            sortedGames = gameList.OrderBy(x => x.Length).ToList();
            sortedGames.ForEach(Console.WriteLine);
        }
    }
}
