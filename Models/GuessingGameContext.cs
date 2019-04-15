using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace GuessingGame.Models
{
    public class GuessingGameContext : DbContext
    {
        public GuessingGameContext(DbContextOptions<GuessingGameContext> options) : base(options)
        {
        }

        public DbSet<GuessingGame.Models.Score> Score { get; set; }
    }
}