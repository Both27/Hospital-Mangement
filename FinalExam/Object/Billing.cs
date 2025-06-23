using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalExam.Object
{
    public class Billing
    {
        public int Id { get; set; }
        public DateTime DateTime { get; set; }

        public decimal MedicineCharge { get; set; }

        public virtual ICollection<BillingItem> BillingItems { get; set; }

        public int PatientId { get; set; }
        public virtual Patient Patients { get; set; }

        public int UserId { get; set; }
        public virtual User User { get; set; }
    }
}
