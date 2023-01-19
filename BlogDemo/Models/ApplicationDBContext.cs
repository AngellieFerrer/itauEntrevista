using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogDemo.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<ApplicationBlog> ApplicationBlogs { get; set; }
        public DbSet<ApplicationPublish> ApplicationPublicar { get; set; }
        public DbSet<ApplicationUserRegisterModel> ApplicationRegistro { get; set; }

        public DbSet<ApplicationRole> ApplicationRole { get; set; }
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }
    }
}
