﻿namespace SoundPlay.Infrastructure.DataAccess.ModelConfigurations;

internal sealed class BasketItemConfiguration : IEntityTypeConfiguration<BasketItem>
{
    public void Configure(EntityTypeBuilder<BasketItem> builder)
    {
        builder.Property(p => p.CreateDate)
            .HasColumnType("datetime2(7)");
    }
}
