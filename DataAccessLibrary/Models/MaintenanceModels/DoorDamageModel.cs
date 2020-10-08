using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLibrary.Models.MaintenanceModels
{
    public class DoorDamageModel
    {
        public int Id { get; set; }

        public string Department { get; set; }

        public string Door { get; set; }

        public string Comments { get; set; }

        public DateTime Date { get; set; }

        public bool Complete { get; set; }
    }
}

