//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ReportDocumentationConsole.DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class Report_ReportSP
    {
        public int Id { get; set; }
        public Nullable<int> SSRSReportId { get; set; }
        public Nullable<int> ReportSPId { get; set; }
        public Nullable<System.DateTime> RowCreateDate { get; set; }
    
        public virtual SSRSReport1 SSRSReport { get; set; }
        public virtual ReportSP ReportSP { get; set; }
    }
}
