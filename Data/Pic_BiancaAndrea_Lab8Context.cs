using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Pic_BiancaAndrea_Lab8.Models;

namespace Pic_BiancaAndrea_Lab8.Data
{
    public class Pic_BiancaAndrea_Lab8Context : DbContext
    {
        public Pic_BiancaAndrea_Lab8Context (DbContextOptions<Pic_BiancaAndrea_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Pic_BiancaAndrea_Lab8.Models.Book> Book { get; set; }

        public DbSet<Pic_BiancaAndrea_Lab8.Models.Publisher> Publisher { get; set; }

        public DbSet<Pic_BiancaAndrea_Lab8.Models.Category> Category { get; set; }
    }
}
