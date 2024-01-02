using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class PostContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public DbSet<UserDetails> UsersDetails { get; set; }

        public DbSet<UserAcademicInfo> AcademicInfo { get; set;}

        public DbSet<JobApply> JobApply { get; set; }

        /*public DbSet<Token> Token { get; set; }*/
    }
}
