using LibraryManagement.DataStructure.Attribute;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.DataStructure
{
    public class User
    {
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "لطفا نام خود را وارد کنید")]
        [MaxLength(50)]
        [Display(Name = "نام")]
        public string FirstName { get; set; }

        [MaxLength(50)]
        [Display(Name = "نام خانوادگی")]
        [Required(ErrorMessage = "لطفا نام خانوادگی خود را وارد کنید")]
        public string LastName { get; set; }

        [MaxLength(10)]
        [Display(Name = "تاریخ تولد")]
        public string BirthDay { get; set; }

        [Display(Name = "کد ملی")]
        [Required(ErrorMessage = "لطفا کد ملی خود را وارد کنید")]
        [MaxLength(10)]
        [IsNationalCode("لطفا کد ملی را وارد کنید")]
        public string NationalCode { get; set; }

        [Display(Name = "عکس")]
        public Guid FileId { get; set; }
        public File File { get; set; }

        [Required(ErrorMessage = "لطفا نام کاربری را وارد کنید")]
        [Display(Name = "نام کاربری")]
        [MaxLength(150)]
        public string Username { get; set; }

        [Required(ErrorMessage = "لطفا رمز عبور را وارد کنید")]
        [Display(Name = "رمز عبور")]
        public string Password { get; set; }

        #region temp
        [NotMapped]
        public string ConfirmPassword { get; set; }
        #endregion temp
    }
}
