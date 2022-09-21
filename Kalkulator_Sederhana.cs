using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kalkulator
{
    public class Kalkulator_Sederhana
    {
        static void Main(string[] args) {
            Console.WriteLine("Enter the action to be performed");
            Console.WriteLine("Press 1 for Addition");
            Console.WriteLine("Press 2 for Substraction");
            Console.WriteLine("Press 3 for Multiplication");
            Console.WriteLine("Press 4 for Division");
            Console.WriteLine();
            int act = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 1st input");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 2nd input");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("The result is ");
            if (act == 1) Console.Write(num1+num2);
            else if (act == 2) Console.Write(num1-num2);
            else if (act == 3) Console.Write(num1*num2);
            else if (act == 4){
                if (num1%num2 == 0) Console.Write(num1/num2);
                else Console.Write(Convert.ToDouble(num1)/Convert.ToDouble(num2));
            }
        }
    }
}