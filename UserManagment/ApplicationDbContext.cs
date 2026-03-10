

using Microsoft.EntityFrameworkCore;
using UserManagment.Model;

namespace UserManagment
{

    // why we use entity framework?

    // it is like a bridge between apppliation and database
    //Select * from employee where id=1
    // var employee=_context.Users.Find(id)
    // it help to rather then wrting raw sql we can communicate with c# object

    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        //
        public DbSet<User> Users { get; set; }

        //orders
        //products
    }
}


//Add-migraiton
//update-database