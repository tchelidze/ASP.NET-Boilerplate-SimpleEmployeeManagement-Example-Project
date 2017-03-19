using System;
using System.ComponentModel.DataAnnotations;

namespace SimpleEmployeeManagement.Employees.Dtos
{
    public class CreateEmployeeInput
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string Surname { get; set; }

        [Required]
        public string IdentityNumber { get; set; }

        public string PhoneNumber { get; set; }

        [Required]
        public DateTime BirthDate { get; set; }

        public string Nationality { get; set; }

        public double SalaryAmount { get; set; }

        public string SalaryCurrency { get; set; }
    }
}
