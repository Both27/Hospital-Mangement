using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalExam.Object
{
    public class DocSpecialty
    {
        public int Id { get; set; }
        public string SpecialtyName { get; set; }
        public virtual ICollection<Doctor> Doctors { get; set; }
    }
}
