using GamingChallenges.Domain.Entities;

namespace GamingChallenges.Application.Interfaces;

public interface IAuthService
{
    
    User Register(string username, string email, string password);
    string Login(string email, string password);
}


