using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MJPruebaProgreso1.Models;

namespace MJPruebaProgreso1.Data
{
    public class MJPruebaProgreso1Context : DbContext
    {
        public MJPruebaProgreso1Context (DbContextOptions<MJPruebaProgreso1Context> options)
            : base(options)
        {
        }

        public DbSet<MJPruebaProgreso1.Models.MJ_Tacos> MJ_Tacos { get; set; } = default!;
    }
}
