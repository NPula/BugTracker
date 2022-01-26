using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTrackerLibrary
{
    class TicketSystemModel
    {
        /// <summary>
        /// All tickets in the system.
        /// </summary>
        public List<TicketModel> AllTickets { get; set; } = new List<TicketModel>();
    }
}
