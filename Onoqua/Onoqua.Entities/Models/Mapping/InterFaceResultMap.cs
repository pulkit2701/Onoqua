using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Onoqua.Entities.Models.Mapping
{
    public class InterFaceResultMap : EntityTypeConfiguration<InterFaceResult>
    {
        public InterFaceResultMap()
        {
            // Primary Key
            this.HasKey(t => t.InterFaceResultID);

            // Properties
            this.Property(t => t.InterFaceResultID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.FieldName)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("InterFaceResults");
            this.Property(t => t.InterFaceResultID).HasColumnName("InterFaceResultID");
            this.Property(t => t.InterFaceID).HasColumnName("InterFaceID");
            this.Property(t => t.FieldName).HasColumnName("FieldName");
            this.Property(t => t.FieldID).HasColumnName("FieldID");

            // Relationships
            this.HasRequired(t => t.InterFace)
                .WithMany(t => t.InterFaceResults)
                .HasForeignKey(d => d.InterFaceID);

        }
    }
}
