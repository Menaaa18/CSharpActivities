using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Models
{
    public class Genre
    {
        public int Id { get; set; }

        public string? GenreType { get; set; }

        //creating a navigation property to Post
        public ICollection<Post> Post { get; set; }
    }
}