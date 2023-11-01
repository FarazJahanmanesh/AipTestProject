namespace MyApi.Models.Requests.Post
{
    public class AddPostRequests
    {
        public bool IsDeleted { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int CategoryId { get; set; }
        public long UserId { get; set; }
    }
}
