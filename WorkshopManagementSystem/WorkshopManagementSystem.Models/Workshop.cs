using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkshopManagementSystem.Models
{
    public class Workshop
    {
        public int WorkshopID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public int Capacity { get; set; }
    }
}
