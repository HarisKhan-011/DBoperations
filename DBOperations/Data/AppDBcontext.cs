using Microsoft.EntityFrameworkCore;
namespace DBOperations.Data
{
    public class AppDBcontext :DbContext
    {
        public AppDBcontext(DbContextOptions<AppDBcontext> options) : base(options)
        {

        }
    }
}
