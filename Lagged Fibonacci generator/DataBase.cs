using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lagged_Fibonacci_generator
{
    internal class DataBase : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DataBase() : base("DefaultConnection") { }
    }
}
