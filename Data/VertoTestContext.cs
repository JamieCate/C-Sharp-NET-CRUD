using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using VertoTest.Models;
using VertoTest.Models.Entities;

namespace VertoTest.Data
{
    public class VertoTestContext : DbContext
    {
        public VertoTestContext (DbContextOptions<VertoTestContext> options)
            : base(options)
        {
        }

        public DbSet<TopHomeImage> TopHomeImages { get; set; }

    }
}
