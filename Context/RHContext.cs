using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TrilhaNetAzureDesafio.Models;

namespace TrilhaNetAzureDesafio.Context
{
    public class RHContext : DbContext
    {
        public RHContext(DbContextOptions<RHContext> options) : base(options)
        {

        }

        public DbSet<Funcionario> Funcionarios { get; set; }
    }
}
