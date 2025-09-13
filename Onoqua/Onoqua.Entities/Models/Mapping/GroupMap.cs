using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Onoqua.Entities.Models.Mapping
{
    public class GroupMap : EntityTypeConfiguration<Group>
    {
        public GroupMap()
        {
            // Primary Key
            this.HasKey(t => t.GroupID);

            // Properties
            this.Property(t => t.GroupName)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Groups");
            this.Property(t => t.GroupID).HasColumnName("GroupID").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(t => t.GroupName).HasColumnName("GroupName");
        }
    }
}
