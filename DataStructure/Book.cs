using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.DataStructure
{
    public class Book
    {
        [Key]
        public Guid BookId { get; set; }

        [MaxLength(250)]
        [Required]
        public string Title { get; set; }

        [MaxLength(10)]
        [Required]
        public string Code { get; set; }

        [MaxLength(4000)]
        [Required]
        public string Subject { get; set; }

        [Required]
        public Guid CategoryId { get; set; }
        public virtual Category Category { get; set; }

        public Guid FileId { get; set; }
        public virtual File File { get; set; }

        [Required]
        [MaxLength(250)]
        public string writer { get; set; }



    }
}
