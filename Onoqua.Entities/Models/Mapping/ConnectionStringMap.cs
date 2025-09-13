using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Onoqua.Entities.Models.Mapping
{
    public class ConnectionStringMap : EntityTypeConfiguration<ConnectionString>
    {
        public ConnectionStringMap()
        {
            // Primary Key
            this.HasKey(t => t.ConnectionStringID);

            // Properties
            this.Property(t => t.ConnectionStringID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ConnectionString1)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("ConnectionStrings");
            this.Property(t => t.ConnectionStringID).HasColumnName("ConnectionStringID");
            this.Property(t => t.ConnectionString1).HasColumnName("ConnectionString");
        }
    }
}
