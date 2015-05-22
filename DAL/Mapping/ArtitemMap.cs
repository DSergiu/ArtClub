using System;
namespace DAL
{
    using System.Data.Entity.ModelConfiguration;
    using Domain;
    using System.Data.Entity.Infrastructure.Annotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class ArtitemMap : EntityTypeConfiguration<Artitem>
    {
        public ArtitemMap()
        {

            // Primary Key
            HasKey(t => t.Id);

            Property(t => t.MinimumBid).IsRequired();
            Property(t => t.IdKey).HasColumnAnnotation(IndexAnnotation.AnnotationName, new IndexAnnotation(new IndexAttribute(){IsUnique = true}));

            // Table & Column Mappings
            ToTable("Artitem");
            Property(t => t.Id).HasColumnName("Id");
            Property(t => t.Name).HasColumnName("Name").HasMaxLength(40);
            Property(t => t.Description).HasColumnName("Description").HasMaxLength(512);
            Property(t => t.Artist).HasColumnName("Artist").HasMaxLength(40);
            Property(t => t.MinimumBid).HasColumnName("MinimumBid");
            Property(t => t.PurchasePrice).HasColumnName("PurchasePrice");
            Property(t => t.CreateAt).HasColumnName("CreateAt");
            Property(t => t.Img).HasColumnName("Img");
        }
    }
}
