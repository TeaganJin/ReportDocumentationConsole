﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ReportDocumentationConsole.ViewModels
{
    public class ReportsViewModel
    {

        public List<DB.SSRSReport1> reports { get; set; }
        public List<DB.ReportSP> sps { get; set; }
        public string reportname { get; set; }
        public DB.SSRSReport1 report { get; set; }
        public List<string> names { get; set; }

        public List<string> names2 { get; set; }


    }
}