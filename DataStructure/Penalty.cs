using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.DataStructure
{
    public class Penalty
    {
        [Key]
        public int PenaltyId { get; set; }

        [Required]
        [MaxLength(5)]
        public string From { get; set; }

        [Required]
        [MaxLength(5)]
        public string To { get; set; }

        [Required]
        public decimal Amount { get; set; }


    }
}
