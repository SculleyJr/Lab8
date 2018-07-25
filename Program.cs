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
            Console.WriteLine("Welcome to C# class! Which student would ou like to learn more about? (index 1 - 5 ");
            int index = int.Parse(Console.ReadLine());

            //if (index > 5)
            //{
            //    Console.WriteLine("Please try again.(enter number 1-5)");
            //    index = int.Parse(Console.ReadLine());
                
            //}
            
           
                string[][] students = new string[3][];

                // Students 1- 5



                students[0] = new string[6] { "does not exist", "sean", "sarah", "jack", "sam", "bob" };
                students[1] = new string[6] { "does not exist", "miami", "denver", "salt lake", "tokyo", "seattle" };
                students[2] = new string[6] { "does not exist", "apple", "mushroom", "peppers", "beans", "prunes" };

            try
            {

                Console.WriteLine($"Student {index} is {students[0][index]}. What would you like to know about him? (enter 'hometown' or 'favorite food')");
                string detail = Console.ReadLine();

                while (detail.ToLower() == "hometown")
                {
                    Console.WriteLine($"{students[0][index]}'s hometown is {students[1][index]}");
                    break;
                }
                while (detail.ToLower() == "favorite food")
                {
                    Console.WriteLine($"{students[0][index]}'s favorite food is {students[2][index]}");
                    break;

                }
            }
            catch(Exception exc)
            {
                Console.WriteLine("not valid input");
                return;
            }
            

            Console.ReadKey();
        }

    }
}



    
               

