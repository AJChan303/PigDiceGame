using System;

namespace PigDiceAttempt2 {
    class Program {
        static void Main(string[] args) {
            int[] dice = new int[6] { 1, 2, 3, 4, 5, 6 };
            Random ran = new Random();
            int start = dice[ran.Next(0, dice.Length)];
            
            int total = 0;
            Console.WriteLine($"Dice roll: {start}");

            while (start != 1) {
                start = dice[ran.Next(0, dice.Length)];
                total = total + start;
            }
            Console.WriteLine($"Game Total: {total}");
        }
    }
}
