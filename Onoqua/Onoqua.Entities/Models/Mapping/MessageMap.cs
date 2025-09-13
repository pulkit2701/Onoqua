using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Onoqua.Entities.Models.Mapping
{
    public class MessageMap : EntityTypeConfiguration<Message>
    {
        public MessageMap()
        {
            // Primary Key
            this.HasKey(t => t.MessageID);

            // Properties
            this.Property(t => t.MessageID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Message1)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Messages");
            this.Property(t => t.MessageID).HasColumnName("MessageID");
            this.Property(t => t.Message1).HasColumnName("Message");
            this.Property(t => t.TaskID).HasColumnName("TaskID");

            // Relationships
            this.HasRequired(t => t.Task)
                .WithMany(t => t.Messages)
                .HasForeignKey(d => d.TaskID);

        }
    }
}
