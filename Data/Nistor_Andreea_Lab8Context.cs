using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Nistor_Andreea_Lab8.Models;

namespace Nistor_Andreea_Lab8.Data
{
    public class Nistor_Andreea_Lab8Context : DbContext
    {
        public Nistor_Andreea_Lab8Context (DbContextOptions<Nistor_Andreea_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Nistor_Andreea_Lab8.Models.Book> Book { get; set; }

        public DbSet<Nistor_Andreea_Lab8.Models.Publisher> Publisher { get; set; }

        public DbSet<Nistor_Andreea_Lab8.Models.Category> Category { get; set; }
    }
}
