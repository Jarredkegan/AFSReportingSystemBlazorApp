﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLibrary.Models.MaintenanceModels
{
    public class RackDamageModel
    {
        public int Id { get; set; }
        public string Department { get; set; }
        public string Slot { get; set; }
        public string Comments { get; set; }
        public DateTime Date { get; set; }
        public bool Complete { get; set; }
    }
}
