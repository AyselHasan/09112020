using System;
using System.Diagnostics.CodeAnalysis;

namespace methods
{
    class Program
    {
        
        static void Main(string[] args)
        {
            #region #1
            methods1 Method = new methods1();
            Method.MyMethod();
            Method.MyMethod();
            Method.MyMethod();
            #endregion

            #region #2
            Console.WriteLine("*******************************************");
            Addiction process = new Addiction();
            process.Add(33, 33);

            #endregion

            #region #3
            Console.WriteLine("*******************************************");
            Circle circle1 = new Circle();
            Console.WriteLine($"Area of circle: {circle1.GetCircleArea(8)}");
            #endregion

            #region #4
            Console.WriteLine("*******************************************");
            Person person1 = new Person();
            Console.WriteLine($"Birth year: {person1.FindBirthYear(21, 2020)}");
            #endregion

            #region #5
            Console.WriteLine("*******************************************");
            Geeks Sum1 = new Geeks();
            Console.WriteLine($"Total sum: {Sum1.Sum(55, 67)}");
            #endregion

            #region #6
            Console.WriteLine("*******************************************");
            Numbers comparison = new Numbers();
            comparison.FindMinimum(567, 893);
            #endregion

            #region #7

            Console.WriteLine("*******************************************");
            methodOverloading process1 = new methodOverloading();
            int MyIntNum1 = process1.PlusMethodInt(4, 66);
            double MyDoubleNum1 = process1.PlusMethodDouble(6.8, 19.4);

            Console.WriteLine($"My int Num = {MyIntNum1}");
            Console.WriteLine($"My double Num = {MyDoubleNum1}");


            #endregion

            #region #8
            Console.WriteLine("*******************************************");
            GFG process2 = new GFG();
            int resultI = process2.Multiply(4, 8, 12);
            double resultD = process2.Multiply(6.8, 9.7, 2.67);
            Console.WriteLine($"Int result: {resultI} \nDouble result: {resultD}");

            #endregion

            #region #9
            Console.WriteLine("*******************************************");
            GFG2 newID = new GFG2();
            newID.Identity("Ays", 47);
            newID.Identity("Aysi", 48);

            #endregion

            #region #10
            Console.WriteLine("*******************************************");
            Comparison newComparison = new Comparison();
            newComparison.comparison(4678, 9976);
            newComparison.comparison(999.5, 4588, 4589);
            #endregion
        }





    }
}
