namespace GamingChallenges.Domain.Entities;
public class User
{
    // PROPRIEDADES DO USUÁRIO
    public Guid UserId { get; set; }
    public required string Username { get; set; }
    public required string Email { get; set; }
    public required string PasswordHash { get; set;}
    
    // DATAS DO USUÁRIO
    public DateTime CreatedAt { get; set; }
    public DateTime? LastLoginDate { get; set; }
}