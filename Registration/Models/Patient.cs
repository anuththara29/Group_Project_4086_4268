using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registration.Models
{
    public class Patient
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int Age { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string Registered_Date { get; set; }
        [Required]
        public int ContactNo { get; set; }
        [Required]
        public string Disease { get; set; }
        
        
    }
}
