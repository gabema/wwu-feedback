namespace gabema.wwufeedback.migrations;

using gabema.wwufeedback.migrations.Models;
using Microsoft.EntityFrameworkCore;

public class FeedbackContext : DbContext
{
    public DbSet<Topic> Topics { get; set; }
    public DbSet<Vote> Votes { get; set; }

    public FeedbackContext() : base()
    {
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Fluent API configuration
        var topicBuilder = modelBuilder.Entity<Topic>();
        topicBuilder.HasKey(t => t.Id);
        
        var voteBuilder = modelBuilder.Entity<Vote>();
        voteBuilder.HasKey(v => v.Id);

        voteBuilder
            .HasOne<Topic>()
            .WithMany()
            .HasForeignKey(v => v.TopicId); 
    }
}
