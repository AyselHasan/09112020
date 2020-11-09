using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace methods
{
    #region #1
    public class methods1
    {
        public void MyMethod()
        {
            Console.WriteLine("I just got executed!");
        }
    }
    #endregion

    #region #2
    public class Addiction
    {
        public int Number1;
        public int Number2;
        public void Add(int Number1, int Number2)
        {
            this.Number1 = Number1;
            this.Number2 = Number2;

            int result = Number1 + Number2;
            Console.WriteLine($"Number 1: {Number1} \nNumber 2: {Number2} \nResult: {result}");
        }
    }
    #endregion

    #region #3
    public class Circle
    {
        public double GetCircleArea(double radius)
        {
            double pi = 3.14;
            double area = pi * radius * radius;

            return area;
        }
    }
    #endregion

    #region #4
    class Person
    {
        public int FindBirthYear(int age, int year)
        {
            int BirthYear = year - age;
            return BirthYear;
        }
    }
    #endregion

    #region #5

    class Geeks
    {
        public int Sum(int x, int y)
        {
            int a = x;
            int b = y;

            int result = a + b;
            return result;

        }
    }
    #endregion

    #region #6
    public class Numbers
    {
        public void FindMinimum(int Number1, int Number2)
        {
            if (Number1 < Number2)
            {
                Console.WriteLine($"Minimum value: {Number1}");
            }
            else
            {
                Console.WriteLine($"Minimum value: {Number2}");
            }
        }
    }
    #endregion


}
