﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversity.Models
{
    public partial class Course : IIsDeleted
    {
        public Course()
        {
            CourseInstructor = new HashSet<CourseInstructor>();
            Enrollment = new HashSet<Enrollment>();
        }

        [Key]
        public int CourseID { get; set; }
        [StringLength(50)]
        public string Title { get; set; }
        public int Credits { get; set; }
        public int DepartmentID { get; set; }
        [Required, DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [Column(TypeName = "datetime")]
        public DateTime DateModified { get; set; }

        [ForeignKey(nameof(DepartmentID))]
        [InverseProperty("Course")]
        public virtual Department Department { get; set; }
        [InverseProperty("Course")]
        public virtual ICollection<CourseInstructor> CourseInstructor { get; set; }
        [InverseProperty("Course")]
        public virtual ICollection<Enrollment> Enrollment { get; set; }

        [Column(TypeName ="bit")]
        public bool IsDeleted { get; set; }
    }
}