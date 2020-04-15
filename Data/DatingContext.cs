using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Dating.Models;

namespace Dating.Data
{
    public class DatingContext : DbContext
    {
        public DatingContext (DbContextOptions<DatingContext> options)
            : base(options)
        {
        }

        public DbSet<Dating.Models.Value> Value { get; set; }

        public DbSet<User> User { get; set; }
    }
}
