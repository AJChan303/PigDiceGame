using System;

namespace PigDiceAttempt2 {
    class Program {
        static void Main(string[] args) {
            int[] dice = new int[6] { 1, 2, 3, 4, 5, 6 };
            Random ran = new Random();
            int start = dice[ran.Next(0, dice.Length)];
           // Console.WriteLine($"Dice Roll: {start}");
            int total = 0;
            

            while (start != 1) {
                start = dice[ran.Next(0, dice.Length)];
                total = total + start;
                Console.WriteLine($"{start}");
            }
            Console.WriteLine($"Game Total: {total}");
        }
    }
}
//highest score 142