using System;
namespace EuroToDollar
{
    public class Program
    {
        public static void Main()
        {
            const decimal ExchangeRate = 1.12M;
            const string MsgInput = "Enter amount in euros: ";
            const string MsgResult = "Amount in dollars: ";

            decimal euros, dollars;

            Console.WriteLine(MsgInput);
            euros = Convert.ToDecimal(Console.ReadLine());
            dollars = euros * ExchangeRate;
            Console.WriteLine(MsgResult + dollars);

        }
    }
}
