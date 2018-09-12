using Microsoft.EntityFrameworkCore;

namespace ControlPanel.Models
{
    public class ControlPanelContext : DbContext
    {
        public ControlPanelContext (DbContextOptions<ControlPanelContext> options)
            : base(options)
        {
        }

        public DbSet<ControlPanel.Models.Juego> Juego { get; set; }
    }
}
