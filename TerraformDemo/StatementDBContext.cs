using Microsoft.EntityFrameworkCore;
using TerraformDemo.Models;

namespace TerraformDemo
{
    public class StatementDBContext : DbContext
    {
        public StatementDBContext(DbContextOptions<StatementDBContext> options) : base(options)
        {
            this.Database.Migrate();
        }

        public DbSet<Statement> Statements { get; set; }
    }
}
