using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.DataStructure
{
    public class Author
    {
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "لطفا نام نویسنده را وارد کنید")]
        [Display(Name = "نام")]
        [MaxLength(150)]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "لطفا نام خانوادگی نویسنده را وارد کنید")]
        [Display(Name = "نام خانوادگی")]
        [MaxLength(150)]
        public string LastName { get; set; }

        [MaxLength(100)]
        [Display(Name = "ملیت")]
        public string Country { get; set; }


    }
}
