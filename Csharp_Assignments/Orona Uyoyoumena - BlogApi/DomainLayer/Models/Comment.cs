using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Models
{
    public class Comment
    {
        public int Id { get; set; }

        public int CountComments { get; set; }

        public string Details { get; set; }

        //create a navigator to link the comment table and the post table
        public Post post { get; set; }

        public int postId { get; set; }
    }
}
