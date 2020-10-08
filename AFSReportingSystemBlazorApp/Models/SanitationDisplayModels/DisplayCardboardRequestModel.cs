using System;
using System.ComponentModel.DataAnnotations;

namespace AFSReportingSystemBlazorApp.Models.SanitationDisplayModels
{
    public class DisplayCardboardRequestModel
    {
        public int Id { get; set; }

        [Required]
        public string Department { get; set; }

        [Required]
        public string Dock { get; set; }

        public string Comments { get; set; }
        public DateTime Date { get; set; }
        public bool Complete { get; set; }
    }
}
