using Microsoft.EntityFrameworkCore;
using MinhaAPI.Business.Models;

namespace MinhaAPI.Data.Context
{
    public class MinhaApiDbContext : DbContext
    {
        public MinhaApiDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Fornecedor> Fornecedor { get; set; }
    }
}
