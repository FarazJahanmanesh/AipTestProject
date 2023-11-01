namespace MyApi.Models.Requests.Post
{
    public class UpdatePostRequests
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int CategoryId { get; set; }
    }
}
