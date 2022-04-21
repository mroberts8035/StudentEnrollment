using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace SAT.DATA.EF//.SATMetaData
{

    public class EnrollmentMetadata
    {
        [Required(ErrorMessage = "*")]
        [Display(Name = "Student ID")]
        public int StudentId { get; set; }
        [Required(ErrorMessage = "*")]
        [Display(Name = "Scheduled Class ID")]
        public int ScheduledClassId { get; set; }
        [Required(ErrorMessage = "*")]
        [Display(Name = "Enrollment Date")]
        public DateTime EnrollmentDate { get; set; }
    }

    
    public class StudentMetadata
    {
        [Required(ErrorMessage = "*")]
        [Display(Name = "First Name")]
        [StringLength(50)]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "*")]
        [Display(Name = "Last Name")]
        [StringLength(50)]
        public string LastName { get; set; }
        [StringLength(50)]
        public string Major { get; set; }
        [StringLength(50)]
        public string Address { get; set; }
        [StringLength(50)]
        public string City { get; set; }
        [StringLength(2)]
        public string State { get; set; }
        [StringLength(50)]
        public string ZipCode { get; set; }
        [StringLength(50)]
        public string Phone { get; set; }
        [Required(ErrorMessage = "*")]
        [StringLength(50)]
        public string Email { get; set; }
        [StringLength(100)]
        public string PhotoUrl { get; set; }
        [Required(ErrorMessage = "*")]
        public int SSID { get; set; }
    }

    [MetadataType(typeof(StudentMetadata))]
    public partial class Student
    {
        //Create a custom, read-only property for FullName and update the Display attribute
        [Display(Name = "Student")]
        public string FullName
        {
            get { return FirstName + " " + LastName; }
        }
    }

    public class StudentStatusMetadata
    {
        [Required(ErrorMessage = "*")]
        [StringLength(50)]
        [Display(Name = "Status ID")]
        public string SSName { get; set; }
        [StringLength(250)]
        [Display(Name = "Description")]
        public string SSDecription { get; set; }
    }


    public class CoursMetadata
    {
        [Required(ErrorMessage = "*")]
        [Display(Name = "Course Name")]
        [StringLength(50)]
        public string CourseName { get; set; }
        [Required(ErrorMessage = "*")]
        [Display(Name = "Description")]
        public string CourseDescription { get; set; }
        [Required(ErrorMessage = "*")]
        [Display(Name = "Credit Hours")]
        public byte CreditHours { get; set; }
        [StringLength(250)]
        public string Curriculum { get; set; }
        [StringLength(500)]
        public string Notes { get; set; }
        [Required(ErrorMessage = "*")]
        public bool IsActive { get; set; }
    }

    public class ScheduledClassMetadata
    {
        [Required(ErrorMessage = "*")]
        public int CourseId { get; set; }
        [Required(ErrorMessage = "*")]
        public System.DateTime StartDate { get; set; }
        [Required(ErrorMessage = "*")]
        public System.DateTime EndDate { get; set; }
        [Required(ErrorMessage = "*")]
        [Display(Name = "Instructor")]
        [StringLength(50)]
        public string InstructorName { get; set; }
        [Required(ErrorMessage = "*")]
        [StringLength(50)]
        public string Location { get; set; }
        [Required(ErrorMessage = "*")]
        public int SCSID { get; set; }
    }

    [MetadataType(typeof(ScheduledClassMetadata))]
    public partial class ScheduledClass
    {
        //Create a custom, read-only property for FullName and update the Display attribute
        [Display(Name = "Class Summary")]
        public string Summary
        {
            get { return StartDate + " " + Cours.CourseName + " " + Location; }
        }
    }

    public class ScheduledCalssStatusMetadata
    {
        [Required(ErrorMessage = "*")]
        [Display(Name = "Course Name")]
        [StringLength(50)]
        public string SCSName { get; set; }
    }

}

    

