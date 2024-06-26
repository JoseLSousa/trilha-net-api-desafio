using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using trilha_net_api_desafio.Entities;

namespace trilha_net_api_desafio.Context
{
    public class OrganizadorContext : DbContext
    {
        public OrganizadorContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Tarefa> Tarefas { get; set; }
    }
}