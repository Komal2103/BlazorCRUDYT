using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorCRUD.Library
{
    public class Student
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Please Enter Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please Enter Father Name")]
        public string FatherName { get; set; }

        [Required(ErrorMessage = "Please Enter Your Mobile Number")]
        public int MobileNumber { get; set; }

        [Required(ErrorMessage = "Please Enter Semester")]
        [Range(1,8, ErrorMessage ="Please Enter Valid semester")]
        public string Semester { get; set; }

        [Required(ErrorMessage = "Please Enter Your Email")]
        [EmailAddress(ErrorMessage = "Please Enter Valid Email Address")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please Enter Your RollNo")]
        public int RollNumber { get; set; }



    }
}
