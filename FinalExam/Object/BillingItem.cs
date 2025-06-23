using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalExam.Object
{
    public class BillingItem
    {
        public int Id { get; set; }
        public int BillingId { get; set; }
        public virtual Billing Billings{ get; set; }
        public int MedicineId { get; set; }
        public virtual Medicine Medicines { get; set; }
        public int QuantityUsed { get; set; }
        public decimal UnitPrice { get;set; }
    }
}
