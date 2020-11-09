using System;
using System.Collections.Generic;
using System.Globalization;
using System.Security.Cryptography;
using System.Text;

namespace encapsulation
{

    #region #1
    public class Rectangle
    {
        private double length;
        private double width;

        public void acceptDetails()
        {
            Console.WriteLine("Enter Length: ");
            length = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter Width: ");
            width = Convert.ToDouble(Console.ReadLine());
        }

        public double getArea()
        {
            return length * width;
        }

        public void Display()
        {
            Console.WriteLine("length: {0}", length);
            Console.WriteLine("width: {0}", width);
            Console.WriteLine("area: {0}", getArea());
        }


    }
    #endregion

    #region #2
    public class Person
    {
        private string _name { get; set; }
        public string name
        {
            get { return _name; }
            set { _name = value; }
        }

    }
    #endregion

    #region #3
    public class School
    {
        private int _Capacity { get; set; }
        public int Capacity
        {
            get { return _Capacity; }
            set { _Capacity = value; }
        }
        public string Type { get; set; }
    }
    #endregion

    #region #4
    public class Modul
    {
        private double Number1;
        private double Number2;

        public void AcceptDetails()
        {

            Console.WriteLine("enter number 1: ");
            Number1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("enter number 2: ");
            Number2 = Convert.ToDouble(Console.ReadLine());
        }

        public double findModul()
        {
            if (Number1 > Number2)
            {
                return Number1 % Number2;
            }
            else
            {
                return Number2 % Number1;
            }
        }
        public void Display()
        {
            Console.WriteLine("number1: {0}", Number1);
            Console.WriteLine("number2: {0}", Number2);
            Console.WriteLine("modul: {0}", findModul());
        }

    }
    #endregion

    #region #5

    public class Book
    {
        private string _Author { get; set; }
        private string _Name { get; set; }
        private int _Page { get; set; }
        public string Author { get => _Author; }
        public string Name { get => _Name; }
        public int Page { get => _Page; }

        public Book()
        {
            _Author = "Adam Fawer";
            _Name = "Olasiliksiz";
            _Page = 494;
        }
    }
    #endregion


}
