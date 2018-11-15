using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.DataStructure
{
    public class Category
    {
        [Key]
        public Guid CategoryId { get; set; }

        [MaxLength(250)]
        [Required]
        public string Title { get; set; }
    }
}
