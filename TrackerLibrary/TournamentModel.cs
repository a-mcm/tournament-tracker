﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    class TournamentModel
    {
        /// <summary>
        /// Name of the tournament
        /// </summary>
        public string TournamentName { get; set; }
        /// <summary>
        /// The fee that each team or player has to pay to be entered into the tournament
        /// </summary>
        public decimal EntryFee { get; set; }
        /// <summary>
        /// A list of the teams that have been entered in to the tournament
        /// </summary>
        public List<TeamModel> EnteredTeams { get; set; } = new List<TeamModel>();
        /// <summary>
        /// List of prizes that will be awarded in this tournament
        /// </summary>
        public List<PrizeModel> Prizes { get; set; } = new List<PrizeModel>();
        /// <summary>
        /// </summary>
        public List<List<MatchupModel>> Rounds { get; set; } = new List<List<MatchupModel>>();

    }
}
