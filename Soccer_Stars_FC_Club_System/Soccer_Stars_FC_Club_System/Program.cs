using System;
using System.ComponentModel.Design;

namespace Question_1 {
    class Program {
        static void Main(string[] args)
        {
            MenuCommand;
        }

        static void AddPlayer() {
            //Player Information
            Console.WriteLine("Enter player details");
            Console.WriteLine("Name: ");
            String name = Console.ReadLine();
            Console.WriteLine("Age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Position: ");
            String position = Console.ReadLine();
            Console.WriteLine("Player added successfully!");
        }

        static void RemovePlayer() {
        }

        static void SearchPlayer() {
        }

        static void DisplayPlayers() {
        }
    }
}