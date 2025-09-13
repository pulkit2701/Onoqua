using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Onoqua.Entities.Models.Mapping
{
    public class QueryFilterMap : EntityTypeConfiguration<QueryFilter>
    {
        public QueryFilterMap()
        {
            // Primary Key
            this.HasKey(t => t.QueryFilterID);

            // Properties
            this.Property(t => t.QueryFilterID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.QueryFilter1)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("QueryFilters");
            this.Property(t => t.QueryFilterID).HasColumnName("QueryFilterID");
            this.Property(t => t.QueryFilter1).HasColumnName("QueryFilter");
        }
    }
}
