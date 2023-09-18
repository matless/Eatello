using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Eatello.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required] 
        public string Title { get; set; }
    }
}
