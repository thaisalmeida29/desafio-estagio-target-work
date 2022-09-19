using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using desafio.Models;

namespace desafio.Data
{
    public class desafioContext : DbContext
    {
        public desafioContext (DbContextOptions<desafioContext> options)
            : base(options)
        {
        }

        public DbSet<desafio.Models.Cliente> Cliente { get; set; } = default!;

        public DbSet<desafio.Models.Produto> Produto { get; set; }
    }
}
