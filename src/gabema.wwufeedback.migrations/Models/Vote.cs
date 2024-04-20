namespace gabema.wwufeedback.migrations.Models;

public class Vote
{
    public int Id { get; set;}
    public int TopicId { get; set;}
    public short Rating { get; set;}
}
