namespace GamingChallenges.Domain;

public class Challenge
{
    // PROPRIEDADES DE UM DESAFIO
    public Guid ChallengeId { get; set; }
    public string Title { get; set; }
    public string GoalDescription { get; set; }
    public int GoalCount { get; set; }

    // DATAS DO DESAFIO
    public DateTime CreatedDate { get; set; }
    public DateTime? Deadline { get; set; }

    // RESPONSAVEIS DO DESAFIO
    public Guid GrantorId { get; set; }
    public User Grantor { get; set; }
    
}