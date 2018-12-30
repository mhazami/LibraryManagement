using LibraryManagement.DataStructure.Attribute;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.DataStructure
{
    public class Member
    {
        [Key]
        public Guid MemberId { get; set; }

        [Required(ErrorMessage = "لطفا نام را وارد کنید")]
        [Display(Name = "نام")]
        [MaxLength(150)]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "لطفا نام خانوادگی را وارد کنید")]
        [Display(Name = "نام خانوادگی")]
        [MaxLength(150)]
        public string LastName { get; set; }

        [IsNationalCode("کد ملی وارد شده نا معتبر میباشد")]
        [Display(Name = "کد ملی")]
        [Required(ErrorMessage = "لطفا کد ملی خود را وارد کنید")]
        public string NationalCode { get; set; }

        [Required(ErrorMessage = "لطفا تاریخ تولد را وارد کنید")]
        [Display(Name = "تاریخ تولد")]
        [MaxLength(10)]
        public string BirthDate { get; set; }

        public bool IsActive { get; set; }

        [MaxLength(10)]
        public string RegisteryDate { get; set; }

        [Required(ErrorMessage = "لطفا تلفن را وارد کنید")]
        [Display(Name = "تلفن")]
        [MaxLength(11)]
        public string Tel { get; set; }

        [Display(Name ="کد عضویت")]
        [MaxLength(18)]
        public string MemberCode { get; set; }

        [Required(ErrorMessage = "لطفا آدرس را وارد کنید")]
        [Display(Name = "آدرس")]
        [MaxLength(4000)]
        public string Address { get; set; }

        [Display(Name ="عکس")]
        public Guid FileId { get; set; }
        

    }
}
