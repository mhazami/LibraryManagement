﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace LibraryManagement.DataStructure.ViewModels
{
    public class BookFileViewModel
    {
        public Book Book{ get; set; }

        public HttpPostedFileBase File { get; set; }
    }
}
