using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PMT.Models
{
    public class Customer
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public DateTime DOB { get; set; }
        public char Gender { get; set; }

        public string PAN { get; set; }
        public string Adhar { get; set; }
        public string VoterID { get; set; }

        public string LastEducation { get; set; }
        public string EmploymentType { get; set; }
        public string WorkNature { get; set; }
        public string CompanyName { get; set; }
        public string Designation { get; set; }
        public string AnnualIncome { get; set; }

        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int Pincode { get; set; }
    }
}
