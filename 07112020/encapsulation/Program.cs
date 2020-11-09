using System;

namespace encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            #region #1
            Rectangle r1 = new Rectangle();

            r1.acceptDetails();
            r1.Display();

            Console.ReadLine();
            #endregion

            #region #2
            Person Person1 = new Person();
            Person1.name = "Liam";
            Console.WriteLine(Person1.name);
            #endregion

            #region #3
            School school243 = new School();
            school243.Capacity = 250;
            Console.WriteLine(school243.Capacity);
            #endregion

            #region #4

            Modul modul1 = new Modul();

            modul1.AcceptDetails();
            modul1.Display();
            #endregion

            #region #5

            Book newBook = new Book();
            Console.WriteLine($"Author of book: {newBook.Author} \nName of book: {newBook.Name} \nPage: {newBook.Page}");

            #endregion

        }
    }
}
