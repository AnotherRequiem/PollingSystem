using Microsoft.EntityFrameworkCore;
using Requiem.PollingSystem.Entities;

namespace Requiem.PollingSystem.Application;

#nullable disable

public class ApplicationDbContext : DbContext
{
    public DbSet<Poll> Polls { get; set; }
    public DbSet<Answer> Answers { get; set; }


}

#nullable enable


