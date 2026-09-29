namespace GamingChallenges.Application.Dtos.Response;

public class AuthResponseDto
{
    public Guid UserId { get; set; }
    public required string Username { get; set; }
    public required string Email { get; set;}
    public required string Token { get; set; }
}