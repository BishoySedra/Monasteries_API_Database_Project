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
    
    public partial class StoryTitle
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public StoryTitle()
        {
            this.StoryParagraphs = new HashSet<StoryParagraph>();
        }
    
        public int ID { get; set; }
        public string Title { get; set; }
        public int FatherID { get; set; }
    
        public virtual Father Father { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StoryParagraph> StoryParagraphs { get; set; }
    }
}
