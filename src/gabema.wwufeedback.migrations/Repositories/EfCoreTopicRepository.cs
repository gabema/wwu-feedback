namespace gabema.wwufeedback.migrations.Repositories;

using gabema.wwufeedback.domain.Models;
using gabema.wwufeedback.domain.Models.Repositories;

internal class EfCoreTopicRepository : ITopicRepository
{
    private FeedbackContext FeedbackContext { get; }

    public EfCoreTopicRepository(FeedbackContext feedbackContext)
    {
        FeedbackContext = feedbackContext;
    }

    public async Task AddVote(Vote vote, CancellationToken token)
    {
        FeedbackContext.Votes.Add(vote);
        await FeedbackContext.SaveChangesAsync(token);
    }
}
