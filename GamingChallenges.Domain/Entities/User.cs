namespace GamingChallenges.Domain;
public class User
{
    // PROPRIEDADES DO USUÁRIO
    public Guid UserId { get; set; }
    public string Username { get; set; }
    public string Email { get; set; }
    public string PasswordHash { get; set;}
    
    // DATAS DO USUÁRIO
    public DateTime CreatedAt { get; set; }
    public DateTime? LastLoginDate { get; set; }
}