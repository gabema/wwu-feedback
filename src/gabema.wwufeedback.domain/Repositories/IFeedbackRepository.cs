namespace gabema.wwufeedback.domain.Models.Repositories;

public interface ITopicRepository
{
    Task AddVote(Vote vote, CancellationToken token);
}
