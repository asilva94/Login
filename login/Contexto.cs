using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using login.Entidades;

namespace login
{
    public class Contexto : DbContext
    {

        public Contexto(DbContextOptions<Contexto> opt) :
            base(opt)
        { }

        public DbSet<User> Users  { get; set; }

    }

}
