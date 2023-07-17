using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registration.Models
{
    public class Doctor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ContactNo { get; set; }
        
        

        public List<Patient> Patients { get; set; }

    }
}
