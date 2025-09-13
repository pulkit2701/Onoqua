using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Onoqua.Entities.Models.Mapping
{
    public class InnterFaceMap : EntityTypeConfiguration<InnterFace>
    {
        public InnterFaceMap()
        {
            // Primary Key
            this.HasKey(t => t.InterFaceID);

            // Properties
            this.Property(t => t.InterFaceID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.SQL)
                .IsRequired()
                .HasMaxLength(300);

            // Table & Column Mappings
            this.ToTable("InnterFaces");
            this.Property(t => t.InterFaceID).HasColumnName("InterFaceID");
            this.Property(t => t.SQL).HasColumnName("SQL");
            this.Property(t => t.ConnectionStringID).HasColumnName("ConnectionStringID");

            // Relationships
            this.HasRequired(t => t.ConnectionString)
                .WithMany(t => t.InnterFaces)
                .HasForeignKey(d => d.ConnectionStringID);

        }
    }
}
