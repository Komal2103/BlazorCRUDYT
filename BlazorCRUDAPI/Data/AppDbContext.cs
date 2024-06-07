using BlazorCRUD.Library;
using Microsoft.EntityFrameworkCore;

namespace BlazorCRUDAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {

        }
        public DbSet<Student> tbl_Student { get; set; }
    }
}
