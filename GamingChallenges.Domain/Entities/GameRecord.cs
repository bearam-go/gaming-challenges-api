namespace GamingChallenges.Domain.Entities;
public class GameRecord
{
    // PROPRIEDADES DE UM GAME
    public Guid GameId { get; set; }

    public required string Title { get; set; }
    public required string Plataform { get; set; }
    public required string Genre { get; set; }

    public required string Developer { get; set; }  // Caso o desafio seja "jogue 3 jogos da Naughty Dog ou Jogue 1 jogo Hideo Kojima"
    public required string GameMode { get; set; }  // Multiplayer ou Singleplayer
    public decimal GameNote { get; set; } // Avaliação, como 5.5, 9.6
    public DateTime ReleasedDate { get; set; } // caso o desafio seja "jogue 5 jogos de 2010"
    public DateTime CompletedAt { get; set; }


    // RESPONSAVEIS
    public Guid RegisteredByUserId { get; set; }
    public Guid ChallengeId { get; set; }

    public User RegisteredBy { get; set; } = null!;
    public Challenge Challenge { get; set; } = null!;
}