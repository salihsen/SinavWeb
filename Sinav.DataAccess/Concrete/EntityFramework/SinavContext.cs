using Microsoft.EntityFrameworkCore;
using Sinav.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sinav.DataAccess.Concrete.EntityFramework
{
    public class SinavContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Exam; trusted_connection=true");
        }
        public DbSet<User> tblUser { get; set; }
        public DbSet<Quizzes> tblQuizzes { get; set; }
        public DbSet<Documents> tblDocuments { get; set; }
        public DbSet<Questions> tblQuestions { get; set; }
        public DbSet<Stylish> tblStylish{ get; set; }
        public DbSet<UserExams> tblUserQuizzes{ get; set; }
    }
}
