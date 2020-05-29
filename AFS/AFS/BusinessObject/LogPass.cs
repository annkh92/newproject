using System;
using System.Collections.Generic;
using System.Text;

namespace AFS
{
    class LogPass
    {
        public string myname { get; set; }
        public string mypass { get; set; }

        public LogPass(string myname, string mypass)
        {
            this.myname = myname;
            this.mypass = mypass;
        }
    }
}
