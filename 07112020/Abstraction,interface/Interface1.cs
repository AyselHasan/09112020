using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraction_interface
{
    #region #12
    interface Interface1
    {
        void display();
    }

    class TestClass : Interface1
    {
        public void display()
        {
            Console.WriteLine("Sudo Placement GeeksforGeeks");
        }
    }
    #endregion

    #region #13
    interface Vehicle
    {
        void ChangeGear(int a);
        void SpeedUp(int a);
        void applyBrakes(int a);
    }

    class Bicycle : Vehicle
    {
        public int speed;
        public int gear;

        public void ChangeGear(int newGear)
        {
            gear = newGear;
        }

        public void SpeedUp(int increment)
        {
            speed = speed + increment;
        }

        public void applyBrakes(int decrement)
        {
            speed = speed - decrement;
        }

        public void PrintStates()
        {
            Console.WriteLine($"Speed: {speed} \ngear: {gear}");
        }
    }

    class Bike : Vehicle
    {
        public int speed;
        public int gear;

        public void ChangeGear(int newGear)
        {
            gear = newGear;
        }

        public void SpeedUp(int increment)
        {
            speed = speed + increment;
        }

        public void applyBrakes(int decrement)
        {
            speed = speed - decrement;
        }

        public void PrintStates()
        {
            Console.WriteLine($"Speed: {speed} \ngear: {gear}");
        }
    }
    #endregion
}
