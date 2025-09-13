using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Onoqua.Entities.Models.Mapping
{
    public class AddressMap : EntityTypeConfiguration<Address>
    {
        public AddressMap()
        {
            // Primary Key
            this.HasKey(t => t.AddressID);

            // Properties
            this.Property(t => t.Line1)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Line2)
                .HasMaxLength(100);

            this.Property(t => t.Line3)
                .HasMaxLength(100);

            this.Property(t => t.City)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.State)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Zip)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.AddressType)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Address");
            this.Property(t => t.AddressID).HasColumnName("AddressID");
            this.Property(t => t.Line1).HasColumnName("Line1");
            this.Property(t => t.Line2).HasColumnName("Line2");
            this.Property(t => t.Line3).HasColumnName("Line3");
            this.Property(t => t.City).HasColumnName("City");
            this.Property(t => t.State).HasColumnName("State");
            this.Property(t => t.Zip).HasColumnName("Zip");
            this.Property(t => t.AddressType).HasColumnName("AddressType");
        }
    }
}
