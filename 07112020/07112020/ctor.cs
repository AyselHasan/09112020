using System;
using System.Collections.Generic;
using System.Drawing;
using System.Dynamic;
using System.Text;

namespace _07112020
{
    #region #1
    class car
    {
        public string Model;
        public string Color;
        public int Year;

        public car()
        {
            Model = "Mustang";
            Color = "Red";
            Year = 2009;
        }
    }
    #endregion

    #region #2
    class Clothes
    {
        public string Brand { get; set; }
        public string Color { get; set; }
        public int Size { get; set; }
        public int Price { get; set; }
        public Clothes()
        {
            Size = 34;
            Brand = "Pull&Bear";
            Color = "Red";
            Price = 49;

        }
    }
    #endregion

}
    








