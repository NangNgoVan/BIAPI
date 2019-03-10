using Microsoft.EntityFrameworkCore;

namespace BIApi.DBContext {
    public class DB : DbContext
    {
        public DbSet<Patient> Patients {get;set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        { 
            optionsBuilder.UseSqlServer(@"Server=NANG-PC\SQLEXPRESS;Database=VIETBA_DWH;User Id=nang;Password=123456;Trusted_Connection=True;");
        }
    }
}