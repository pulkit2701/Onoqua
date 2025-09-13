using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Onoqua.Entities.Models.Mapping
{
    public class ProcessClientMap : EntityTypeConfiguration<ProcessClient>
    {
        public ProcessClientMap()
        {
            // Primary Key
            this.HasKey(t => t.ProcessClientID);

            // Properties
            // Table & Column Mappings
            this.ToTable("ProcessClients");
            this.Property(t => t.ProcessClientID).HasColumnName("ProcessClientID");
            this.Property(t => t.ClientID).HasColumnName("ClientID");
            this.Property(t => t.ProcessID).HasColumnName("ProcessID");

            // Relationships
            this.HasRequired(t => t.Client)
                .WithMany(t => t.ProcessClients)
                .HasForeignKey(d => d.ClientID);
            this.HasRequired(t => t.Process)
                .WithMany(t => t.ProcessClients)
                .HasForeignKey(d => d.ProcessID);

        }
    }
}
