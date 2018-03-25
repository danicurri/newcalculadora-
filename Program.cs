using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooVueling
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the calculator!");
            Console.WriteLine("1.[addition], 2.[substraction], 3.[multiplication], 4.[division], 5.[exit]");
            Console.Write("What operation do you wish to do?: ");
            string prefOption = Console.ReadLine();
            int n = int.Parse(prefOption);

            switch (n)
            {
                case 1:
                    Console.Write("Please provide first operand: ");
                    string firstOpSum = Console.ReadLine();
                    Console.Write("Please provide second operand: ");
                    string secondOpSum = Console.ReadLine();
                    string resultSum = $"{ firstOpSum } + { secondOpSum }";
                    Console.WriteLine($"Your result is:  { resultSum }");
                    Console.Write("What operation do you wish to do?: ");
                    Console.ReadLine();
                    break;
                case 2:
                    Console.Write("Please provide first operand: ");
                    string firstOpRest = Console.ReadLine();
                    Console.Write("Please provide second operand: ");
                    string secondOpRest = Console.ReadLine();
                    Console.WriteLine($"Your result is: {firstOpRest} - {secondOpRest}");
                    Console.ReadLine();
                    break;
                case 3:
                    Console.Write("Please provide first operand: ");
                    string firstOpMul = Console.ReadLine();
                    Console.Write("Please provide second operand: ");
                    string secondOpMul = Console.ReadLine();
                    Console.WriteLine($"Your result is:  {firstOpMul} * {secondOpMul}");
                    Console.ReadLine();
                    break;
                case 4:
                    Console.Write("Please provide first operand: ");
                    string firstOpDiv = Console.ReadLine();
                    Console.Write("Please provide second operand: ");
                    string secondOpDiv = Console.ReadLine();
                    Console.WriteLine($"Your result is: { firstOpDiv} / {secondOpDiv}");
                    Console.ReadLine();
                    break;
                case 5:;
                    Console.WriteLine("Hasta la vista amigo!");
                    break;
                default:
                    Console.WriteLine("Wrong input, try again!");
                    Console.ReadLine();
                    break;
            }

        }
    }
}
