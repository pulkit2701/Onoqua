using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Onoqua.Entities.Models.Mapping
{
    public class WorkFlowMap : EntityTypeConfiguration<WorkFlow>
    {
        public WorkFlowMap()
        {
            // Primary Key
            this.HasKey(t => t.WorkFlowID);

            // Properties
            this.Property(t => t.WorkFlowID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("WorkFlows");
            this.Property(t => t.WorkFlowID).HasColumnName("WorkFlowID");
            this.Property(t => t.TaskID).HasColumnName("TaskID");
            this.Property(t => t.InterFaceID).HasColumnName("InterFaceID");
            this.Property(t => t.FormID).HasColumnName("FormID");
            this.Property(t => t.IsLast).HasColumnName("IsLast");
            this.Property(t => t.ProcessID).HasColumnName("ProcessID");
            this.Property(t => t.ConditionalTaskID).HasColumnName("ConditionalTaskID");
            this.Property(t => t.Priority).HasColumnName("Priority");
            this.Property(t => t.ProcessStepID).HasColumnName("ProcessStepID");

            // Relationships
            this.HasRequired(t => t.Form)
                .WithMany(t => t.WorkFlows)
                .HasForeignKey(d => d.FormID);
            this.HasOptional(t => t.InnterFace)
                .WithMany(t => t.WorkFlows)
                .HasForeignKey(d => d.InterFaceID);
            this.HasRequired(t => t.Process)
                .WithMany(t => t.WorkFlows)
                .HasForeignKey(d => d.ProcessID);
            this.HasRequired(t => t.ProcessStep)
                .WithMany(t => t.WorkFlows)
                .HasForeignKey(d => d.ProcessStepID);
            this.HasOptional(t => t.Task)
                .WithMany(t => t.WorkFlows)
                .HasForeignKey(d => d.TaskID);

        }
    }
}
