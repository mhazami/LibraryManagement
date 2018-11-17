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

        [Required]
        public Guid MemberId { get; set; }
        public virtual Member Member { get; set; }

        [Required]
        public Guid BookId { get; set; }
        public virtual Book Book { get; set; }

        [Required]
        [MaxLength(10)]
        public string BorrowDate { get; set; }

        [Required]
        [MaxLength(10)]
        public string DeliveryDate { get; set; }

        
        [MaxLength(10)]
        public string ExtendedDate { get; set; }

        [MaxLength(10)]
        public string ExpirationDate { get; set; }

        public int PenaltyId { get; set; }
        public virtual Penalty Penalty { get; set; }

        public int Dealy { get; set; }


    }
}
