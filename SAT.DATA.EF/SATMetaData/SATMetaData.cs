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

}

    

