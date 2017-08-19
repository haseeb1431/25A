using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Education25A.Models
{
    public class Students
    {
        public long ID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string FatherName { get; set; }
        public long TotalIncome{ get; set; }
        public string IncomeEvidence { get; set; }
        public string StudentAddress { get; set; }
        public string StudentCity { get; set; }
        public string StudentProvince { get; set; }
        public string ContactNumber { get; set; }
        public DateTime DateOfBirth { get; set; }
        
        //        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}