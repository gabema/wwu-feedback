namespace gabema.wwufeedback.domain.Models;

public class Vote
{
    public int Id { get; set;}
    public int TopicId { get; set;}
    public short Rating { get; set;}

    // Always set using GMT
    public DateTime LastUpdated { get; set;}

    public string Feedback { get; set; } = string.Empty;
}
