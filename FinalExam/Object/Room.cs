using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalExam.Object
{
    public class Room
    {
        public int Id { get; set; }

        public string Name { get; set; }
        
        public int Bed { get; set; }

        public int RoomTypeId { get; set; }

        public virtual RoomType RoomType { get; set; }

        public virtual ICollection<Patient> Patients { get; set; }

    }
}
