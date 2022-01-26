using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTrackerLibrary
{
    class TeamModel
    {
        /// <summary>
        /// Name of team.
        /// </summary>
        public string TeamName { get; set; }

        /// <summary>
        /// List of all team members on this team.
        /// </summary>
        public List<PersonModel> TeamMembers { get; set; } = new List<PersonModel>();

        /// <summary>
        /// All tickets assigned to this team.
        /// </summary>
        public List<TicketModel> AssignedTickets { get; set; } = new List<TicketModel>();
    }
}
