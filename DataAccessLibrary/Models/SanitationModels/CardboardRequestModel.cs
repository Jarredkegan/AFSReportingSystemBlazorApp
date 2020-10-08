using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLibrary.Models.SanitationModels
{
    public class CardboardRequestModel
    {
        public int Id { get; set; }
        public string Department { get; set; }
        public string Dock { get; set; }
        public string Comments { get; set; }
        public DateTime Date { get; set; }
        public bool Complete { get; set; }
    }
}
