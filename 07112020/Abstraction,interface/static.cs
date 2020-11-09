using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraction_interface
{
    class @static
    {
        
    }
    #region #8
    static class Tutorial
    {
        public static string Topic = "Static class";

    }
    public class GFG
    {
        public void Method1()
        {
            Console.WriteLine($"Topic name is: {Tutorial.Topic}");
        }
    }
    #endregion

    #region #9
    class Shoes
    {
        public static string Color = "Red";
        public static int Size = 35;

        public void Info()
        {
            Console.WriteLine($"Color of shoes: {Shoes.Color} \nSize of shoes: {Shoes.Size}");
        }
    }

    #endregion

    #region #10
    class Nparks
    {
        public static int t = 104;
        public void Total()
        {
            Console.WriteLine($"Total numbers of National Parks in India is: {Nparks.t}");
        }
    }
    #endregion

    #region #11
    class School
    {
        public static string Addres = "Shovkat Alakbarova str. 35";
        public static int Capacity = 550;
        public void GetInfo()
        {
            Console.WriteLine($"Address: {School.Addres} \nCapacity: {School.Capacity}");
        }
    }
    #endregion

}
