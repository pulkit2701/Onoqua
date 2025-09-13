using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Onoqua.Entities.Models.Mapping
{
    public class FormGroupMap : EntityTypeConfiguration<FormGroup>
    {
        public FormGroupMap()
        {
            // Primary Key
            this.HasKey(t => t.FormGroupID);

            // Properties
            this.Property(t => t.FormGroupID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.UIClass)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("FormGroups");
            this.Property(t => t.FormGroupID).HasColumnName("FormGroupID");
            this.Property(t => t.FormID).HasColumnName("FormID");
            this.Property(t => t.GroupID).HasColumnName("GroupID");
            this.Property(t => t.Priority).HasColumnName("Priority");
            this.Property(t => t.UIClass).HasColumnName("UIClass");
            this.Property(t => t.IsVertical).HasColumnName("IsVertical");

            // Relationships
            this.HasRequired(t => t.Form)
                .WithMany(t => t.FormGroups)
                .HasForeignKey(d => d.FormID);
            this.HasRequired(t => t.Group)
                .WithMany(t => t.FormGroups)
                .HasForeignKey(d => d.GroupID);

        }
    }
}
