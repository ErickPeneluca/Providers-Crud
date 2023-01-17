using DivTech.Models;
using Microsoft.EntityFrameworkCore;

namespace DivTech.Data
{
    public class FornecedorContext : DbContext
    {
        public FornecedorContext(DbContextOptions<FornecedorContext> options) : base(options) { }

        public DbSet<Fornecedor> fornecedores { get; set; }
    }
}
