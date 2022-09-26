using Finbuckle.MultiTenant.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FSH.WebApi.Infrastructure.Persistence.Configuration;

//public class BrandConfig : IEntityTypeConfiguration<Brand>
//{
//    public void Configure(EntityTypeBuilder<Brand> builder)
//    {
//        builder.IsMultiTenant();

//        builder
//            .Property(b => b.Name)
//                .HasMaxLength(256);
//    }
//}
