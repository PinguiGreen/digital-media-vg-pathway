using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("\n\t\t\t\t\t\t\tWarning!\n\t\t\t\t\tThis game is a warning screen lmao!\n");


            Console.Write("press 1 to continue\n");
            int i =Convert.ToInt32(Console.ReadLine());
            if (i == 1)
            {
                Console.Write("lol ok\n");
            }
            else
            {
                Console.Write("oof, ok then...\n");
                Environment.Exit(1);
            }
            string name;
            int age;
            int NameChoosing = 0;
            while (NameChoosing != 1)
            {
                Console.WriteLine("tell me your name mate");
                name = Console.ReadLine();
                Console.WriteLine("tell me your age mate");
                age = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("you are " + age + " and your name is " + name + "?\nPress 1 to confirm");
                NameChoosing = Convert.ToInt32(Console.ReadLine());
                if (NameChoosing == 1)
                {
                    Console.Write("ok " + name + "\n");
                    Console.WriteLine("welcome to the game " + name + ", are you ready?");
                }
                else
                {
                    Console.Write("lmao ok redo it\n");
                }
            }
            Console.WriteLine("No matter. You already answer this and gave your soul to the game sooo... your fault.");
        }
    }
}