//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MiniDbTest.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblAnswer
    {
        public long AnswerID { get; set; }
        public int ConsumerHistoryID { get; set; }
        public int QuestionID { get; set; }
        public string Answer { get; set; }
        public Nullable<System.DateTime> CreateDt { get; set; }
        public Nullable<System.DateTime> LastModDt { get; set; }
        public Nullable<int> CreatedByID { get; set; }
        public Nullable<int> ModifiedByID { get; set; }
    }
}
