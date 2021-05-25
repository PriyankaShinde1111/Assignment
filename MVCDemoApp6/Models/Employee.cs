using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MVCDemoApp6.Models
{
    public class Employee
    {
        [Required(ErrorMessage = "EmpId is compulsory field")]
        [RegularExpression(@"[0-9]{4}",ErrorMessage ="Enter four digit EMployee Id")]
        public int? EmpId { get; set; }

        [Required(ErrorMessage = "EmpName is compulsory field")]
        [StringLength(10, ErrorMessage = "Maximum EmpName length is 10 characters")]
        public string EmpName { get; set; }

        [Required(ErrorMessage = "Salary is compulsory field")]
        public double? Salary { get; set; }
    }
}
