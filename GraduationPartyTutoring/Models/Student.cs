using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace GraduationPartyTutoring.Models
{
    public class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public DateTime DOB { get; set; }
        public string Email { get; set; }
        public string Image { get; set; }
        public List<Student> PaymentInfo { get; set; }
    }

    public class StudentDBContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
    }
}