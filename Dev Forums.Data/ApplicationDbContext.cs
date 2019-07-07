using Dev_Forums.Data.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Dev_Forums.Data
{
     public class ApplicationDbContext : IdentityDbContext<ApplicactionUser>
     {
          public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
              : base(options)
          {

          }


          public DbSet<ApplicactionUser> ApplicactionUsers { get; set; }
          public DbSet<Forum> Forums{ get; set; }
          public DbSet<Post> Posts{ get; set; }
          public DbSet<PostReply> Replies{ get; set; }
     }
}

