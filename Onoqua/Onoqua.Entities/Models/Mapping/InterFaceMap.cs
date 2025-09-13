using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Onoqua.Entities.Models.Mapping
{
    public class InterFaceMap : EntityTypeConfiguration<InterFace>
    {
        public InterFaceMap()
        {
            // Primary Key
            this.HasKey(t => t.InterFaceID);

            // Properties
            this.Property(t => t.InterFaceID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("InterFaces");
            this.Property(t => t.InterFaceID).HasColumnName("InterFaceID");
            this.Property(t => t.ProviderID).HasColumnName("ProviderID");
            this.Property(t => t.ProviderType).HasColumnName("ProviderType");
        }
    }
}
