using Course_Work;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork
{
    internal class CheckpointBoadingArea : IPassengerService
    {
        double overallTimeOnCheckpoint;
        public double Queue(List<Passenger> passengers, int checkpointBoadingAreaCount, int passengerCount)
        {
            overallTimeOnCheckpoint = 0;
            //for (int i = 0; i < passengerCount; i++)
            //{
            //    overallTimeOnCheckpoint += passengers[i].timeOnCheckpointBoadArea;
            //}

            ////Medium_time_on_checkpoint
            //return overallTimeOnCheckpoint / passengerCount;

            for (int i = 0; i < passengers.Count - 1; i++)
            {
                passengers[i + 1].timeOnCheckpointBoadArea += passengers[i].timeOnCheckpointBoadArea;

                overallTimeOnCheckpoint += passengers[i].timeOnCheckpointBoadArea;
            }
            return Math.Ceiling((overallTimeOnCheckpoint / passengerCount) / checkpointBoadingAreaCount);
        }
    }
}
