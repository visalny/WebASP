using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WAD.Controllers
{
    public class M3Controller : Controller
    {
        // GET: M3
        public string Default()
        {
            return "It's a <strong>Default|Index</strong> action method...";
        }
        public string Welcome(int stuID=2,string stuName="Linda")
        {

            return "Hi, " + stuName + "<h3>[" + stuID + "]</h3>";
        }
    }
}