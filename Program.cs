using Day3_Line_Comparison;
using System;   

namespace Day3_LineComparison
{
    public class LineComparison
    {
        public static void Main(string[] args)
        {

            //Console.WriteLine("Welcome to Line Comparison ");

            //UC1 
            //Modelling line based of coordinates with the help of cartesian law system
            /*
            int x1 = 4;
            int x2 = 9;
            int y1 = 5;
            int y2 = 8;

            double length = (Math.Sqrt(((x2 - x1) ^ 2 )+ ((y2 - y1) ^ 2)));
            Console.WriteLine(length);
            */

            Line length = new Line();
            length.CalculateLength();
            length.CheckEquality();



        }

        
    }
}