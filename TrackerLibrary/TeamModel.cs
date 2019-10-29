using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    class TeamModel
    {
        /// <summary>
        /// A list of every player (PersonModel) in this particular team
        /// </summary>
        public List<PersonModel> TeamMembers { get; set; } = new List<PersonModel>();
        /// <summary>
        /// Name of this team
        /// </summary>
       
        public string TeamName { get; set; }
    }
}
