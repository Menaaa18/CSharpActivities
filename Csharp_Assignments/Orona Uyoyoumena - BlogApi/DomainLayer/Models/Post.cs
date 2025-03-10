using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Models
{
    public class Post
    {
        public int Id { get; set; }

        public int AuthorId { get; set; }

        //create a navigator property to show that the post and the author are connected
        public Author author { get; set; }
        public string? Date { get; set; }

        public string? Likes { get; set; }

        public string? UploadTime { get; set; }

        public string? DeletionTime { get; set; }

        public string? LikeCount { get; set; }

        public string? ViewCount { get; set; }

        public bool isTrending { get; set; }

        public ICollection<Comment> Comment { get; set; }

        public ICollection<Like> Like { get; set; }

        //create a navigation property to genre as one post can belong to one genre
        public Genre genre { get; set; }

    }
}
