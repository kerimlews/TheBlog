using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using blog.Data.Enums;

namespace blog.Data.Entitets
{
    public class TagList
    {
        public int Id { get; set; }

        public ETag Tag { get; set; }
        
        public BlogPost BlogPost { get; set; }
        public int BlogPostId { get; set; }

    }
}