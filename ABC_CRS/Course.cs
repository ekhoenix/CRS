//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ABC_CRS
{
    using System;
    using System.Collections.Generic;
    
    public partial class Course
    {
        public Course()
        {
            this.Classes = new HashSet<Class>();
        }
    
        public string CourseCode { get; set; }
        public string CourseTitle { get; set; }
        public string CourseDescription { get; set; }
        public Nullable<int> Fees { get; set; }
        public string Instructors { get; set; }
        public Nullable<int> NoOfDays { get; set; }
    
        public virtual ICollection<Class> Classes { get; set; }
    }
}
