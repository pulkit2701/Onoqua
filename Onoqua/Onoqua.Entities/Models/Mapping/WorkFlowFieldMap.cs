using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Onoqua.Entities.Models.Mapping
{
    public class WorkFlowFieldMap : EntityTypeConfiguration<WorkFlowField>
    {
        public WorkFlowFieldMap()
        {
            // Primary Key
            this.HasKey(t => new { t.WorkFlowFieldID, t.WorkFlowID, t.FieldID, t.QueryFilterID });

            // Properties
            this.Property(t => t.WorkFlowFieldID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.WorkFlowID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.FieldID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.QueryFilterID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("WorkFlowFields");
            this.Property(t => t.WorkFlowFieldID).HasColumnName("WorkFlowFieldID");
            this.Property(t => t.WorkFlowID).HasColumnName("WorkFlowID");
            this.Property(t => t.FieldID).HasColumnName("FieldID");
            this.Property(t => t.QueryFilterID).HasColumnName("QueryFilterID");

            // Relationships
            this.HasRequired(t => t.Field)
                .WithMany(t => t.WorkFlowFields)
                .HasForeignKey(d => d.FieldID);
            this.HasRequired(t => t.QueryFilter)
                .WithMany(t => t.WorkFlowFields)
                .HasForeignKey(d => d.QueryFilterID);
            this.HasRequired(t => t.WorkFlow)
                .WithMany(t => t.WorkFlowFields)
                .HasForeignKey(d => d.WorkFlowID);

        }
    }
}
