using HansBackendSideProject_PersonalBloggingPlatformAPI.ModelEF;
using HansBackendSideProject_PersonalBloggingPlatformAPI.Service;
using Microsoft.AspNetCore.Mvc;

namespace HansBackendSideProject_PersonalBloggingPlatformAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ArticlesController : ControllerBase
    {
        private readonly ArticleService _articleService;

        public ArticlesController(
            ArticleService articleService)
        {
            _articleService = articleService;
        }

        // GET: api/articles
        [HttpGet]
        public ActionResult<List<Article>> GetArticles([FromQuery] DateTime? publishDate, [FromQuery] List<string?> tags)
        {
            return null;
        }

        // GET: api/articles/{id}
        [HttpGet("{id}")]
        public ActionResult GetArticle(int id)
        {
            return null;
        }

        // POST: api/articles
        [HttpPost]
        public ActionResult CreateArticle(Article article)
        {
            return null;
        }

        // PUT: api/articles/{id}
        [HttpPut("{id}")]
        public ActionResult UpdateArticle(int id, [FromBody]Article updatedArticle)
        {
            return null;
        }

        // DELETE: api/articles/{id}
        [HttpDelete("{id}")]
        public ActionResult DeleteArticle(int id)
        {
            return null;
        }
    }
}
