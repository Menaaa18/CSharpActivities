using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Models
{
    public class Author
    {
        public int Id { get; set; }

        //[ForeignKey("Post ID")]
        public string Username { get;set; }

        //this is a navigation property to show that the Author class and Post are linked
        public ICollection<Post> Post{ get; set; }

    }
}
