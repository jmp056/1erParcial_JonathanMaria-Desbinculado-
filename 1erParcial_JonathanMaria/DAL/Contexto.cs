using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _1erParcial_JonathanMaria.DAL
{
    public class Contexto : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server = JMP-PC\SQLEXPRESS; Database = 1erParcial_JonathanMaria; Trusted_Connection = true");
        }
    }
}
