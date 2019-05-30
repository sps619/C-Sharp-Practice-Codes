using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingAssignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Welcome, This program will help you to find out the minimum distance between two points and the angle between them. ");
            Console.WriteLine();
            Console.Write("Enter first x value: ");
            float point1X = float.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Enter first y value: ");
            float point1Y = float.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Enter second x value: ");
            float point2X = float.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Enter second y value: ");
            float point2Y = float.Parse(Console.ReadLine());
            Console.WriteLine();

            //Finding Delta X and Delta Y
            float deltaX = point2X - point1X;
            float deltaY = point2Y - point1Y;

            //Finding Distance
            float dist = (float)Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
            //Printing Distance
            Console.WriteLine("Distance between the given points: " + dist);
            Console.WriteLine();

            //finding the angle
            float radians = (float)Math.Atan2((point2Y - point1Y), (point2X - point1X));
            double angle = (double)radians * (180 / Math.PI);
            //printing the angle
            Console.Write("Angle between the points: " + angle);
            Console.WriteLine();
        }
    }
}
