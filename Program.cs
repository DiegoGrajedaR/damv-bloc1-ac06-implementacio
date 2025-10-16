using System;
namespace AverageThreeNumbers
{
    public class Program
    {
        public static void Main()
        {
            const string MsgInput1 = "Enter the first number: ";
            const string MsgInput2 = "Enter the second number: ";
            const string MsgInput3 = "Enter the third number: ";
            const string MsgResult = "The average is: ";

            double num1, num2, num3, average;

            Console.WriteLine(MsgInput1);
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(MsgInput2);
            num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(MsgInput3);
            num3 = Convert.ToDouble(Console.ReadLine());
            average = (num1 + num2 + num3)/3;
            Console.WriteLine(MsgResult + average);

        }
    }
}
