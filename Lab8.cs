using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    class Program
    {
        static void Main(string[] args)
        {
            string run = "y";

            while (run == "y")
            {
                try
                {
                    Console.WriteLine("Welcome to C# class! Which student would you like to learn more about? (index 1 - 10) ");
                    var index = int.Parse(Console.ReadLine());
                    GiveStudentInfo(index);
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("Index out of range, Please try again.");
                    continue;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Please enter a number 1 - 10 OK?");
                    continue;
                }
                Console.WriteLine("Type 'Y' to learn about another student?");
                run = Console.ReadLine();
            }
        }
        private static void GiveStudentInfo(int z)
        {
            string[][] students = new string[3][];

            students[0] = new string[11] { "does not exist", "Sean", "Sarah", "Jack", "Sam", "Bob", "Gary", "Brian", "Pam", "Frankie", "Jon" };
            students[1] = new string[11] { "does not exist", "Miami", "Denver", "Salt Lake", "Tokyo", "Seattle", "Grand Rapids", "Grand Junction", "Chicago", "Jackson Hole", "Pyongyan" };
            students[2] = new string[11] { "does not exist", "Apples", "Mushrooms", "Peppers", "Beans", "Prunes", "Guacamole", "Biscuits", "Tacos", "Ek Burgers", "Fried Kitty Cat" };

            Console.WriteLine($"Student {z} is {students[0][z]}. What would you like to know about {students[0][z]} ? (enter 'hometown' or 'favorite food')");
            string detail = Console.ReadLine();

            while (detail.ToLower() == "hometown" || detail.ToLower() == "home town")
            {
                Console.WriteLine($"{students[0][z]}'s hometown is {students[1][z]}");
                break;
            }
            while (detail.ToLower() == "favorite food")
            {
                Console.WriteLine($"{students[0][z]}'s favorite food is {students[2][z]}");
                break;
            }
        }
    }
}






