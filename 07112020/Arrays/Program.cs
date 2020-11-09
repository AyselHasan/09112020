using System;
using System.Linq;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            #region #1
            string[] Cars= { "BMW", "Mercedes", "Porsche", "Ford" };
            Cars[0] = "BMW";
            Cars[1] = "Mercedes";
            Cars[2] = "Porsche";
            Cars[3] = "Ford";
            Console.WriteLine(Cars[0]);
            Console.WriteLine(Cars[1]);
            Console.WriteLine(Cars[2]);
            Console.WriteLine(Cars[3]);

            Console.WriteLine(Cars.Length);

            for(int i=0; i<Cars.Length; i++)
            {
                Console.WriteLine(Cars[i]);
            }

            Console.WriteLine("*********************************************");
            int[] Numbers = { 9, 88, 76, 11, 4 };
            Console.WriteLine($"Maximum value: {Numbers.Max()}");
            Console.WriteLine($"Minimum value: {Numbers.Min()}");
            Console.WriteLine($"Total: {Numbers.Sum()}");

            int[] Numbers1 = new int[4] { 6, 8, 5, 4, };
            int[] Numbers2 = new int[6] { 9, 98, 44, 23, 5, 33 };
            int[] Numbers3 = { 77, 89, 55, 3 };
            int[] Numbers4 = new int[] { 66, 47, 88 };

            #endregion

            #region #2
            Console.WriteLine("********************************************");
            int[] IntArray = new int[5];
            IntArray[0] = 10;
            IntArray[1] = 20;
            IntArray[2] = 30;
            IntArray[3] = 40;
            IntArray[4] = 50;

            Console.WriteLine("\nfor:   \n");
            for (int i=0; i<IntArray.Length; i++)
            {
                Console.WriteLine(IntArray[i]);
            }
            
            Console.WriteLine("\nwhile:   \n");
            int j = 0;
            while (j < IntArray.Length){
                Console.WriteLine(IntArray[j]);
                j++;
            }

            Console.WriteLine("\ndoWhile:   \n");
            int k = 0;
            do
            {
                Console.WriteLine(IntArray[k]);
                k++;
            } while (k < IntArray.Length);

            #endregion

            #region #3
            string[] month = new string[12] { "Jan", "Feb", "Mar", "Apr", "May", "June", "July", "Aug", "Sep", "Oct", "Nov", "Dec" };
            Console.WriteLine("\nfor: ");
            for(int m=0; m<month.Length; m++)
            {
                Console.WriteLine(month[m]);
            }

            Console.WriteLine("\nwhile: ");
            int n = 0;
            while (n < month.Length)
            {
                Console.WriteLine(month[n]);
                n++;
            }

            Console.WriteLine("\ndoWhile: ");
            int l = 0;
            do    
            {
                Console.WriteLine(month[l]);
                l++;
            } while (l < month.Length);

            #endregion

            #region #4
            Console.WriteLine("__________________________________________");
            int[] evenNums = new int[] { 2, 4, 8, 10, 12 }; 
            for(int i=0; i<evenNums.Length; i++)
            {
                evenNums[i] = evenNums[i] + 10;
                Console.WriteLine(evenNums[i]); 
            }

            Console.WriteLine($"Sum: {evenNums.Sum()}");
            #endregion

            #region #5
            Console.WriteLine("__________________________________________");
            string[] Names = new string[3];
            Names[0] = "aaa";
            Names[1] = "bbb";
            Names[2] = "ccc";

            Array.Resize(ref Names, Names.Length + 1);

            Names[3] = "ddd";

            for(int h=0; h<Names.Length; h++)
            {
                Console.WriteLine(Names[h]);
            }
            #endregion
            
            #region #6
            Console.WriteLine("__________________________________________");
            int[] studentNO = new int[3];
            studentNO[0] = 1;
            studentNO[1] = 2;
            studentNO[2] = 3;

            Array.Resize(ref studentNO, studentNO.Length + 1);

            studentNO[3] = 4;

            int r = 0;
            while (r < studentNO.Length)
            {
                Console.WriteLine(studentNO[r]);
                r++;
            }
            #endregion

            #region #7
            //GoTo__break__continue getAge = new GoTo__break__continue();
            //getAge.GetAge();
            #endregion

            #region #8
            Console.WriteLine("______________________________");
            Drink Drink = new Drink();
            Drink.chooseDrink();
            #endregion

            #region #9
            Console.WriteLine("__________________________");
            for (int i = 0; i < 10; i++) 
            {
                if (i == 4)
                {
                    break;
                }

                Console.WriteLine(i);
            }
            Console.WriteLine("__________________________");
            for (int i = 0; i < 10; i++)
            {
                if (i == 4)
                {
                    continue;
                }

                Console.WriteLine(i);
            }

            Console.WriteLine("__________________________");
            int z = 0;
            while (z < 10)
            {
                Console.WriteLine(z);
                z++;
                if (z == 4)
                {
                    break;
                }
            }
            Console.WriteLine("__________________________");
            int y = 0;
            while (y < 10)
            {
                if (y == 4)
                {
                    y++;
                    continue;
                }
                Console.WriteLine(y);
                y++;
            }

            #endregion
        }
    }
}
