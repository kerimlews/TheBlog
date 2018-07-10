using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using blog.Infrastructure;

namespace blog.Data.Entitets
{
    public class BlogPost: IEntity
    {
        public BlogPost()
        {
            TagLists = new List<TagList>();
            Comments = new List<Comment>();
        }

        public int Id { get; set; }

        public string Slug { get; set; }

        [Required]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string Body { get; set; }

        public bool Favorited { get; set; }

        public int FavoritesCount { get; set; }

        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public List<TagList> TagLists { get; set; }
        public List<Comment> Comments { get; set; }
    }
}