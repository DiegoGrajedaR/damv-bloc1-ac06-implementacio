using System;
namespace RectangleArea
{
    public class Program
    {
        public static void Main()
        {
            const string MsgInputWidth = "Enter the width of the rectangle: ";
            const string MsgInputHeight = "Enter the height of the rectangle: ";
            const string MsgResult = "The area of the rectangle is: ";

            double width, height, area;

            Console.WriteLine(MsgInputWidth);
            width = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(MsgInputHeight);
            height = Convert.ToDouble(Console.ReadLine());
            area = width * height;
            Console.WriteLine(MsgResult + area);

        }
    }
}
