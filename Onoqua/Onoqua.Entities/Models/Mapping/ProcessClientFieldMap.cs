using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Onoqua.Entities.Models.Mapping
{
    public class ProcessClientFieldMap : EntityTypeConfiguration<ProcessClientField>
    {
        public ProcessClientFieldMap()
        {
            // Primary Key
            this.HasKey(t => t.ProcessClientFieldID);

            // Properties
            this.Property(t => t.FieldValue)
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("ProcessClientFields");
            this.Property(t => t.ProcessClientFieldID).HasColumnName("ProcessClientFieldID");
            this.Property(t => t.ProcessClientID).HasColumnName("ProcessClientID");
            this.Property(t => t.FieldID).HasColumnName("FieldID");
            this.Property(t => t.FieldValue).HasColumnName("FieldValue");

            // Relationships
            this.HasRequired(t => t.Field)
                .WithMany(t => t.ProcessClientFields)
                .HasForeignKey(d => d.FieldID);
            this.HasRequired(t => t.ProcessClient)
                .WithMany(t => t.ProcessClientFields)
                .HasForeignKey(d => d.ProcessClientID);

        }
    }
}
