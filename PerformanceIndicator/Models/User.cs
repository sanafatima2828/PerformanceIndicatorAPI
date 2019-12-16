using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PerformanceIndicator.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Please Enter Your Name")]
        public string Name { get; set; }
       
        [Required(ErrorMessage = "Please Enter Your CNIC")]
        public string CNIC { get; set; }
        [Required(ErrorMessage = "Please Enter Your Designation")]
        public string Designation { get; set; }
        [Required(ErrorMessage = "Please Enter Your Salary")]
        public float salary { get; set; }

        [ForeignKey("Role")]
        public int Role_Id { get; set; }

        public virtual Role Role { get; set; }
    }
}
