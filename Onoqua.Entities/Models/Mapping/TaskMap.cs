using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Onoqua.Entities.Models.Mapping
{
    public class TaskMap : EntityTypeConfiguration<Task>
    {
        public TaskMap()
        {
            // Primary Key
            this.HasKey(t => t.TaskID);

            // Properties
            this.Property(t => t.TaskID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Expression)
                .IsRequired()
                .HasMaxLength(500);

            this.Property(t => t.Description)
                .IsRequired()
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("Tasks");
            this.Property(t => t.TaskID).HasColumnName("TaskID");
            this.Property(t => t.Expression).HasColumnName("Expression");
            this.Property(t => t.ResultFieldID).HasColumnName("ResultFieldID");
            this.Property(t => t.Description).HasColumnName("Description");
        }
    }
}
