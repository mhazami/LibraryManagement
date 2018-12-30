using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.DataStructure
{
    public class Translator
    {
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage ="لطفا نام مترجم را وارد کنید")]
        [Display(Name ="نام")]
        [MaxLength(150)]
        public string FirstName { get; set; }

        [Required(ErrorMessage ="لطفا نام خانوادگی مترجم را وارد کنید")]
        [MaxLength(150)]
        [Display(Name ="نام خانوادگی")]
        public string LastName { get; set; }

        [MaxLength(100)]
        [Display(Name ="ملیت")]
        public string Country { get; set; }
    }
}
