using System;
namespace slutuppdrag.cs
{
    public class Golv
    {
        public static void FirstChoice()
        {
            try
            {


                Console.Clear();
                Console.WriteLine("Du har valt alternativet att köpa golv, ange hur många kvadratmeter ni vill köpa:");

                //The program calculates the price per square meter and the price for the floor in total¨

                double num1 = Convert.ToDouble(Console.ReadLine());

                double num2 = 19.99;

                Console.WriteLine("Ni har valt att beställa " + num1 + " kvm");

                double result = num1 * num2;

                Console.WriteLine("Det totala priset blir: " + result + " kr.");
                Console.ReadLine();

            }
            catch

            {
                Console.WriteLine("Error, prova igen!");
                Console.ReadLine();
            }



        }

    }
}