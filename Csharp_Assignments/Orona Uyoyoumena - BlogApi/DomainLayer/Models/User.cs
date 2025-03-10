using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Models
{
    public class User
    {
        public int ID { get; set; }

        //[ForeignKey("Post ID")]
        //[ForeignKey("Comment ID")]
        public string Name { get; set; }

        public int userName { get; set; }

        public string userEmail { get; set; }

        public string userComments { get; set; }

        public ICollection<Like> Like { get; set; }

    }
}
