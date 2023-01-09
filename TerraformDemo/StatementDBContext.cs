using Microsoft.EntityFrameworkCore;
using TerraformDemo.Models;

namespace TerraformDemo
{
    public class StatementDBContext : DbContext
    {
        public DbSet<Statement> Statements;
    }
}
