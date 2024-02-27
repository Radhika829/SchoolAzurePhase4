using System;
using System.Collections.Generic;

namespace P4SchoolAzure.Models
{
    public partial class Student
    {
        public int StudentId { get; set; }
        public string? Fname { get; set; }
        public string? Lname { get; set; }
        public string? Course { get; set; }
        public string? Gender { get; set; }
    }
}
