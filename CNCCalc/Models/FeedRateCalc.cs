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
        /// <summary>
        /// Initializes a new instance of the FeedRateCalc class with default values for spindle speed, chip load, and number of flutes.
        /// </summary>
        public FeedRateCalc() : this(0, 0, 0)
        { }

        /// <summary>
        /// Initializes a new instance of the FeedRateCalc class with specified values for spindle speed, chip load, and number of flutes.
        /// </summary>
        /// <param name="spindleSpeed">Spindle speed in RPM</param>
        /// <param name="chipLoad">Chip load in inches per tooth</param>
        /// <param name="numberOfFlutes">Number of flutes on the tool</param>
        public FeedRateCalc(float spindleSpeed, float chipLoad, float numberOfFlutes)
        {
            this.spindleSpeed = spindleSpeed;
            this.chipLoad = chipLoad;
            this.numberOfFlutes = numberOfFlutes;
            CalculateFeedRate();
        }

        private float spindleSpeed;

        /// <summary>
        /// Gets or sets the spindle speed in RPM. Changing this value will automatically recalculate the feed rate.
        /// </summary>
        public float SpindleSpeed
        {
            get { return spindleSpeed; }    
            set { spindleSpeed = value; CalculateFeedRate(); }
        }

        private float chipLoad;

        /// <summary>
        /// Gets or sets the chip load in inches per tooth. Changing this value will automatically recalculate the feed rate.
        /// </summary>
        public float ChipLoad
        {
            get { return chipLoad; }
            set { chipLoad = value; CalculateFeedRate(); }
        }

        private float numberOfFlutes;

        /// <summary>
        /// Gets or sets the number of flutes on the tool. Changing this value will automatically recalculate the feed rate.
        /// </summary>
        public float NumberOfFlutes
        {
            get { return numberOfFlutes; }
            set { numberOfFlutes = value; CalculateFeedRate(); }
        }

        /// <summary>
        /// Gets the calculated feed rate in inches per minute (IPM). This value is automatically updated whenever the spindle speed, chip load, or number of flutes is changed.
        /// </summary>
        public float FeedRate { get; private set; } 

        private void CalculateFeedRate()
        {
            FeedRate = (spindleSpeed * chipLoad * numberOfFlutes) / 12;
        }

    }
}
