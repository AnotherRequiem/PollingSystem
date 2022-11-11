using Requiem.PollingSystem.Application;

var builder = new PollBuilder("Am i eat eggs in the morning?")
    .AddAnswer(Guid.Parse("D733F1F7-81DB-41F8-A14D-45E325813322"), "Yes")
    .AddAnswer(Guid.Parse("16A1F025-6261-4C75-84A5-04488CC28563"), "Sometimes")
    .AddAnswer(Guid.Parse("2CED8733-9EE7-4661-A4B9-0F1A2FF300F3"), "Seldom")
    .AddAnswer(Guid.Parse("4E73A588-BEE0-4FD4-AE81-5E94825C482F"), "No");

var poll = builder.Build();

poll.VoteTo(Guid.Parse("D733F1F7-81DB-41F8-A14D-45E325813322"), 3);
poll.VoteTo(Guid.Parse("16A1F025-6261-4C75-84A5-04488CC28563"));
poll.VoteTo(Guid.Parse("2CED8733-9EE7-4661-A4B9-0F1A2FF300F3"));
poll.VoteTo(Guid.Parse("4E73A588-BEE0-4FD4-AE81-5E94825C482F"), 4);
poll.VoteTo(Guid.Parse("16A1F025-6261-4C75-84A5-04488CC28563"));
poll.VoteTo(Guid.Parse("16A1F025-6261-4C75-84A5-04488CC28563"));
poll.VoteTo(Guid.Parse("D733F1F7-81DB-41F8-A14D-45E325813322"));
poll.VoteTo(Guid.Parse("D733F1F7-81DB-41F8-A14D-45E325813322"));

using (var context = new ApplicationDbContext())
{
    context.Polls.Add(poll);
    context.SaveChanges();
}



var result = builder.GetResults(poll);

Console.WriteLine(result.GetView());
