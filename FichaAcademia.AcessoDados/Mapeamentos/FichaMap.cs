using FichaAcademia.dominio.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace FichaAcademia.AcessoDados.Mapeamentos
{
    public class FichaMap : IEntityTypeConfiguration<Ficha>
    {
        public void Configure(EntityTypeBuilder<Ficha> builder)
        {
            builder.HasKey(x => x.FichaId);

            builder.Property(x => x.Nome)
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(x => x.Cadastro)                
                .IsRequired();

            builder.Property(x => x.Validade)                
                .IsRequired();

            builder.HasOne(x => x.Aluno)
                .WithMany(x => x.Fichas)
                .HasForeignKey(x => x.AlunoId);

            builder.HasMany(x => x.ListaExercicios)
                .WithOne(x => x.Ficha)
                .OnDelete(DeleteBehavior.Cascade);

            builder.ToTable("Fichas");
        }
    }
}
