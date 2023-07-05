
using BlazorApp1.Shared;

namespace BlazorApp1.Server.data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        { }

        public DbSet<Question>? Questions { get; set; }

        public DbSet<Form>? Forms { get; set; }
        public DbSet<mainform>? MainForm { get; set; }
        public DbSet<IndividualMultichoiceQuestion>? individualMultiChoiceQuestion { get; set; }

        
    }
}
