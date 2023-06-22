
namespace BlazorApp1.Server.data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        { }

        public DbSet<Question>? Questions { get; set; }
        public DbSet<Form>? Forms { get; set; }
    }
}
