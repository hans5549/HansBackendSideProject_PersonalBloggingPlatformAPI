using HansBackendSideProject_PersonalBloggingPlatformAPI.Model;
using MongoDB.Driver;

namespace HansBackendSideProject_PersonalBloggingPlatformAPI.Repository
{
    public class ArticleRepository
    {
        private readonly IMongoCollection<Article> _articles;

        public ArticleRepository(IMongoDatabase database)
        {
            _articles = database.GetCollection<Article>("Articles");
        }
    }
}
