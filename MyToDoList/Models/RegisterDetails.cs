using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;


namespace MyToDoList.Models
{
    public class RegisterDetails
    {
        [Required]
        public string Name { get; set; }

        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Address { get; set; }

        [Required]
        [Display(Name = "Date of Birth")]
        public DateTime? DoB { get; set; }      
        
        [Required]
        [CreditCard]
        public string CardNumber { get; set; }
    }
}
