using FichaAcademia.dominio.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace FichaAcademia.AcessoDados.Mapeamentos
{
    public class CategoriaExercicioMap : IEntityTypeConfiguration<CategoriaExercicio>
    {
        public void Configure(EntityTypeBuilder<CategoriaExercicio> builder)
        {
            builder.HasKey(x => x.CategoriaExercicioId);
            builder.Property(x => x.Nome)
                .HasMaxLength(50)
                .IsRequired();

            builder.HasMany(x => x.Exercicios)
                .WithOne(x => x.CategoriaExercicio)
                .OnDelete(DeleteBehavior.Cascade);

            builder.ToTable("CategoriasExercicios");
        }
    }
}
