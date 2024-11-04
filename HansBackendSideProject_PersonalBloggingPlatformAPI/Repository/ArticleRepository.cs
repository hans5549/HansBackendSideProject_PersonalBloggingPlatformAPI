using HansBackendSideProject_PersonalBloggingPlatformAPI.ModelEF;
using MongoDB.Driver;

namespace HansBackendSideProject_PersonalBloggingPlatformAPI.Repository
{
    public class ArticleRepository
    {
        private readonly ArticleContext _context;
        
        public ArticleRepository(ArticleContext context)
        {
            _context = context;
        }

        public List<Article> GetAll()
        {
            var result = _context.Articles.ToList();

            return result;
        }
    }
}
