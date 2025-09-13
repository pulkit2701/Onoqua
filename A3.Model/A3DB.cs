using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace A3.Model
{
    public partial class A3DB : DbContext
    {
        public A3DB()
            : base("name=A3DB")
        {
        }

        public virtual DbSet<Address> Addresses { get; set; }
        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<ComboValue> ComboValues { get; set; }
        public virtual DbSet<ConnectionString> ConnectionStrings { get; set; }
        public virtual DbSet<Entity> Entities { get; set; }
        public virtual DbSet<FieldExpression> FieldExpressions { get; set; }
        public virtual DbSet<Field> Fields { get; set; }
        public virtual DbSet<FormGroup> FormGroups { get; set; }
        public virtual DbSet<Form> Forms { get; set; }
        public virtual DbSet<GroupField> GroupFields { get; set; }
        public virtual DbSet<Group> Groups { get; set; }
        public virtual DbSet<InnterFace> InnterFaces { get; set; }
        public virtual DbSet<Message> Messages { get; set; }
        public virtual DbSet<Process> Processes { get; set; }
        public virtual DbSet<ProcessClientField> ProcessClientFields { get; set; }
        public virtual DbSet<ProcessClient> ProcessClients { get; set; }
        public virtual DbSet<ProcessStep> ProcessSteps { get; set; }
        public virtual DbSet<QueryFilter> QueryFilters { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<Task> Tasks { get; set; }
        public virtual DbSet<WorkFlow> WorkFlows { get; set; }
        public virtual DbSet<WorkFlowField> WorkFlowFields { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Address>()
                .Property(e => e.AddressID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Address>()
                .Property(e => e.Line1)
                .IsUnicode(false);

            modelBuilder.Entity<Address>()
                .Property(e => e.Line2)
                .IsUnicode(false);

            modelBuilder.Entity<Address>()
                .Property(e => e.Line3)
                .IsUnicode(false);

            modelBuilder.Entity<Address>()
                .Property(e => e.City)
                .IsUnicode(false);

            modelBuilder.Entity<Address>()
                .Property(e => e.State)
                .IsUnicode(false);

            modelBuilder.Entity<Address>()
                .Property(e => e.Zip)
                .IsUnicode(false);

            modelBuilder.Entity<Address>()
                .Property(e => e.AddressType)
                .IsUnicode(false);

            modelBuilder.Entity<Client>()
                .Property(e => e.ClientID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Client>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Client>()
                .HasMany(e => e.Entities)
                .WithRequired(e => e.Client)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Client>()
                .HasMany(e => e.ProcessClients)
                .WithRequired(e => e.Client)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ComboValue>()
                .Property(e => e.ComboValueID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<ComboValue>()
                .Property(e => e.FieldID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<ComboValue>()
                .Property(e => e.DisplayText)
                .IsUnicode(false);

            modelBuilder.Entity<ComboValue>()
                .Property(e => e.ComboValue1)
                .IsUnicode(false);

            modelBuilder.Entity<ConnectionString>()
                .Property(e => e.ConnectionStringID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<ConnectionString>()
                .Property(e => e.ConnectionString1)
                .IsUnicode(false);

            modelBuilder.Entity<ConnectionString>()
                .HasMany(e => e.InnterFaces)
                .WithRequired(e => e.ConnectionString)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Entity>()
                .Property(e => e.EntityID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Entity>()
                .Property(e => e.RoleID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Entity>()
                .Property(e => e.FirstName)
                .IsUnicode(false);

            modelBuilder.Entity<Entity>()
                .Property(e => e.LastName)
                .IsUnicode(false);

            modelBuilder.Entity<Entity>()
                .Property(e => e.emailID)
                .IsUnicode(false);

            modelBuilder.Entity<Entity>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<Entity>()
                .Property(e => e.AddressID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Entity>()
                .Property(e => e.ClientID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<FieldExpression>()
                .Property(e => e.FieldExpressionID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<FieldExpression>()
                .Property(e => e.FieldExpression1)
                .IsUnicode(false);

            modelBuilder.Entity<FieldExpression>()
                .Property(e => e.FieldID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Field>()
                .Property(e => e.FieldID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Field>()
                .Property(e => e.FieldType)
                .IsUnicode(false);

            modelBuilder.Entity<Field>()
                .Property(e => e.FieldName)
                .IsUnicode(false);

            modelBuilder.Entity<Field>()
                .HasMany(e => e.ComboValues)
                .WithRequired(e => e.Field)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Field>()
                .HasMany(e => e.FieldExpressions)
                .WithRequired(e => e.Field)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Field>()
                .HasMany(e => e.GroupFields)
                .WithRequired(e => e.Field)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Field>()
                .HasMany(e => e.ProcessClientFields)
                .WithRequired(e => e.Field)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Field>()
                .HasMany(e => e.WorkFlowFields)
                .WithRequired(e => e.Field)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FormGroup>()
                .Property(e => e.FormGroupID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<FormGroup>()
                .Property(e => e.FormID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<FormGroup>()
                .Property(e => e.GroupID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<FormGroup>()
                .Property(e => e.Priority)
                .HasPrecision(3, 0);

            modelBuilder.Entity<FormGroup>()
                .Property(e => e.UIClass)
                .IsUnicode(false);

            modelBuilder.Entity<Form>()
                .Property(e => e.FormID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Form>()
                .Property(e => e.FormTitle)
                .IsUnicode(false);

            modelBuilder.Entity<Form>()
                .HasMany(e => e.FormGroups)
                .WithRequired(e => e.Form)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<GroupField>()
                .Property(e => e.GroupFieldID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<GroupField>()
                .Property(e => e.GroupID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<GroupField>()
                .Property(e => e.FieldID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<GroupField>()
                .Property(e => e.UIClass)
                .IsUnicode(false);

            modelBuilder.Entity<Group>()
                .Property(e => e.GroupID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Group>()
                .Property(e => e.GroupName)
                .IsUnicode(false);

            modelBuilder.Entity<Group>()
                .HasMany(e => e.FormGroups)
                .WithRequired(e => e.Group)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Group>()
                .HasMany(e => e.GroupFields)
                .WithRequired(e => e.Group)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<InnterFace>()
                .Property(e => e.InterFaceID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<InnterFace>()
                .Property(e => e.SQL)
                .IsUnicode(false);

            modelBuilder.Entity<InnterFace>()
                .Property(e => e.ConnectionStringID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Message>()
                .Property(e => e.MessageID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Message>()
                .Property(e => e.Message1)
                .IsUnicode(false);

            modelBuilder.Entity<Message>()
                .Property(e => e.TaskID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Process>()
                .Property(e => e.ProcessID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Process>()
                .Property(e => e.ProcessName)
                .IsUnicode(false);

            modelBuilder.Entity<Process>()
                .Property(e => e.Summary)
                .IsUnicode(false);

            modelBuilder.Entity<Process>()
                .Property(e => e.LogoURL)
                .IsUnicode(false);

            modelBuilder.Entity<Process>()
                .HasMany(e => e.ProcessClients)
                .WithRequired(e => e.Process)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Process>()
                .HasMany(e => e.WorkFlows)
                .WithRequired(e => e.Process)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ProcessClientField>()
                .Property(e => e.ProcessClientFieldID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<ProcessClientField>()
                .Property(e => e.ProcessClientID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<ProcessClientField>()
                .Property(e => e.FieldID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<ProcessClientField>()
                .Property(e => e.FieldValue)
                .IsUnicode(false);

            modelBuilder.Entity<ProcessClient>()
                .Property(e => e.ProcessClientID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<ProcessClient>()
                .Property(e => e.ClientID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<ProcessClient>()
                .Property(e => e.ProcessID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<ProcessClient>()
                .HasMany(e => e.ProcessClientFields)
                .WithRequired(e => e.ProcessClient)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ProcessStep>()
                .Property(e => e.ProcessStepID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<ProcessStep>()
                .Property(e => e.ProcessStepName)
                .IsUnicode(false);

            modelBuilder.Entity<ProcessStep>()
                .HasMany(e => e.WorkFlows)
                .WithRequired(e => e.ProcessStep)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<QueryFilter>()
                .Property(e => e.QueryFilterID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<QueryFilter>()
                .Property(e => e.QueryFilter1)
                .IsUnicode(false);

            modelBuilder.Entity<QueryFilter>()
                .HasMany(e => e.WorkFlowFields)
                .WithRequired(e => e.QueryFilter)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Role>()
                .Property(e => e.RoleID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Role>()
                .Property(e => e.RoleType)
                .IsUnicode(false);

            modelBuilder.Entity<Role>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Role>()
                .HasMany(e => e.Entities)
                .WithRequired(e => e.Role)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Task>()
                .Property(e => e.TaskID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Task>()
                .Property(e => e.Expression)
                .IsUnicode(false);

            modelBuilder.Entity<Task>()
                .Property(e => e.ResultFieldID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Task>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Task>()
                .HasMany(e => e.Messages)
                .WithRequired(e => e.Task)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<WorkFlow>()
                .Property(e => e.WorkFlowID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<WorkFlow>()
                .Property(e => e.TaskID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<WorkFlow>()
                .Property(e => e.InterFaceID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<WorkFlow>()
                .Property(e => e.FormID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<WorkFlow>()
                .Property(e => e.ProcessID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<WorkFlow>()
                .Property(e => e.ConditionalTaskID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<WorkFlow>()
                .Property(e => e.Priority)
                .HasPrecision(5, 0);

            modelBuilder.Entity<WorkFlow>()
                .Property(e => e.ProcessStepID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<WorkFlow>()
                .Property(e => e.Provider)
                .IsUnicode(false);

            modelBuilder.Entity<WorkFlow>()
                .HasMany(e => e.WorkFlowFields)
                .WithRequired(e => e.WorkFlow)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<WorkFlowField>()
                .Property(e => e.WorkFlowFieldID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<WorkFlowField>()
                .Property(e => e.WorkFlowID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<WorkFlowField>()
                .Property(e => e.FieldID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<WorkFlowField>()
                .Property(e => e.QueryFilterID)
                .HasPrecision(18, 0);
        }
    }
}
