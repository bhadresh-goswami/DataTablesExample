//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataTablesExample.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class JobDiscussMaster
    {
        public int JDId { get; set; }
        public string JDDescription { get; set; }
        public string CandName { get; set; }
        public System.DateTime JDDate { get; set; }
        public System.TimeSpan JDTime { get; set; }
        public string AssignedBy { get; set; }
        public bool IsJDIncentiveCal { get; set; }
        public string JDRemarks { get; set; }
    }
}
