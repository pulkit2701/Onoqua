using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Onoqua.Entities.Models.Mapping
{
    public class FieldExpressionMap : EntityTypeConfiguration<FieldExpression>
    {
        public FieldExpressionMap()
        {
            // Primary Key
            this.HasKey(t => t.FieldExpressionID);

            // Properties
            this.Property(t => t.FieldExpressionID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.FieldExpression1)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("FieldExpressions");
            this.Property(t => t.FieldExpressionID).HasColumnName("FieldExpressionID");
            this.Property(t => t.FieldExpression1).HasColumnName("FieldExpression");
            this.Property(t => t.FieldID).HasColumnName("FieldID");

            // Relationships
            this.HasRequired(t => t.Field)
                .WithMany(t => t.FieldExpressions)
                .HasForeignKey(d => d.FieldID);

        }
    }
}
