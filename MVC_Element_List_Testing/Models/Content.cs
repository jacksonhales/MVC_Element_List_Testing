//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MVC_Element_List_Testing.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Content
    {
        public int Id { get; set; }
        public int SectionId { get; set; }
        public string Title { get; set; }
        public string Date { get; set; }
        public string Type { get; set; }
        public string Source { get; set; }
        public Nullable<int> DisplayPosition { get; set; }
    
        public virtual Section Section { get; set; }
    }
}