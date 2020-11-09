using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Abstraction_interface
{
    class abstratc
    {
    }
    #region #1
    public abstract class GeekForGeeks
    {
        public abstract void gfg();
    }

    public class Geeks1 : GeekForGeeks
    {
        public override void gfg()
        {
            Console.WriteLine("class Geek1");
        }
    }

    public class Geeks2 : GeekForGeeks
    {
        public override void gfg()
        {
            Console.WriteLine("class Geek2");
        }
    }
    #endregion

    #region #2
    public abstract class Person
    {
        public string FullName { get; set; }
        public int Age { get; set; }
        public abstract void Smiling();
    }

    public class Student : Person
    {
        public override void Smiling()
        {
            Console.WriteLine("Student is smiling :)");
        }
    }

    public class Teacher : Person
    {
        public override void Smiling()
        {
            Console.WriteLine("Teacher is smiling :)");
        }
    }
    #endregion

    #region #3
    public abstract class AreaClass
    {
        public abstract int Area();
    }

    public class Square: AreaClass
    {
        int Side = 0;
        public Square(int n)
        {
            Side = n;
        }

        public override int Area()
        {
            return Side * Side;
        }
    }
    #endregion

    #region #4

    public abstract class AbstractClass
    {
        public int AddTwoNumbers(int Num1, int Num2)
        {
            return Num1 + Num2;
        }
        public abstract int MultiplyNumbers(int Num1, int Num2);
    }

    class Derived: AbstractClass
    {
        public override int MultiplyNumbers(int Num1, int Num2)
        {
            return Num1 * Num2;
        }
    }

    #endregion

    #region #5
    public abstract class AbsClass
    {
        protected int MyNumber { get; set; }
        public abstract int Numbers { get; set; }
    }

    class AbsDerived : AbsClass
    {
        public override int Numbers 
        {
            get { return MyNumber; }
            set { MyNumber = value; }
        }
    }

    #endregion

    #region #6
    sealed class SealedClass
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
    }
    #endregion

    #region #7
    public class Printer
    {
        public virtual void Show()
        {
            Console.WriteLine("Display dimension : 6*6");
        }
        public virtual void Print()
        {
            Console.WriteLine("Printer printing.....\n");
        }
    }

    public class LaserJet : Printer
    {
        public override void Show()
        {
            Console.WriteLine("Display dimension : 12*12");
        }

        public override void Print()
        {
            Console.WriteLine("LaserJet printer printing.....\n");
        }
    }

    public class OfficeJet: LaserJet
    {
        public override void Print()
        {
            Console.WriteLine("Officejet printer printing....");
        }
    }
    #endregion






}
