using System;
 namespace highScores {
    class Program {
        static void Main(string[] args) {
            Player player = new Player("AAA", 15);
            Console.WriteLine($"Initials: {player.Initials}");
            Console.WriteLine($"Score: {player.Score}");
        }
    }
 }