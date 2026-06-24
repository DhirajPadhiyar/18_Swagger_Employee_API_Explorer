using System.ComponentModel.DataAnnotations;

namespace _18_Swagger_Employee_API_Explorer.Models
{
    public class Employee
    {
        public int Id { get; set; }


        [Required(ErrorMessage ="First Name is required.")]
        public string FirstName { get; set; }


        [Required(ErrorMessage = "Last Name is required.")]
        public string LastName { get; set; }


        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress(ErrorMessage ="Please enter valid email address.")]
        public string Email { get; set; }


        [Required(ErrorMessage = "Phone Number is required.")]
        [RegularExpression(@"^[0-9]{10}$",ErrorMessage ="Phone number must be " +
            "exactly 10 digits.")]
        public string PhoneNumber { get; set; }


        [Required(ErrorMessage = "Department is required.")]
        public string Department { get; set; }


        [Required(ErrorMessage = "Salary is required.")]
        [Range(10000,1000000,ErrorMessage = "Salary must be between ₹10,000 " +
            "and ₹10,00,000.")]
        public decimal Salary { get; set; }
    }
}
