using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_big_rely_race
{
    class Program
    {
        static void Main(string[] args)
        {

            int age = 13;
            string name = "John";
            decimal height = 0.00M;
            float weight = 0.00f;
            string favorFood = "";
            string favorColor;


            Console.WriteLine("Hi user\n\nWhat is your name?");

            name = Console.ReadLine();

            Console.WriteLine("\n\nHi " + name + "\n\nNice meeting you");
            Console.WriteLine("How old are you?");

            age = int.Parse(Console.ReadLine());

            Console.WriteLine("\n\nThank you " + name + " You are " + age);

            Console.WriteLine("\n\nWhat is your height in ft?(if perfect int please add .0");
            height = Decimal.Parse(Console.ReadLine());

            Console.WriteLine("\n\n height " + height + " ,ok thank you for sharing your height");

            Console.WriteLine("Can you please tell us your weight?");

            weight = float.Parse(Console.ReadLine());

            Console.WriteLine("Nice, you weigh " + weight);










            Console.ReadLine();

        }
    }
}
