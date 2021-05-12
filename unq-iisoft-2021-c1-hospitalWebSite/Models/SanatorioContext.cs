using Microsoft.EntityFrameworkCore;

namespace Models.Hospital { 


 public class SanatorioContext: DbContext {
     public SanatorioContext(DbContextOptions<SanatorioContext> options)
            :base(options){

        }

        protected SanatorioContext()
        {
        }


        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<ObraSocial> ObraSocial { get; set; }
        public DbSet<Plan> Plan { get; set; }
        public DbSet<Nota> Nota { get; set; }

    }
}