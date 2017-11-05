using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PhoneBook.Models
{
    public class PersonModel
    {
        public int ID { get; set; }
        [Required(ErrorMessage = "Please Insert Your First Name")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Please Insert Your Last Name")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Please Insert Your Phone Number")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "Please Insert Your Email")]
        public string Email { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdateDate { get; set; }
    }
}
