using System;

namespace Calculator
{
   class Program
   {
           static void Main(string[] args)
	   {
                  Console.Write("Enter a number : ");
		  double num1 = Convert.ToDouble(Console.ReadLine());
		  Console.Write("Enter another number: ");
		  double num2 = Convert.ToDouble(Console.ReadLine());
		  Console.Write(num1 + num2);

		  Console.ReadLine();
                  
	   }

   }

}
