using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.DataStructure
{
    public class BookTranslator
    {
        [Key, Column(Order = 0)]
        public Guid BookId { get; set; }
        public Book Book { get; set; }


        [Key, Column(Order = 1)]
        public Guid TranslatorId { get; set; }
        public Translator Translator { get; set; }

    }
}
