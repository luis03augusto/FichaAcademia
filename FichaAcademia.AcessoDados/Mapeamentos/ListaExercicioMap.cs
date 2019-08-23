using FichaAcademia.dominio.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace FichaAcademia.AcessoDados.Mapeamentos
{
    public class ListaExercicioMap : IEntityTypeConfiguration<ListaExercicios>
    {
        public void Configure(EntityTypeBuilder<ListaExercicios> builder)
        {
            builder.HasKey(x => x.ListaExercicioId);

            builder.Property(x => x.Frequincia)
                .IsRequired();

            builder.Property(x => x.Repeticoes)
                .IsRequired();

            builder.Property(x => x.Carga)
                .IsRequired();

            builder.HasOne(x => x.Exercicio)
                .WithMany(x => x.ListaExercicios)
                .HasForeignKey(x => x.ExercicioId);

            builder.HasOne(x => x.Ficha)
              .WithMany(x => x.ListaExercicios)
              .HasForeignKey(x => x.FichaId);
        }
    }
}
