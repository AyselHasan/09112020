using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Security.Cryptography.X509Certificates;

namespace Abstraction_interface
{
    class Program
    {
        static void Main(string[] args)
        {
            #region #1
            GeekForGeeks g;
            g = new Geeks1();
            g.gfg();
            g = new Geeks2();
            g.gfg();
            #endregion

            #region #2
            Console.WriteLine("_______________________________________");
            Person Person1;
            Person1 = new Student();
            Person1.Smiling();
            Person Person2;
            Person1 = new Teacher();
            Person1.Smiling();
            #endregion

            #region #3
            Console.WriteLine("_______________________________________");
            Square Square1 = new Square(8);
            Console.WriteLine($"Area: {Square1.Area()}");

            #endregion

            #region #4
            Console.WriteLine("_______________________________________");
            Derived Process1 = new Derived();
            int result = Process1.MultiplyNumbers(88, 12);
            Console.WriteLine($"Result: {result}");
            #endregion

            #region #5
            Console.WriteLine("_______________________________________");
            AbsDerived D = new AbsDerived();
            D.Numbers = 67;
            Console.WriteLine(D.Numbers);
            #endregion

            #region #6
            Console.WriteLine("_______________________________________");
            SealedClass slc = new SealedClass();
            int total = slc.Add(9, 8);
            Console.WriteLine($"Total Sum: {total}");
            #endregion

            #region #7
            Console.WriteLine("_______________________________________");
            Printer p1 = new Printer();
            p1.Print();
            p1.Show();

            Printer ls = new LaserJet();
            ls.Print();
            ls.Show();

            Printer of = new OfficeJet();
            of.Print();
            of.Show();
            #endregion

            #region #8
            Console.WriteLine("_______________________________________");
            GFG G1 = new GFG();
            G1.Method1();
            #endregion

            #region #9
            Console.WriteLine("_______________________________________");

            Shoes newShoes = new Shoes();
            newShoes.Info();
            #endregion

            #region #10
            Console.WriteLine("_______________________________________");
            Nparks nparks = new Nparks();
            nparks.Total();
            #endregion

            #region #11
            Console.WriteLine("_______________________________________");
            School school6 = new School();
            school6.GetInfo();
            #endregion

            #region #12
            Console.WriteLine("_______________________________________");
            TestClass test1 = new TestClass();
            test1.display();
            #endregion

            #region #13
            Console.WriteLine("_______________________________________");
            Bicycle newBicycle = new Bicycle();
            newBicycle.ChangeGear(5);
            newBicycle.SpeedUp(3);
            newBicycle.applyBrakes(2);

            Console.WriteLine("Bicycle present state: ");
            newBicycle.PrintStates();

            Bike newBike = new Bike();
            newBike.ChangeGear(2);
            newBike.SpeedUp(4);
            newBike.applyBrakes(3);

            Console.WriteLine("Bike present state: ");
            newBike.PrintStates();
            #endregion
        }

    }
}