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
    
    public partial class BatchMaster
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BatchMaster()
        {
            this.BatchReportMasters = new HashSet<BatchReportMaster>();
            this.CandBatchMasters = new HashSet<CandBatchMaster>();
        }
    
        public int BatchId { get; set; }
        public string BatchTitle { get; set; }
        public System.DateTime BatchStartDate { get; set; }
        public System.DateTime BatchEndDate { get; set; }
        public bool IsBatchRunning { get; set; }
        public Nullable<int> BatchTakenBy { get; set; }
    
        public virtual UserMaster UserMaster { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BatchReportMaster> BatchReportMasters { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CandBatchMaster> CandBatchMasters { get; set; }
    }
}
