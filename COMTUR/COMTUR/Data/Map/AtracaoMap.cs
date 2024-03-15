﻿using COMTUR.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace COMTUR.Data.Map
{
	public class AtracaoMap : IEntityTypeConfiguration<AtracaoModel>
	{
		public void Configure(EntityTypeBuilder<AtracaoModel> builder)
		{
			builder.HasKey(x => x.Id);
			builder.Property(x => x.Nome).IsRequired();

			// Relacionamento da Atracao com TipoAtracao
			builder.HasOne(x => x.TipoAtracaoModel).WithMany().HasForeignKey(x => x.IdTipoAtracao);

			// Relacionamento Atracao com ImagemAtracao
			builder.HasMany(n => n.ImagemAtracao)
				   .WithOne(im => im.AtracaoModel)
				   .HasForeignKey(im => im.IdAtracao)
				   .IsRequired()
				   .OnDelete(DeleteBehavior.Cascade);
		}
	}
}