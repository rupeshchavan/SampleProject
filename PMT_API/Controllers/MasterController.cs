using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PMT_API.Controllers
{
    public class MasterController : ApiController
    {
        public Dictionary<int, string> GetState()
        {
            Dictionary<int, string> obj = new Dictionary<int, string>();
            obj.Add(1, "");


            return obj;
        }
    }
}
