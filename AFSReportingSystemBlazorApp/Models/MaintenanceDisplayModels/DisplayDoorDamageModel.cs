﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AFSReportingSystemBlazorApp.Models.MaintenanceDisplayModels
{
    public class DisplayDoorDamageModel
    {
        public int Id { get; set; }

        [Required]
        public string Department { get; set; }

        [Required]
        public string Door { get; set; }

        public string Comments { get; set; }

        public DateTime Date { get; set; }

        public bool Complete { get; set; }
    }
}
