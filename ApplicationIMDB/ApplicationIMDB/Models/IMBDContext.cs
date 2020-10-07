using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ApplicationIMDB.Models
{
    public class IMBDContext : DbContext
    {
        public IMBDContext(DbContextOptions<IMBDContext> options)
            : base(options)
        {
        }

        public DbSet<Movie> Movie { get; set; }
    }
}
