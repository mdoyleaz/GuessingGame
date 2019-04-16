using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace GuessingGame.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new GuessingGameContext(serviceProvider.GetRequiredService<DbContextOptions<GuessingGameContext>>()))
            {
                // Look for any score.
                if (context.Score.Any())
                {
                    return; // DB has been seeded
                }
                context.Score.AddRange(
                    new Score
                    {
                        User = "Todd",
                        AnswerScore = 100
                    },
                    new Score
                    {
                        User = "Henry",
                        AnswerScore = 20
                    },
                    new Score
                    {
                        User = "Ello",
                        AnswerScore = 58
                    }
                );
                context.SaveChanges();
            }
        }
    }
}