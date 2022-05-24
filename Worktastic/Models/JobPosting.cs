using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Worktastic.Models
{
    public class Jobposting
    {
        public int id { get; set; }
        public string JobTitle { get; set; }
        public string Description { get; set; }
        public int Salary { get; set; }
        public DateTime StartDate { get; set; }
        public string ContactPhone { get; set; }
        public string ContactMail { get; set; }
        public string ContactWebsite { get; set; }
        public byte[] CompanyImage { get; set; }

    }
}
