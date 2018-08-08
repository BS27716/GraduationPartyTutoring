using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace GraduationPartyTutoring.Models
{
    public class CertificationExam
    {
        public int ID { get; set; }
        public string Subject { get; set; }
        public string Author { get; set; }
        public DateTime LastUpdate { get; set; }
    }

    public class CertificationExamDBContext : DbContext
    {
        public DbSet<CertificationExam> CertificationExams { get; set; }
    }
}