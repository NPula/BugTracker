using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTrackerLibrary
{
    class PersonModel
    {
        /// <summary>
        /// First name of user.
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Last name of user.
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Email for user.
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Phone number for user.
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// List of teams user is apart of.
        /// </summary>
        public List<TeamModel> Teams { get; set; } = new List<TeamModel>();

        /// <summary>
        /// List of tickets assigned to the user.
        /// </summary>
        public List<TicketModel> AssignedTickets { get; set; } = new List<TicketModel>();
    }
}
