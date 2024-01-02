using Microsoft.EntityFrameworkCore;
using testProject.Models;

namespace testProject.Context
{
    public class ApplicationDbContext : DbContext{ 

        public ApplicationDbContext( DbContextOptions<ApplicationDbContext> contextOptions) : base(contextOptions)
        {

        } 
        public DbSet<UserLogin> Users { get; set; }
    }
}
