using Course_Work;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork
{
    internal class CheckpointPasControl : IPassengerService
    {
        double overallTimeOnCheckpoint;
        public double Queue(List<Passenger> passengers, int checkpointPassControlCount, int passengerCount)
        {
            overallTimeOnCheckpoint = 0;
            //for (int i = 0; i < passengerCount; i++)
            //{
            //    overallTimeOnCheckpoint += passengers[i].timeOnPasControl;
            //}

            ////Medium_time_on_checkpoint
            //return overallTimeOnCheckpoint / passengerCount;

            for (int i = 0; i < passengers.Count - 1; i++)
            {
                passengers[i + 1].timeOnPasControl += passengers[i].timeOnPasControl;

                overallTimeOnCheckpoint += passengers[i].timeOnPasControl;
            }
            return Math.Ceiling(overallTimeOnCheckpoint / passengerCount) / checkpointPassControlCount;
        }
    }
}
