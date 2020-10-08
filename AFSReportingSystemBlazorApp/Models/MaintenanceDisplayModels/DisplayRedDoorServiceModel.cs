using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AFSReportingSystemBlazorApp.Models.MaintenanceDisplayModels
{
    public class DisplayRedDoorServiceModel
    {
        public int Id { get; set; }

        public string Location { get; set; }

        public string Comments { get; set; }

        public DateTime Date { get; set; }

        public bool Complete { get; set; }
    }
}
