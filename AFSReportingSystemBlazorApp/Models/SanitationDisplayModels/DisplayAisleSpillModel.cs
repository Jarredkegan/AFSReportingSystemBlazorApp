using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AFSReportingSystemBlazorApp.Models.SanitationDisplayModels
{
    public class DisplayAisleSpillModel
    {
        public int Id { get; set; }

        [Required]
        public string Department { get; set; }

        [Required]
        public string Aisle { get; set; }

        public bool WetSpill { get; set; }

        public bool Glass { get; set; }

        public bool Scrubber { get; set; }

        public string Comments { get; set; }

        public DateTime Date { get; set; }

        public bool Complete { get; set; }

    }
}
