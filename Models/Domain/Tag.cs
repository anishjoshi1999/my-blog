namespace blog.Models.Domain
{
    // Represents a tag
    public class Tag
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public string? DisplayName { get; set; }

        // Tags can have multiple blog posts
        public ICollection<BlogPost> BlogPosts { get; set; }
    }

}
