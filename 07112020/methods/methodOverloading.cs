using System;
using System.Collections.Generic;
using System.Text;

namespace methods
{
    public class methodOverloading
    {
        #region #7
        public int PlusMethodInt(int x, int y)
        {
            return x + y; 
        }

        public double PlusMethodDouble(double x, double y)
        {
            return x + y;
        }
        #endregion
    }
    #region #8

    public class GFG
    {
        public int Multiply(int Num1, int Num2, int Num3)
        {
            return Num1 * Num2 * Num3;
        }

        public double Multiply(double Num1, double Num2, double Num3)
        {
            return Num1 * Num2 * Num3;
        }

    }

    #endregion

    #region #9
    public class GFG2
    {
        public void Identity(string name, int id)
        {
            Console.WriteLine($"Name: {name} \nID: {id}");

        }

        public void Identity(int id, string name)
        {
            Console.WriteLine($"Name: {name} \nID: {id}");
        }
    }
    #endregion

    #region #10
    class Comparison
    {
        public void comparison(double Num1, double Num2)
        {
            if (Num1 > Num2)
            {
                Console.WriteLine($"{Num1} bigger than {Num2}");
            }
            else
            {
                Console.WriteLine($"{Num2} bigger than {Num1}");
            }

        }

        public void comparison(double Num1, double Num2, double Num3)
        {
            if (Num1 < Num2)
            {
                if (Num2 < Num3)
                {
                    Console.WriteLine($"{Num3} is the biggest one");
                }
                else
                {
                    Console.WriteLine($"{Num2} is the biggest one");
                }
            }
            else
            {
                if (Num1 < Num3)
                {
                    Console.WriteLine($"{Num3} is the biggest one");
                }
                else
                {
                    Console.WriteLine($"{Num1} is the biggest one");
                }
                 
            }
        }
    }
    #endregion
}
