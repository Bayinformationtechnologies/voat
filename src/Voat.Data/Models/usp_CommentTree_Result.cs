//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Voat.Data.Models
{
    using System;
    
    public partial class usp_CommentTree_Result
    {
        public Nullable<int> ChildCount { get; set; }
        public Nullable<int> Depth { get; set; }
        public string Path { get; set; }
        public string Subverse { get; set; }
        public int ID { get; set; }
        public string UserName { get; set; }
        public string Content { get; set; }
        public System.DateTime CreationDate { get; set; }
        public Nullable<System.DateTime> LastEditDate { get; set; }
        public Nullable<int> SubmissionID { get; set; }
        public long UpCount { get; set; }
        public long DownCount { get; set; }
        public Nullable<int> ParentID { get; set; }
        public bool IsAnonymized { get; set; }
        public bool IsDistinguished { get; set; }
        public string FormattedContent { get; set; }
        public bool IsDeleted { get; set; }
    }
}
