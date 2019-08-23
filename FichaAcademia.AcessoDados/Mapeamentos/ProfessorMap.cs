using FichaAcademia.dominio.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace FichaAcademia.AcessoDados.Mapeamentos
{
    public class ProfessorMap : IEntityTypeConfiguration<Professor>
    {
        public void Configure(EntityTypeBuilder<Professor> builder)
        {
            builder.HasKey(x => x.ProfessorId);

            builder.Property(x => x.Turno)
            .HasMaxLength(50)
            .IsRequired();

            builder.Property(x => x.Turno)
            .HasMaxLength(15)
            .IsRequired();

            builder.Property(x => x.Foto)
            .IsRequired();

            builder.Property(x => x.Telefone)            
            .IsRequired();

            builder.HasMany(x => x.Alunos)
                .WithOne(x => x.Professor);

            builder.ToTable("Professores");
        }
    }
}
