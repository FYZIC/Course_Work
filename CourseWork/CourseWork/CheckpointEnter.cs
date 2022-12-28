using Course_Work;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork
{
    internal class CheckpointEnter : IPassengerService
    {
        double overallTimeOnCheckpoint;
        public double Queue(List<Passenger> passengers, int checkpointEnterCount, int passengerCount)
        {
            overallTimeOnCheckpoint = 0;
            // for (int i = 0; i < passengerCount; i++)
            // {
            //     overallTimeOnCheckpoint += passengers[i].timeOnCheckpointEnter;
            // }

            ////Medium_time_on_checkpoint
            // return overallTimeOnCheckpoint / passengerCount;

            for (int i = 0; i < passengers.Count - 1; i++)
            {
                passengers[i + 1].timeOnCheckpointEnter += passengers[i].timeOnCheckpointEnter;

                overallTimeOnCheckpoint += passengers[i].timeOnCheckpointEnter;
            }
            return Math.Ceiling((overallTimeOnCheckpoint / passengerCount) / checkpointEnterCount);
        }
    }
}
