using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_3_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Greetings
            /*string nameRes;
            string ageRes;
            int ageResInt;
            string yearRes;
            int yearResInt;
            int bornYear;
            Console.WriteLine("Input name:");
            nameRes = Console.ReadLine();
            Console.WriteLine("Input age:");
            ageRes = Console.ReadLine();
            Console.WriteLine("Input year:");
            yearRes = Console.ReadLine();
            yearResInt = System.Convert.ToInt32(yearRes);
            ageResInt = System.Convert.ToInt32(ageRes);
            bornYear = yearResInt - ageResInt;
            Console.WriteLine($"Your name is {nameRes}, you were born in {bornYear}");*/

            //Adder
            /*string num1;
            string num2;
            string num3;
            int num1Int;
            int num2Int;
            int num3Int;
            int numTotal;
            Console.WriteLine("Input first number:");
            num1 = Console.ReadLine();
            Console.WriteLine("Input second number:");
            num2 = Console.ReadLine();
            Console.WriteLine("Input third number:");
            num3 = Console.ReadLine();
            num1Int = System.Convert.ToInt32(num1);
            num2Int = System.Convert.ToInt32(num2);
            num3Int = System.Convert.ToInt32(num3);
            numTotal = num1Int + num2Int + num3Int;
            Console.WriteLine($"{numTotal}");*/

            //Distance
            /*string dis1;
            string dis2;
            string dis3;
            double dis1Dub;
            double dis2Dub;
            double dis3Dub;
            double disAverage;
            Console.WriteLine("Input first distance(km):");
            dis1 = Console.ReadLine();
            Console.WriteLine("Input second distance(km):");
            dis2 = Console.ReadLine();
            Console.WriteLine("Input third distance(km):");
            dis3 = Console.ReadLine();
            dis1Dub = System.Convert.ToDouble(dis1);
            dis2Dub = System.Convert.ToDouble(dis2);
            dis3Dub = System.Convert.ToDouble(dis3);
            disAverage = (dis1Dub + dis2Dub + dis3Dub) / 3;
            disAverage = Math.Round(disAverage, 2);
            Console.WriteLine($"Total distance is {disAverage} km");*/

            //Hypotenuse
            string side1;
            string side2;
            double side1Dub;
            double side2Dub;
            double Hyponosqrt;
            double Hypo;
            Console.WriteLine("Input first side length:");
            side1 = Console.ReadLine();
            Console.WriteLine("Input second side length:");
            side2 = Console.ReadLine();
            side1Dub = System.Convert.ToDouble(side1);
            side2Dub = System.Convert.ToDouble(side1);
            Hyponosqrt = (side1Dub * side1Dub) + (side2Dub * side2Dub);
            Hypo = Math.Sqrt(Hyponosqrt);
            Hypo = Math.Round(Hypo, 2);
            Console.WriteLine($"The length of the hypotenuse is {Hypo}");

        }
    }
}
