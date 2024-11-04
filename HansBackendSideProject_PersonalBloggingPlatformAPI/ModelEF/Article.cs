namespace HansBackendSideProject_PersonalBloggingPlatformAPI.ModelEF
{
    public class Article
    {
        public int Id { get; set; }

        public string Title { get; set; } = string.Empty;

        public string Content { get; set; } = string.Empty;

        public DateTime PublishDate { get; set; }

        public List<string> Tags { get; set; } = [];
    }
}
