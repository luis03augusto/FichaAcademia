using FichaAcademia.dominio.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace FichaAcademia.AcessoDados.Mapeamentos
{
    public class ExercicioMap : IEntityTypeConfiguration<Exercicio>
    {
        public void Configure(EntityTypeBuilder<Exercicio> builder)
        {
            builder.HasKey(x => x.ExercicioId);

            builder.Property(x => x.Nome)
                .HasMaxLength(50)
                .IsRequired();

            builder.HasOne(x => x.CategoriaExercicio)
                .WithMany(x => x.Exercicios)
                .HasForeignKey(x => x.CateforiaExercicoId);

            builder.ToTable("Exercicios");
                
        }
    }
}
