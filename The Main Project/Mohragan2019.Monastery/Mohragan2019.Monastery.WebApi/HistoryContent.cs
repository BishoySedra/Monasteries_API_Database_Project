//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Mohragan2019.Monastery.WebApi
{
    using System;
    using System.Collections.Generic;
    
    public partial class HistoryContent
    {
        public int ID { get; set; }
        public string ParagraphContent { get; set; }
        public int HistoryID { get; set; }
    
        public virtual History History { get; set; }
    }
}