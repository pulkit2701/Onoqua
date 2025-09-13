using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Onoqua.Entities.Models.Mapping
{
    public class DBProviderMap : EntityTypeConfiguration<DBProvider>
    {
        public DBProviderMap()
        {
            // Primary Key
            this.HasKey(t => t.DBProviderID);

            // Properties
            this.Property(t => t.DBProviderID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.SQL)
                .IsRequired()
                .HasMaxLength(500);

            // Table & Column Mappings
            this.ToTable("DBProvider");
            this.Property(t => t.DBProviderID).HasColumnName("DBProviderID");
            this.Property(t => t.SQL).HasColumnName("SQL");
            this.Property(t => t.ConnectionStringID).HasColumnName("ConnectionStringID");

            // Relationships
            this.HasRequired(t => t.ConnectionString)
                .WithMany(t => t.DBProviders)
                .HasForeignKey(d => d.ConnectionStringID);

        }
    }
}
