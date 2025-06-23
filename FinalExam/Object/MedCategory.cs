using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalExam.Object
{
    public class MedCategory
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Medicine> Medicines { get; set; }
    }
}
