
using BlazorApp1.Shared;

namespace BlazorApp1.Server.data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        { }

        public DbSet<Question>? Question { get; set; }

        public DbSet<Form>? Form { get; set; }
        public DbSet<mainform>? MainForm { get; set; }
        public DbSet<IndividualMultichoiceQuestion>? individualMultiChoiceQuestion { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder) {
			modelBuilder.Entity<Form>()
                    .HasMany(dm => dm.QuestionList)
                    .WithOne()
                    .OnDelete(DeleteBehavior.Cascade);

			modelBuilder.Entity<Question>()
					.HasMany(dm => dm.listOfMultiChoiceQuestions)
					.WithOne()
					.OnDelete(DeleteBehavior.Cascade);
		}


	}
}
