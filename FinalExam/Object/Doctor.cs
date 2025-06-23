using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalExam.Object
{
    public class Doctor
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Gender { get; set; }

        public DateTime DateOfBirth  { get; set; }
        public string Phone {  get; set; }
        public int SpecialtyId {  get; set; }
        public virtual DocSpecialty DocSpecialtys { get; set; }

        public virtual ICollection<Patient> Patients { get; set; }

    }
}
