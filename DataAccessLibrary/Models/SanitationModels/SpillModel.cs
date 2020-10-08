using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLibrary.Models.SanitationModels
{
    public class SpillModel
    {
        public int Id { get; set; }
        public string Department { get; set; }
        public string Aisle { get; set; }
        public bool WetSpill { get; set; }
        public bool Glass { get; set; }
        public bool Scrubber { get; set; }
        public string Comments { get; set; }
        public DateTime Date { get; set; }
        public bool Complete { get; set; }
    }
}
