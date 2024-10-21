using HansBackendSideProject_PersonalBloggingPlatformAPI.Repository;
using System.Security.Cryptography.X509Certificates;

namespace HansBackendSideProject_PersonalBloggingPlatformAPI.Service
{
    public class ArticleService
    {
        private readonly ArticleRepository _articleRepository;

        public ArticleService(
            ArticleRepository articleRepository)
        {
            _articleRepository = articleRepository;
        }

        public void GetArticles(DateTime? publisDate, List<string?> tags)
        {
        }
    }
}
