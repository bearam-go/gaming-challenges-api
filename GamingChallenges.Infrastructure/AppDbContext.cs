using Microsoft.EntityFrameworkCore;
using GamingChallenges.Domain.Entities;
namespace GamingChallenges.Infrastructure;

public class AppDbContext : DbContext
{
    // CLASSE FILHO : CLASSE PAI
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<User> Users { get; set; }
    public DbSet<Challenge> Challenges { get; set; }
    public DbSet<ChallengeParticipant> Participants { get; set; }
    public DbSet<GameRecord> Games { get; set; }
}
