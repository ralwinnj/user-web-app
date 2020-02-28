using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace users_web_app.Models
{
    public class User
    {
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        
        [Required]
        [Display(Name = "Name")]
        [StringLength(50, ErrorMessage = "Name cannot be longer than 50 characters.")]
        public String Name { get; set; }

        [Required]
        [Display(Name = "Surname")]
        [StringLength(50, ErrorMessage = "Surname cannot be longer than 50 characters.")]
        public String Surname { get; set; }
        
        [Required]
        [Display(Name = "Date of Birth")]
        [DataType(DataType.Date, ErrorMessage = "Date must be in a DateTime Format")]
        public DateTime DateOfBirth { get; set; }

    }
}
