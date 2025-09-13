using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Onoqua.Entities.Models.Mapping
{
    public class GroupFieldMap : EntityTypeConfiguration<GroupField>
    {
        public GroupFieldMap()
        {
            // Primary Key
            this.HasKey(t => t.GroupFieldID);

            // Properties
            this.Property(t => t.UIClass)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("GroupFields");
            this.Property(t => t.GroupFieldID).HasColumnName("GroupFieldID").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(t => t.GroupID).HasColumnName("GroupID");
            this.Property(t => t.FieldID).HasColumnName("FieldID");
            this.Property(t => t.Priority).HasColumnName("Priority");
            this.Property(t => t.UIClass).HasColumnName("UIClass");

            // Relationships
            this.HasRequired(t => t.Field)
                .WithMany(t => t.GroupFields)
                .HasForeignKey(d => d.FieldID);
            this.HasRequired(t => t.Group)
                .WithMany(t => t.GroupFields)
                .HasForeignKey(d => d.GroupID);

        }
    }
}
