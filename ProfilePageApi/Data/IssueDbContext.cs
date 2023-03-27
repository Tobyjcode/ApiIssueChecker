using Microsoft.EntityFrameworkCore;
using ProfilePageApi.Models;

namespace ProfilePageApi.Data
{
    public class IssueDbContext : DbContext
    {
        public IssueDbContext(DbContextOptions<IssueDbContext> options)
            :base(options) 
        {
        }
        // Dbset Repressents the data of a table on the database for our cs it can allow one to maniplaute data from the table issue
        public DbSet<Issue> Issues { get; set; }
    }
}
