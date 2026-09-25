namespace GamingChallenges.Domain.Entities;

public class ChallengeParticipant
{
    // PROPRIEDADES DE UM PARTICIPANTE DO DESAFIO
    public Guid UserId { get; set;}
    public Guid ChallengeId {  get; set; }
    public User User { get; set; } = null!;
    public Challenge Challenge { get; set; } = null!;

    //  PROGRESSO INDIVIDUAL DO PARTICIPANTE: ÚNICA TAREFA
    public int ParticipantProgress { get; set; }
    public bool IsChallengeCompleted { get; set; }

    // DATAS
    public DateTime UserEnrollDate { get; set; }
}