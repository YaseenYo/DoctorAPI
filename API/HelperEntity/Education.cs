using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.HelperEntity
{
    public class Education
    {
        public int Id { get; set; }
        public string CollegeName { get; set; }
        public string Degree { get; set; }
        public int StartYear { get; set; }
        public int EndYear { get; set; }
    }
}
