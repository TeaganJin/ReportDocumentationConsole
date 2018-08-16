﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ReportDocumentationConsole.DB;

namespace ReportDocumentationConsole.ViewModels
{
    public class ChangeHistoryViewModel
    {
        public List<ReportChangeLog> reportChangeLogs { get; set; }

        public ChangeHistoryViewModel(List<DB.ReportChangeLog> res)
        {
            DB.MSBDWEntities DB_MSBDW = new MSBDWEntities();
            reportChangeLogs = new List<ReportChangeLog>();
            foreach (var re in res)
            {
                ReportChangeLog temp = new ReportChangeLog();
                temp.ID = re.ID;
                temp.ItComment = re.ITComment;
                temp.PublicComment = re.PublicComment;
                temp.RowCreateDate = Convert.ToDateTime(re.RowCreateDate);
                temp.IsRDLChange = Convert.ToBoolean(re.IsRDLChange);
                try { temp.ReportSPName = DB_MSBDW.ReportSPs.FirstOrDefault(sp => sp.ID == re.ReportSPId).SPName; }
                catch (Exception e)
                {
                }
                
                reportChangeLogs.Add(temp);
            }
            
        }

       
    }

    public class ReportChangeLog
    {
        public int ID { get; set; }
        public string ReportSPName { get; set; }
        public DateTime RowCreateDate { get; set; }
        public string ItComment { get; set; }
        public string PublicComment { get; set; }
        public bool IsRDLChange { get; set; }
    }

}