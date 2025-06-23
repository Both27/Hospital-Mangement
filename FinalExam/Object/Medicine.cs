using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalExam.Object
{
    public class Medicine
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public DateTime ExpiryDate { get; set; }
        public decimal Price { get; set; }
        public int MedCategoryId { get; set; }
        public virtual MedCategory MedCategorys { get; set; }

        public virtual ICollection<BillingItem> BillingItems { get; set; }
    }
}
