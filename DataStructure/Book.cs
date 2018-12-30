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
        [Required(ErrorMessage = "لطفا عنوان کتاب را وارد کنید")]
        [Display(Name = "عنوان")]
        public string Title { get; set; }

        [MaxLength(10)]
        [Required(ErrorMessage = "لطفا کد دسته بندی کتاب را وارد کنید")]
        [Display(Name = "کد کتاب")]
        public string Code { get; set; }

        [MaxLength(4000)]
        [Display(Name ="موضوع")]
        public string Subject { get; set; }

        [Required(ErrorMessage ="لطفا گروه کتاب را مشخص کنید")]
        [Display(Name ="گروه")]
        public Guid CategoryId { get; set; }
        public virtual Category Category { get; set; }

        [Display(Name ="تصویر کتاب")]
        public Guid FileId { get; set; }
        public virtual File File { get; set; }




    }
}
