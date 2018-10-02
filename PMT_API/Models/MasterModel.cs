using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PMT_API.Models
{
    public class MasterModel
    {
    }

    public class State_Master
    {
        public int State_Code { get; set; }
        public string State_Name { get; set; }
    }

    public class City_Master
    {
        public int City_Code { get; set; }
        public string City_Name { get; set; }
        public int State_Code { get; set; }
    }

    public class Pincode_Master
    {
        public int pincode { get; set; }
        public int City_Code { get; set; }
    }
}