using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Course_Work
{
    internal class Passenger 
    {
        public bool registration { get; private set; }
        public bool willPassControl { get; private set; }
        public bool willPassCheckpointEnter { get; private set; }
        public bool willPassCheckpointBoadingArea { get; private set; }
        public int timeOnCheckpointEnter { get;  set; }
        public int timeOnRegistrationStand { get;  set; }
        public int timeOnCheckpointBoadArea { get;  set; }
        public int timeOnPasControl { get;  set; }

        Random random = new Random();

        public Passenger()
        {

        }
        public Passenger(int leftBorderCE, int rightBorderCE, int leftBorderR, int rightBorderR, int leftBorderBA, int rightBorderBA, int leftBorderPC, int rightBorderPC)
        {
            if (random.Next(0, 100) != 0) { willPassControl = true; } else willPassControl = false;
            if (random.Next(0, 100) != 0) { willPassCheckpointEnter = true; } else willPassCheckpointEnter = false;
            if (random.Next(0, 100) != 0) { willPassCheckpointBoadingArea = true; } else willPassCheckpointBoadingArea = false;
            if (random.Next(0, 3) == 1) { registration = false; } else registration = true;
            timeOnCheckpointEnter = TimeOnCheckpoint(leftBorderCE, rightBorderCE);
            timeOnRegistrationStand = TimeOnCheckpoint(leftBorderR, rightBorderR);
            timeOnCheckpointBoadArea = TimeOnCheckpoint(leftBorderBA, rightBorderBA);
            timeOnPasControl = TimeOnCheckpoint(leftBorderPC, rightBorderPC);
        }
        public int TimeOnCheckpoint(int leftBorder, int rightBorder)
        {
            Random time = new Random();
            return time.Next(leftBorder, rightBorder);
        }
    }
}
 