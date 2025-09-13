using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Onoqua.Entities.Models.Mapping
{
    public class FieldMap : EntityTypeConfiguration<Field>
    {
        public FieldMap()
        {
            // Primary Key
            this.HasKey(t => t.FieldID);

            // Properties
            this.Property(t => t.FieldType)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.FieldName)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Fields");
            this.Property(t => t.FieldID).HasColumnName("FieldID").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(t => t.FieldType).HasColumnName("FieldType");
            this.Property(t => t.FieldName).HasColumnName("FieldName");
        }
    }
}
