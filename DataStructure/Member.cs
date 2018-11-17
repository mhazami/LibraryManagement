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

        [Required]
        [MaxLength(150)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(150)]
        public string LastName { get; set; }

        [Required]
        [MaxLength(10)]
        public string BirthDate { get; set; }

        public bool IsActive { get; set; }

        [Required]
        [MaxLength(10)]
        public string RegisteryDate { get; set; }

        [Required]
        [MaxLength(11)]
        public string Tel { get; set; }

        [Required]
        [MaxLength(4000)]
        public string Address { get; set; }
    }
}
