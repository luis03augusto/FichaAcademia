using FichaAcademia.dominio.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace FichaAcademia.AcessoDados.Mapeamentos
{
    public class AlunoMap : IEntityTypeConfiguration<Aluno>
    {
        public void Configure(EntityTypeBuilder<Aluno> builder)
        {
            builder.HasKey(x => x.AlunoId);

            builder.Property(x => x.NomeCompleto)
                .HasMaxLength(250)
                .IsRequired();

            builder.Property(x => x.Idade)                
                .IsRequired();

            builder.Property(x => x.Peso)
                .IsRequired();

            builder.Property(x => x.FrequenciaSemanal)
                .IsRequired();

            builder.HasOne(x => x.Objetivo)
                .WithMany(x => x.Alunos)
                .HasForeignKey(x => x.ObjetivoId);

            builder.HasOne(x => x.Professor)
                .WithMany(x => x.Alunos)
                .HasForeignKey(x => x.ProfessorId);

            builder.HasMany(x => x.Fichas)
                .WithOne(x => x.Aluno)
                .OnDelete(DeleteBehavior.Cascade);

            builder.ToTable("Alunos");
        }
    }
}
