using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.DataStructure
{
    public class Borrow
    {
        [Key]
        public Guid BorrowId { get; set; }

        [Required(ErrorMessage = "لطفا امانت گیرنده را مشخص کنید")]
        [Display(Name = "امانت گیرنده")]
        public Guid MemberId { get; set; }
        public virtual Member Member { get; set; }

        [Required(ErrorMessage ="لطفا کتاب امانت گرفته شده را مشخص کنید")]
        [Display(Name ="کتاب")]
        public Guid BookId { get; set; }
        public virtual Book Book { get; set; }

        [Required(ErrorMessage ="لطفا تاریخ به امانت گرفته شدن کتاب را مشخص کنید")]
        [Display(Name ="از تاریخ")]
        [MaxLength(10)]
        public string BorrowDate { get; set; }

        [Display(Name ="تا بازگشت")]
        [MaxLength(10)]
        public string DeliveryDate { get; set; }


        [MaxLength(10)]
        [Display(Name ="تاریخ تمدید")]
        public string ExtendedDate { get; set; }

        [Required(ErrorMessage ="لطفا تاریخ بازگشت امانت را مشخص کنید")]
        [Display(Name ="تا تاریخ")]
        [MaxLength(10)]
        public string ExpirationDate { get; set; }

        public decimal? Penalty { get; set; }
       



    }
}
