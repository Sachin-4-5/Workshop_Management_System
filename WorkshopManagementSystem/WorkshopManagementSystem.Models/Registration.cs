using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkshopManagementSystem.Models
{
    public class Registration
    {
        public int RegistrationID { get; set; }
        public int UserID { get; set; }
        public int WorkshopID { get; set; }
        public DateTime RegistrationDate { get; set; }


        // Extra properties from JOIN query
        public string WorkshopTitle { get; set; }
        public DateTime WorkshopDate { get; set; }
    }
}
