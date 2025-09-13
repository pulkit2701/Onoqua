using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Onoqua.Entities.Models.Mapping
{
    public class ProcessStepMap : EntityTypeConfiguration<ProcessStep>
    {
        public ProcessStepMap()
        {
            // Primary Key
            this.HasKey(t => t.ProcessStepID);

            // Properties
            this.Property(t => t.ProcessStepName)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("ProcessSteps");
            this.Property(t => t.ProcessStepID).HasColumnName("ProcessStepID");
            this.Property(t => t.ProcessStepName).HasColumnName("ProcessStepName");
            this.Property(t => t.IsSetup).HasColumnName("IsSetup");
        }
    }
}
