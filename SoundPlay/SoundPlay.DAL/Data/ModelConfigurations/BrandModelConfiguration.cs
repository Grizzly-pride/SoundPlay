﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SoundPlay.DTO.Models;

namespace SoundPlay.DAL.Data.ModelConfigurations
{
	internal class BrandModelConfiguration : IEntityTypeConfiguration<Brand>
	{
		public void Configure(EntityTypeBuilder<Brand> builder)
		{
			builder.ToTable("Brands")
				.HasKey(p => p.Id)
				.HasName("BrandId");

			builder.Property(p => p.Id)
				.HasColumnName("BrandId");

			builder.Property(p => p.Name)
				.HasColumnName("BrandName")
				.IsRequired();
		}
	}
}