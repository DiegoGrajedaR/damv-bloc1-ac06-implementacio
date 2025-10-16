using System;
namespace SumTwoNumbers
{
    public class Program
    {
        public static void Main()
        {
            const string MsgInput1 = "Enter the first integer: ";
            const string MsgInput2 = "Enter the second integer: ";
            const string MsgResult = "The sum is: ";

            int num1, num2, sum;

            Console.WriteLine(MsgInput1);
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(MsgInput2);
            num2 = Convert.ToInt32(Console.ReadLine());
            sum = num1 + num2;
            Console.WriteLine(MsgResult + sum);

        }
    }
}
