using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3_Line_Comparison
{
    public class Line
    {
        int X1;
        int Y1;
        int X2;
        int Y2;
        int A1;
        int A2;
        int B1;
        int B2;
        double Length_XY;
        double Length_AB;

        public void CalculateLength()
        {
            Console.WriteLine("Enter X,Y Co_Ordinates of the Point 1: ");
            Console.Write("Enter Value X1: ");
            int X1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Value Y1: ");
            int Y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter X,Y Co_Ordinates of the Poin 2: ");
            Console.Write("Enter Value X2: ");
            int X2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Value Y2: ");
            int Y2 = Convert.ToInt32(Console.ReadLine());
            double Length_XY = Math.Sqrt(Math.Pow((X2 - X1), 2) + Math.Pow((Y2 - Y1), 2));
            Console.WriteLine("Length of Value is : " + Length_XY);
            Console.WriteLine("==================================================================================");

            Console.WriteLine("Enter X,Y Co_Ordinates of the Line 2: ");
            Console.Write("Enter Value A1: ");
            int A1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Value B1: ");
            int B1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Value A2: ");
            int A2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Value B2: ");
            int B2 = Convert.ToInt32(Console.ReadLine());
            double Length_AB = Math.Sqrt(Math.Pow((A2 - A1), 2) + Math.Pow((B2 - B1), 2));
            Console.WriteLine("Length of Value is : " + Length_AB);
            Console.WriteLine("==================================================================================");
        }
        public void CheckEquality()
        {
           
            if (Length_XY.Equals(Length_AB))
            {
                Console.WriteLine("Length of XY and Length of AB are Equals");
            }
            else
            {
                Console.WriteLine("Length of XY and Length of AB are Not Equals");
            }
        }
    }
    }
