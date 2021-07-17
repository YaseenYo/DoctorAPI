using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.HelperEntity
{
    public class Location
    {
        public int Id { get; set; }
        public string HospitalName { get; set; }
        public string Address { get; set; }
        public string Rating { get; set; }
        public string Fees { get; set; }
    }
}
