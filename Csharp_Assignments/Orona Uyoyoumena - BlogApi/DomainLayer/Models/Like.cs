using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Models
{
    public class Like
    {
        public int Id { get; set; }

        public int userId { get; set; }
        public int postId { get; set; }

        //create a navigation property to the users table and the post table
        public User user { get; set; }

        public Post post { get; set; }
      

    }
}
