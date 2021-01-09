using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Zakarias_Ovidiu_Lab8.Models;

namespace Zakarias_Ovidiu_Lab8.Data
{
    public class Zakarias_Ovidiu_Lab8Context : DbContext
    {
        public Zakarias_Ovidiu_Lab8Context (DbContextOptions<Zakarias_Ovidiu_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Zakarias_Ovidiu_Lab8.Models.Book> Book { get; set; }
    }
}
