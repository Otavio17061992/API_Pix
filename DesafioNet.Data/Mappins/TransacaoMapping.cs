using DesafioNet.Business.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioNet.Data.Mappins
{
    public class TransacaoMapping : IEntityTypeConfiguration<Transacao>
    {
        public void Configure(EntityTypeBuilder<Transacao> builder)
        {
            // Configura Id
            builder.HasKey(x => x.Id);

            // Configura nome da coluna 
            builder.Property(t => t.DataTransacao)
                .IsRequired()
                .HasColumnType("date");

            // configuracao um pra muitos
            builder.HasOne(p => p.Recebedor)
                .WithMany(p => p.Transacoes)
                .IsRequired(); // Torna como requerida

            builder.HasOne(p => p.Pagador)
                .WithMany(p => p.Transacoes)
                .IsRequired();

            // nome da tabela
            builder.ToTable("Transacoes");
        }
    }
}
