using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace GraduationPartyTutoring.Models
{
    public class Payment
    {
        public int TransactionNumber { get; set; }
        public string TutorID { get; set; }
        public string StudentID { get; set; }
        public string TypeOfPurchase { get; set; }
        public int PurchaseAmount { get; set; }
        public DateTime TimeOfPurchase { get; set; }
    }

    public class PaymentDBContext : DbContext
    {
        public DbSet<Payment> Payments { get; set; }
    }
}