﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Requiem.PollingSystem.Entities;

namespace Requiem.PollingSystem.Application.ModelConfigurations;

public class PollModelConfiguration : IEntityTypeConfiguration<Poll>
{
    public void Configure(EntityTypeBuilder<Poll> builder)
    {
        builder.ToTable("Polls");
        builder.HasKey(x => x.Id);

        builder.Property(x => x.Id).IsRequired();
        builder.Property(x => x.QuestionText).IsRequired().HasMaxLength(512);

        builder.HasMany(x => x.Answers);
    }
}
