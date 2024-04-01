using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using EMS.Entities;
using EMS.Models;

namespace EMS.ConnectionStrings
{
    public class DbConnect : IdentityDbContext<IdentityUser, IdentityRole, string,
     IdentityUserClaim<string>, IdentityUserRole<string>,
     IdentityUserLogin<string>, IdentityRoleClaim<string>, IdentityUserToken<string>>

    {
        public DbConnect(DbContextOptions<DbConnect> options): base(options)
        { }
        public DbSet<EmployeeInfo> Employees { get; set; }
        public DbSet<DepartmentInfo> SetupDepartment { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<IdentityUser>();

        }

    }
}
