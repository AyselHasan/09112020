using System;
using System.Collections.Generic;
using System.Text;

namespace Arrays
{
    public class GoTo__break__continue
    {
        #region #7
        public void GetAge()
        {
            Console.WriteLine("_______________________");
            check:
            Console.WriteLine("You aren't eligible to vote!");

            Console.WriteLine("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            if (age < 18)
            {
                goto check;
            }
            else
            {
                Console.WriteLine("You are eligible to vote!");
            }

        }
        #endregion

    }
    public class Drink
    {
        #region #8

        public void chooseDrink()
        {
            check:

            Console.WriteLine("What do u want to drink?");
            Console.WriteLine("coffe = 0");
            Console.WriteLine("tea = 1");
            int choose = Convert.ToInt32(Console.ReadLine());

            switch (choose)
            {
                case 0:
                    double price = 7.00;
                    Console.WriteLine($"Price: {price}AZN, Bon Appetit!");
                    break;

                case 1:
                    double price1 = 5.00;
                    Console.WriteLine($"Price: {price1}AZN, Bon Appetit!");
                    break;

                default:
                    goto check;
            }

        }

        #endregion
    }

   
}
