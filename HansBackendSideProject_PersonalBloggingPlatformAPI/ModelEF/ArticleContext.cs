using Microsoft.EntityFrameworkCore;

namespace HansBackendSideProject_PersonalBloggingPlatformAPI.ModelEF;

public class ArticleContext : DbContext
{
    public ArticleContext()
    {
    }
    
    public ArticleContext(DbContextOptions<ArticleContext> options)
        : base(options)
    {
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlite("Data Source=identifier.sqlite");
        }
    }
    
    public DbSet<Article> Articles { get; set; }
}