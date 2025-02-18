using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOMAIN.Entity.Product
{
    public class ProductConfig : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable(nameof(Product));

            // Define a chave primária
            builder.HasKey(m => m.Id);

            // Configuração das propriedades
            builder.Property(x => x.Name)
                .IsRequired(); // Torna obrigatório
                

           
        }
    }
}
