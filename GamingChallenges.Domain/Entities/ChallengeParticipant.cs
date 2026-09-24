namespace GamingChallenges.Domain;

public class ChallengeParticipant
{
    // PROPRIEDADES DE UM PARTICIPANTE DO DESAFIO
    public Guid UserId { get; set;}
    public Guid ChallengeId {  get; set; }
    public User User { get; set; }
    public Challenge Challenge { get; set; }

    //  PROGRESSO INDIVIDUAL DO PARTICIPANTE: ÚNICA TAREFA
    public int ParticipantProgress { get; set; }
    public bool IsChallengeCompleted { get; set; }

    // DATAS
    public DateTime UserEnrollDate { get; set; }
}