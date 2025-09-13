using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Onoqua.Entities.Models.Mapping
{
    public class FormMap : EntityTypeConfiguration<Form>
    {
        public FormMap()
        {
            // Primary Key
            this.HasKey(t => t.FormID);

            // Properties
            this.Property(t => t.FormTitle)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Forms");
            this.Property(t => t.FormID).HasColumnName("FormID");
            this.Property(t => t.FormTitle).HasColumnName("FormTitle");
        }
    }
}
