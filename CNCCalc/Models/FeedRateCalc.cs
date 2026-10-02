using System;
using System.Collections.Generic;
using System.Text;

namespace CNCCalc.Models
{
    /// <summary>
    /// Calculates the feed rate for CNC machining based on various parameters such as spindle speed, tool diameter, and material type.
    /// Formula: Feed Rate (IPM) = (Spindle Speed (RPM) * Chip Load (inches per tooth) * Number of Flutes) / 12
    /// </summary>
    public class FeedRateCalc
    {
        public FeedRateCalc() : this(0, 0, 0)
        { }

        public FeedRateCalc(float spindleSpeed, float chipLoad, float numberOfFlutes)
        {
            this.spindleSpeed = spindleSpeed;
            this.chipLoad = chipLoad;
            this.numberOfFlutes = numberOfFlutes;
            CalculateFeedRate();
        }

        private float spindleSpeed;

        public float SpindleSpeed
        {
            get { return spindleSpeed; }    
            set { spindleSpeed = value; CalculateFeedRate(); }
        }

        private float chipLoad;

        public float ChipLoad
        {
            get { return chipLoad; }
            set { chipLoad = value; CalculateFeedRate(); }
        }

        private float numberOfFlutes;

        public float NumberOfFlutes
        {
            get { return numberOfFlutes; }
            set { numberOfFlutes = value; CalculateFeedRate(); }
        }

        public float FeedRate { get; private set; } 

        public void CalculateFeedRate()
        {
            FeedRate = (spindleSpeed * chipLoad * numberOfFlutes) / 12;
        }

    }
}
