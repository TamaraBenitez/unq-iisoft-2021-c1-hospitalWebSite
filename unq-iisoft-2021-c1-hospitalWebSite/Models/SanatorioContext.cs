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

    }
}