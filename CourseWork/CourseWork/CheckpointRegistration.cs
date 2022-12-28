using Course_Work;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork
{
    internal class CheckpointRegistration : IPassengerService
    {
        double overallTimeOnCheckpoint;
        public double Queue(List<Passenger> passengers, int registrationStandCount, int passengerCount)
        {
            overallTimeOnCheckpoint = 0;
            //for (int i = 0; i < passengerCount; i++)
            //{
            //    overallTimeOnRegistrationStand += passengers[i].timeOnRegistrationStand;
            //}

            ////Medium_time_on_registration_stand
            //return overallTimeOnRegistrationStand / passengerCount;

            for (int i = 0; i < passengers.Count - 1; i++)
            {
                passengers[i + 1].timeOnRegistrationStand += passengers[i].timeOnRegistrationStand;

                overallTimeOnCheckpoint += passengers[i].timeOnRegistrationStand;
            }
            return Math.Ceiling((overallTimeOnCheckpoint / passengerCount) / registrationStandCount);
        }
    }
}
