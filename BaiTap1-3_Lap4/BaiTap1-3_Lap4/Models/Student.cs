namespace BaiTap1_3_Lap4.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Student")]
    public partial class Student
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int StudentID { get; set; }

        [StringLength(200)]
        public string FullName { get; set; }

        public double? AverageScore { get; set; }

        public int? FacultyID { get; set; }

        public virtual Falculty Falculty { get; set; }
    }
}
