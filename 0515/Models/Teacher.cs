//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _0515.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Teacher
    {
        public Teacher()
        {
            this.Course = new HashSet<Course>();
        }
    
        public System.Guid ID { get; set; }
        public string TNo { get; set; }
        public string TName { get; set; }
        public System.DateTime ModifiedDT { get; set; }
    
        public virtual ICollection<Course> Course { get; set; }
    }
}
