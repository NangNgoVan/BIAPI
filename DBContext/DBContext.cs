using Microsoft.EntityFrameworkCore;

namespace BIApi.DBContext {
    public class DB : DbContext
    {
        public DbSet<Patient> Patients {get;set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        { 
            optionsBuilder
                .UseSqlServer(@"Data Source=MY-AK7EGE7HDPMU\SQLEXPRESS;Database=BI_VIETBA_DW;Integrated Security=False;User Id=nang;Password=123456; MultipleActiveResultSets=True");
        }
    }
}