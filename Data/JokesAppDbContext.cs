using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using JokesApp.Models;

namespace JokesApp.Data
{
    public class JokesAppDbContext : DbContext
    {
        public JokesAppDbContext (DbContextOptions<JokesAppDbContext> options)
            : base(options)
        {
        }

        public DbSet<JokesApp.Models.Joke> Joke { get; set; }
    }
}
