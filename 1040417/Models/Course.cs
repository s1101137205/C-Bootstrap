//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _1040417.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Course
    {
        public Course()
        {
            this.StudentCourse = new HashSet<StudentCourse>();
        }
    
        public System.Guid ID { get; set; }
        public string CourseNo { get; set; }
        public string CourseName { get; set; }
        public System.Guid TeacherID { get; set; }
        public System.DateTime ModifiedDT { get; set; }
    
        public virtual Teacher Teacher { get; set; }
        public virtual ICollection<StudentCourse> StudentCourse { get; set; }
    }
}