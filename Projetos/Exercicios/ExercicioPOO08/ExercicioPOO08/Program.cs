using System;

namespace ExercicioPOO08 // Note: actual namespace depends on the project name.
{
    internal class Program {
        static void Main(string[] args) {

            Room[] room = new Room[10];            

            Console.Write("How many rooms will be rented? ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine();
            for (int i = 0; i < n; i++) {
                Console.WriteLine("Rent #:" + (i + 1));
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Room: ");
                int roomNumber = int.Parse(Console.ReadLine());
                room[roomNumber] = new Room(name, email, roomNumber);
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("Busy rooms:");

            for (int i = 0; i < room.Length; i++) {
                if (room[i] != null) {
                    Console.WriteLine(room[i]);
                }                
            }
        }
    }
}