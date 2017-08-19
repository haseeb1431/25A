using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Education25A.Models
{
    public class School
    {
        public long ID { get; set; }
        public string SchoolName { get; set; }
        public string StudentAddress { get; set; }
        public string StudentCity { get; set; }
        public string StudentProvince { get; set; }
        public string ContactNumber1 { get; set; }
        public string ContactNumber2 { get; set; }
        public long TotalEnrollment { get; set; }
        public string FocalPersonName { get; set; }
        public string FocalPersonContact { get; set; }
    }
}