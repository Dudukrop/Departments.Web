using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Projeto___SistemaWebMvc.Models;

namespace Projeto___SistemaWebMvc.Data
{
    public class Projeto___SistemaWebMvcContext : DbContext
    {
        public Projeto___SistemaWebMvcContext (DbContextOptions<Projeto___SistemaWebMvcContext> options)
            : base(options)
        {
        }

        public DbSet<Department> Department { get; set; } = default!;
    }
}
