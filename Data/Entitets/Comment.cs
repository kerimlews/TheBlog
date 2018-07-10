using System;
using System.ComponentModel.DataAnnotations;

namespace blog.Data.Entitets
{
    public class Comment
    {
        public int Id { get ; set; }

        [Required]
        public string Body { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public BlogPost BlogPosts { get; set; }
        public int BlogPostId { get; set; }
    }
}