using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Onoqua.Entities.Models.Mapping
{
    public class ProcessMap : EntityTypeConfiguration<Process>
    {
        public ProcessMap()
        {
            // Primary Key
            this.HasKey(t => t.ProcessID);

            // Properties
            this.Property(t => t.ProcessID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ProcessName)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Summary)
                .IsRequired()
                .HasMaxLength(400);

            this.Property(t => t.LogoURL)
                .IsRequired()
                .HasMaxLength(150);

            // Table & Column Mappings
            this.ToTable("Process");
            this.Property(t => t.ProcessID).HasColumnName("ProcessID");
            this.Property(t => t.ProcessName).HasColumnName("ProcessName");
            this.Property(t => t.Summary).HasColumnName("Summary");
            this.Property(t => t.LogoURL).HasColumnName("LogoURL");
            //this.Property(t => t.SetupProcessID).HasColumnName("SetupProcessID");
        }
    }
}
