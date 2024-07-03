using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp2.Models
{
    public class Advertisement
    {
        public int AdID { get; set; }
        public int CustomerID { get; set; }
        public string Text { get; set; }
        public string Type { get; set; }
        public string PackageType { get; set; }
        public int AgentID { get; set; }
        public decimal PaymentAmount { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string EditedBy { get; set; }
        public DateTime? EditedOn { get; set; }

        public Customer Customer { get; set; }
        public Agent Agent { get; set; }
    }
}
