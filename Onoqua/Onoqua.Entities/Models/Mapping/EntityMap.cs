using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Onoqua.Entities.Models.Mapping
{
    public class EntityMap : EntityTypeConfiguration<Entity>
    {
        public EntityMap()
        {
            // Primary Key
            this.HasKey(t => t.EntityID);

            // Properties
            this.Property(t => t.FirstName)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.LastName)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.emailID)
                .HasMaxLength(100);

            this.Property(t => t.Password)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Entity");
            this.Property(t => t.EntityID).HasColumnName("EntityID");
            this.Property(t => t.RoleID).HasColumnName("RoleID");
            this.Property(t => t.FirstName).HasColumnName("FirstName");
            this.Property(t => t.LastName).HasColumnName("LastName");
            this.Property(t => t.emailID).HasColumnName("emailID");
            this.Property(t => t.Password).HasColumnName("Password");
            this.Property(t => t.AddressID).HasColumnName("AddressID");
            this.Property(t => t.ClientID).HasColumnName("ClientID");

            // Relationships
            this.HasOptional(t => t.Address)
                .WithMany(t => t.Entities)
                .HasForeignKey(d => d.AddressID);
            this.HasRequired(t => t.Client)
                .WithMany(t => t.Entities)
                .HasForeignKey(d => d.ClientID);
            this.HasRequired(t => t.Role)
                .WithMany(t => t.Entities)
                .HasForeignKey(d => d.RoleID);

        }
    }
}
