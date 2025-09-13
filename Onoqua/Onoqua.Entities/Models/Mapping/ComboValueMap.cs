using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Onoqua.Entities.Models.Mapping
{
    public class ComboValueMap : EntityTypeConfiguration<ComboValue>
    {
        public ComboValueMap()
        {
            // Primary Key
            this.HasKey(t => t.ComboValueID);

            // Properties
            this.Property(t => t.ComboValueID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.DisplayText)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.ComboValue1)
                .IsRequired()
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("ComboValues");
            this.Property(t => t.ComboValueID).HasColumnName("ComboValueID");
            this.Property(t => t.FieldID).HasColumnName("FieldID");
            this.Property(t => t.DisplayText).HasColumnName("DisplayText");
            this.Property(t => t.ComboValue1).HasColumnName("ComboValue");

            // Relationships
            this.HasRequired(t => t.Field)
                .WithMany(t => t.ComboValues)
                .HasForeignKey(d => d.FieldID);

        }
    }
}
