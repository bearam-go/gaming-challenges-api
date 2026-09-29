namespace GamingChallenges.Application.Dtos.Request;

public class LoginRequestDto
{
    public required string Email { get; set; }
    public required string UserPassword { get; set; }

}