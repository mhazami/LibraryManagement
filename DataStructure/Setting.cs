using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.DataStructure
{
    public class Setting
    {
        [Key]
        public Guid Id { get; set; }

        [MaxLength(300)]
        [Display(Name = "رنگ پس زمینه")]
        public string Theme { get; set; }

        [Display(Name = "مبلغ امانت")]
        public decimal? FineAmount { get; set; }

        [Display(Name = "مبلغ جریمه")]

        public decimal? LoanAmount { get; set; }

        public int AuthorizedNumber { get; set; }
    }
}
