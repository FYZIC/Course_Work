using Course_Work;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork
{
    interface IPassengerService
    {
        public double Queue(List<Passenger> passengers, int checkpointCount, int passengerCount); 
    }
}
