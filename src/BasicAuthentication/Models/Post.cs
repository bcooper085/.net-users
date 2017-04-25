using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BasicAuthentication.Models
{
    [Table("Posts")]
    public class Post
    {
        [Key]
        public int Id { get; set; }
        public string Description { get; set; }
        public virtual ApplicationUser User { get; set; }
        
    }
}
