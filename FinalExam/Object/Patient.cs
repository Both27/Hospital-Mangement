using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalExam.Object
{
    public class Patient
    {
        public int Id { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Gender {  get; set; }

        public DateTime DateOfBirth { get; set; }

        public string phone {  get; set; }

        public int RoomId { get; set; }
        public virtual Room Rooms { get; set; }

        public int DoctorId { get; set; }
        public virtual  Doctor Doctors { get; set; }

        public virtual ICollection<Billing> Billings { get; set; }
    }
}
