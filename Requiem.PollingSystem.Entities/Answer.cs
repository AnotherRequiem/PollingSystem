using Requiem.PollingSystem.Entities.Base;

namespace Requiem.PollingSystem.Entities;

public class Answer: Identity
{
    public Answer(Guid id, string title)
    {
        Id = id;
        Title = title;
    }
    public string Title { get; init; }
    public int Votes { get; set; }
    public double Percents { get; private set; }
    public override string ToString()
    {
        return $" * {Title} - {Votes} ({Percents:F}%)";
    }

    internal void SetPercents(int totalVotes)
    {
        if(totalVotes > 0)
        {
            Percents = Votes * 100d / totalVotes;
        }
    }
}