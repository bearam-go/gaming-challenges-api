using Microsoft.EntityFrameworkCore;
using GamingChallenges.Domain.Entities;

namespace GamingChallenges.Infrastructure.Persistence;
public class AppDbContext : DbContext
{
    // CLASSE FILHO : CLASSE PAI
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<User> Users { get; set; }
    public DbSet<Challenge> Challenges { get; set; }
    public DbSet<ChallengeParticipant> Participants { get; set; }
    public DbSet<GameRecord> Games { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ChallengeParticipant>()
            .HasKey(key => new { key.UserId, key.ChallengeId });  // objeto anonimo para os dois campos para dizer que a chave primaria é a combinação dos dois
        modelBuilder.Entity<GameRecord>()
            .HasKey(key => key.GameId ) ;
    }
}
