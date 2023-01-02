namespace UmbracoProject.Services
{
    public class Comment
    {
        public int PostId { get; set; }
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Body { get; set; }
    }

    public class CommentClient
    {
        public static async Task<List<Comment>?> GetCommentsAsync()
        {
            var client = new HttpClient();

            var request = await client.GetAsync(
                "https://jsonplaceholder.typicode.com/comments?postId=2");

            if (!request.IsSuccessStatusCode) return null;

            var response = await request.Content
                .ReadFromJsonAsync<List<Comment>>();

            if (response == null) return null;

            var commentData = new List<Comment>();

            foreach (var comment in response)
            {
                commentData.Add(comment);
            }

            return commentData;

        }
    }
}


