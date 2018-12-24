using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.DataStructure
{
    public class RoleMenu
    {
        [Key,Column(Order =0)]
        public Guid RoleId { get; set; }
        public Role Role { get; set; }

        [Key,Column(Order =1)]
        public Guid MenuId { get; set; }
        public Menu Menu { get; set; }
    }
}
