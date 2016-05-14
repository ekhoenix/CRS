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
    
    public partial class Participant
    {
        public Participant()
        {
            this.Registrations = new HashSet<Registration>();
        }
    
        public string PID { get; set; }
        public string Salutation { get; set; }
        public string FullName { get; set; }
        public string Gender { get; set; }
        public string Nationality { get; set; }
        public Nullable<System.DateTime> DateOfBirth { get; set; }
        public string Email { get; set; }
        public Nullable<int> ContactNumber { get; set; }
        public string EmployementStatus { get; set; }
        public string CompanyID { get; set; }
        public string ComapanyName { get; set; }
        public Nullable<int> OrganizationSize { get; set; }
        public string JobTitle { get; set; }
        public string Department { get; set; }
        public Nullable<int> SalaryRange { get; set; }
        public string DietaryRequirement { get; set; }
    
        public virtual Company Company { get; set; }
        public virtual ICollection<Registration> Registrations { get; set; }
    }
}