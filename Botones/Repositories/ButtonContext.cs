using Botones.Models;
using Microsoft.EntityFrameworkCore;

namespace Botones.Repositories
{
    public class ButtonContext : DbContext
    {
        public DbSet<Boton> Botones { get; set; }
        public ButtonContext(DbContextOptions<ButtonContext> options)
            : base(options)
        {
        }        
    }
}
