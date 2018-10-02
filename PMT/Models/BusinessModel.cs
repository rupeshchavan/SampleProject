using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PMT.Models
{
    public class BusinessModel { }

    public class Builder
    {
        public int Id { get; set; }
        public string FName { get; set; }
        public string MName { get; set; }
        public string LName { get; set; }
        public string PANNO { get; set; }
        public string AadharNo { get; set; }
        public string VoterId { get; set; }
        public string Education { get; set; }
        public string RegNo { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int Pincode { get; set; }
        public int TotalProjects { get; set; }

    }


    public class Customer
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public DateTime DOB { get; set; }
        public char Gender { get; set; }
        public bool MaritalStatus { get; set; }

        public string PAN { get; set; }
        public string AadharNo { get; set; }
        public string VoterID { get; set; }

        public string Education { get; set; }
        public string EmploymentType { get; set; }
        public string WorkNature { get; set; }
        public string CompanyName { get; set; }
        public string Designation { get; set; }
        public string AnnualIncome { get; set; }

        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int Pincode { get; set; }

        public int MobileNo { get; set; }
        public string EmailId { get; set; }

    }

    public class Agent
    {
        public int Id { get; set; }
        public string FName { get; set; }
        public string MName { get; set; }
        public string LName { get; set; }
        public string PANNO { get; set; }
        public string AadharNo { get; set; }
        public string VoterId { get; set; }
        public string Education { get; set; }
        public string RegNo { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int Pincode { get; set; }
    }

    public class Owner
    {
        public int Id { get; set; }
        public string FName { get; set; }
        public string MName { get; set; }
        public string LName { get; set; }
        public string PANNO { get; set; }
        public string AadharNo { get; set; }
        public string VoterId { get; set; }
        public string Education { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int Pincode { get; set; }
        public int TotalProjects { get; set; }
    }


    public class Government
    {
        public int Id { get; set; }
        public string NoticeNo { get; set; }
        public string NoticeDetails { get; set; }
    }



    public class Banks
    {
        public int Id { get; set; }
        public int BankId { get; set; }
        public string Name { get; set; }
        public string RegNo { get; set; }
        public string PANNO { get; set; }
        public string HOAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int Pincode { get; set; }
    }

    public class FIs
    {
        public int Id { get; set; }
        public int FIId { get; set; }
        public string Name { get; set; }
        public string RegNo { get; set; }
        public string PANNO { get; set; }
        public string HOAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int Pincode { get; set; }
    }



}