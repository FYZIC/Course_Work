using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Course_Work
{
    internal class PassengerList
    {
        public int count_passengers = 0;

        public List<Passenger> NewPassengerList(int leftBorderP, int rightBorderP, int leftBorderC, int rightBorderC, int leftBorderR, int rightBorderR, int leftBorderBA, int rightBorderBA, int leftBorderPC, int rightBorderPC)
        {
            SetPassengersCount(leftBorderP, rightBorderP);
            Random random = new Random();
            List<Passenger> passengers = new List<Passenger>();

            for (int i = 0; i < count_passengers; i++)
            {
                passengers.Add(new Passenger(leftBorderC, rightBorderC, leftBorderR, rightBorderR, leftBorderBA, rightBorderBA, leftBorderPC, rightBorderPC));
            }
            return passengers;
        }
        public int SetPassengersCount(int leftBorder, int rightBorder) 
        {
            Random rnd = new Random();
            return count_passengers = rnd.Next(leftBorder, rightBorder);
        }

        public int GetPassengersCount() 
        {
            return count_passengers;
        }


    }
}
