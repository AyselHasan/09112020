using System;
using System.Collections.Generic;
using System.Text;

namespace inheritance
{
    #region #1
    class Vehicle
    {
        public string Brand { get; set; } = "Ford";
        public void Honk()
        {
            Console.WriteLine("beepp beep beeeeppppppp");
        }
    }

    class Car : Vehicle
    {
        public string ModelName { get; set; } = "Mustang";
    }
    #endregion

    #region #2
    public class Animal
    {
        public virtual void Greet()
        {
            Console.WriteLine("Hello! I'm some sort of Animal!");
        }
    }

    public class Dog : Animal
    {
        public override void Greet()
        {
            base.Greet();
            Console.WriteLine("Yes, I am - a Dog!");
        }
    }

    #endregion

    #region #3
    public class Shape
    {
        protected int width;
        protected int height;
        public void SetWidth(int w)
        {
            width = w;
        }

        public void SetHeight(int h)
        {
            height = h;
        }

    }
    class Rectangle1 : Shape
    {
        public void GetArea()
        {
            Console.WriteLine(width * height);
        }
    }
    #endregion

    #region #4
    public class Clothes
    {
        public string Type { get; set; }
        public string Brand { get; set; }
        public string Size { get; set; }

        public virtual void Wearing()
        {

        }
    }

    public class Shoes : Clothes
    {
        public string Color { get; set; }
        public int Size { get; set; }

        public override void Wearing()
        {
            Console.WriteLine("Wear the shoes.");
        }
    }
    #endregion

    #region #5

    public class GFG
    {
        public string name;
        public string subject;

        public void Readers(string name, string subject)
        {
            this.name = name;
            this.subject = subject;
            Console.WriteLine("Myself: " + name);
            Console.WriteLine("My fav subject is: " + subject);
        }
    }

    public class GeekForGeeks : GFG
    {
        public GeekForGeeks()
        {
            Console.WriteLine("GeekForGeeks");
        }
    }


    #endregion

    #region #6

    class Employee
    {
        public string FullName { get; set; }
        public double Salary { get; set; }
    }

    class Engineer : Employee
    {
        public double Bonus { get; set; }
        public Engineer()
        {
            Salary = 5000;
            Bonus = 1000;
        }

        public void GetSalary()
        {

            double TotalSalary = Salary + Bonus;
            this.Salary = Salary;
            this.Bonus = Bonus;

            Console.WriteLine($"Salary: {TotalSalary}");
        }
    }

    #endregion
}
