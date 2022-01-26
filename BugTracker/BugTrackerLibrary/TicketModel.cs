using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTrackerLibrary
{
    class TicketModel
    {
        /// <summary>
        /// Name of user that created the ticket
        /// </summary>
        public string NameOfCreator { get; set; }

        /// <summary>
        /// Name of a user assigned to the ticket.
        /// </summary>
        public string NameOfAssignee { get; set; }

        /// <summary>
        /// Team the ticket will be assigned to.
        /// </summary>
        public TeamModel Team { get; set; }

        /// <summary>
        /// Phone number for user who completed the ticket.
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// Email for user who completed the ticket.
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Summary of issue.
        /// </summary>
        public string Summary { get; set; }

        /// <summary>
        /// More thoughough description of the issue.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Priority for the issue.
        /// </summary>
        public int Priority { get; set; }
    }
}
