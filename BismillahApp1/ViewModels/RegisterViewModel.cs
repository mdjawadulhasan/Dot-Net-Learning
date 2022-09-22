using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace BismillahApp1.ViewModels
{
    public class RegisterViewModel
    {
       
        public string Username { get; set; }

        
        public string Password { get; set; }

       
        public string ConfirmPassword { get; set; }

  
        public string Email { get; set; }

        public string Mobile { get; set; }

        public DateTime? DateOfBirth { get; set; }

        public string Address { get; set; }

        public string City { get; set; }

        public string Country { get; set; }
    }
}