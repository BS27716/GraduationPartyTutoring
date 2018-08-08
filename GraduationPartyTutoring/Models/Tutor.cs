using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace GraduationPartyTutoring.Models
{
    public class Tutor
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public DateTime DOB { get; set; }
        public List<Tutor> Subject { get; set; }
        public List<Tutor> Certifications { get; set; }
        public List<Tutor> Education { get; set; }
        public decimal Payrate { get; set; }
        public string Image { get; set; }
        public string Resume { get; set; }
        public int ResponseTime { get; set; }
    }

    public class TutorDBContext : DbContext
    {
        public DbSet<Tutor> Tutors { get; set; }
    }
}