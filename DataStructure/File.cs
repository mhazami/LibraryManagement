﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.DataStructure
{
   public class File
    {
        [Key]
        public Guid FileId { get; set; }
        public byte[] Context { get; set; }

        [Required]
        [MaxLength(10)]
        public string ContextType { get; set; }

        [Required]
        [MaxLength(50)]
        public string Title { get; set; }

        [Required]
        public int FileSize { get; set; }
    }
}
