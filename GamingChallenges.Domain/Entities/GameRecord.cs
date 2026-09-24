namespace GamingChallenges.Domain;

public class GameRecord
{
    // PROPRIEDADES DE UM GAME
    public Guid GameId { get; set; }

    public string Title { get; set; }
    public string Plataform { get; set; }
    public string Genre { get; set; }

    public string Developer { get; set; } // Caso o desafio seja "jogue 3 jogos da Naughty Dog ou Jogue 1 jogo Hideo Kojima"
    public string GameMode { get; set; } // Multiplayer ou Singleplayer
    public decimal GameNote { get; set; } // Avaliação, como 5.5, 9.6
    public DateTime ReleasedDate { get; set; } // caso o desafio seja "jogue 5 jogos de 2010"
    public DateTime CompletedAt { get; set; }


    // RESPONSAVEIS
    public Guid RegisteredByUserId { get; set; }
    public Guid ChallengeId { get; set; }

    public User RegisteredBy { get; set; }
    public Challenge Challenge { get; set; }
}