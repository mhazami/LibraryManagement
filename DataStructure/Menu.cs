using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.DataStructure
{
    public class Menu
    {
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "عنوان منو را وارد کنید")]
        [MaxLength(50)]
        public string Title { get; set; }

        public Int16 Order { get; set; }

        public Guid ParentId { get; set; }
        public Menu Parent { get; set; }

        
        public bool IsActive { get; set; }

        public bool Disable { get; set; }

        [Required(ErrorMessage ="آدرس منو را وارد کنید")]
        [MaxLength(400)]
        public string Url { get; set; }
    }
}
