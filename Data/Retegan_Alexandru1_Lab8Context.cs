using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Retegan_Alexandru1_Lab8.Models;

namespace Retegan_Alexandru1_Lab8.Data
{
    public class Retegan_Alexandru1_Lab8Context : DbContext
    {
        public Retegan_Alexandru1_Lab8Context (DbContextOptions<Retegan_Alexandru1_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Retegan_Alexandru1_Lab8.Models.Book> Book { get; set; }

        public DbSet<Retegan_Alexandru1_Lab8.Models.Publisher> Publisher { get; set; }

        public DbSet<Retegan_Alexandru1_Lab8.Models.Category> Category { get; set; }
    }
}
