using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FOREAL_API.Models
{
    public class Response
    {
        public int StatusCode { get; set; }
        public string Message { get; set; }
        public List<Donation> Donations { get; set; }
    }
}
