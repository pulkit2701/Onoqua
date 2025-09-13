using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using Onoqua.Entities.Models.Mapping;

namespace Onoqua.Entities.Models
{
    public partial class OnoquaContext : DbContext
    {
        static OnoquaContext()
        {
            Database.SetInitializer<OnoquaContext>(null);
        }

        public OnoquaContext()
            : base("Name=OnoquaContext")
        {
        }

        public DbSet<Address> Addresses { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<ComboValue> ComboValues { get; set; }
        public DbSet<ConnectionString> ConnectionStrings { get; set; }
        public DbSet<Entity> Entities { get; set; }
        public DbSet<FieldExpression> FieldExpressions { get; set; }
        public DbSet<Field> Fields { get; set; }
        public DbSet<FormGroup> FormGroups { get; set; }
        public DbSet<Form> Forms { get; set; }
        public DbSet<GroupField> GroupFields { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<InnterFace> InnterFaces { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Process> Processes { get; set; }
        public DbSet<ProcessClientField> ProcessClientFields { get; set; }
        public DbSet<ProcessClient> ProcessClients { get; set; }
        public DbSet<ProcessStep> ProcessSteps { get; set; }
        public DbSet<QueryFilter> QueryFilters { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<sysdiagram> sysdiagrams { get; set; }
        public DbSet<Task> Tasks { get; set; }
        public DbSet<WorkFlowField> WorkFlowFields { get; set; }
        public DbSet<WorkFlow> WorkFlows { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AddressMap());
            modelBuilder.Configurations.Add(new ClientMap());
            modelBuilder.Configurations.Add(new ComboValueMap());
            modelBuilder.Configurations.Add(new ConnectionStringMap());
            modelBuilder.Configurations.Add(new EntityMap());
            modelBuilder.Configurations.Add(new FieldExpressionMap());
            modelBuilder.Configurations.Add(new FieldMap());
            modelBuilder.Configurations.Add(new FormGroupMap());
            modelBuilder.Configurations.Add(new FormMap());
            modelBuilder.Configurations.Add(new GroupFieldMap());
            modelBuilder.Configurations.Add(new GroupMap());
            modelBuilder.Configurations.Add(new InnterFaceMap());
            modelBuilder.Configurations.Add(new MessageMap());
            modelBuilder.Configurations.Add(new ProcessMap());
            modelBuilder.Configurations.Add(new ProcessClientFieldMap());
            modelBuilder.Configurations.Add(new ProcessClientMap());
            modelBuilder.Configurations.Add(new ProcessStepMap());
            modelBuilder.Configurations.Add(new QueryFilterMap());
            modelBuilder.Configurations.Add(new RoleMap());
            modelBuilder.Configurations.Add(new sysdiagramMap());
            modelBuilder.Configurations.Add(new TaskMap());
            modelBuilder.Configurations.Add(new WorkFlowFieldMap());
            modelBuilder.Configurations.Add(new WorkFlowMap());
        }
    }
}
