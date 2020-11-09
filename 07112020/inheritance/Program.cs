using System;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;

namespace inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            #region #1
            Car Newcar = new Car();
            Newcar.Honk();
            Console.WriteLine($"Brand: {Newcar.Brand} \nModel Name: {Newcar.ModelName}");
            #endregion

            #region #2
            Animal animal1 = new Animal();
            animal1.Greet();
            Console.WriteLine("***************");
            Dog dog = new Dog();
            dog.Greet();
            #endregion

            #region #3
            Rectangle1 rect1 = new Rectangle1();
            rect1.SetWidth(7);
            rect1.SetHeight(11);

            Console.Write($"Total Area:");
            rect1.GetArea();
            #endregion

            #region #4
            Shoes SportShoes = new Shoes();
            SportShoes.Brand = "Nike";
            SportShoes.Color = "Black";
            SportShoes.Size = 35;

            Console.WriteLine($"Brand of Shoes: {SportShoes.Brand} \nColor of Shoes: {SportShoes.Color} \nSize of Shoes: {SportShoes.Size}");
            Console.WriteLine("*************************************************************");

            SportShoes.Wearing();
            #endregion

            #region #5

            GeekForGeeks gfg = new GeekForGeeks();
            gfg.Readers("Kirti", "C#");

            #endregion

            #region #6

            Engineer newEngineer = new Engineer();
            newEngineer.GetSalary();

            #endregion

        }
    }
}
