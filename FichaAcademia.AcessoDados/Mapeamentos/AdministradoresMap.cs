using FichaAcademia.dominio.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace FichaAcademia.AcessoDados.Mapeamentos
{
    public class AdministradoresMap : IEntityTypeConfiguration<Administrador>
    {
        public void Configure(EntityTypeBuilder<Administrador> builder)
        {
            builder.HasKey(x => x.AdministradoresId);

            builder.Property(x => x.Nome)
                .IsRequired();


            builder.Property(x => x.Email)
                .IsRequired();


            builder.Property(x => x.Senha)
                .IsRequired();

            builder.ToTable("Administrador");
        }
    }
}
