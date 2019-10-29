using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    class PrizeModel
    {
        /// <summary>
        /// The place that this prize goes to represented as an integer
        /// </summary>
        public int Place { get; set; }
        /// <summary>
        /// The name that will be used for this place i.e. Championship, Runner-Up
        /// </summary>
        public string PlaceName { get; set; }
        /// <summary>
        /// Amount to be awarded to the player
        /// </summary>
        public decimal PrizeAmount { get; set; }
        /// <summary>
        /// Percentage of the total prize pool that this particular prize represents
        /// </summary>
        public double PrizePercantage { get; set; }
    }
}
