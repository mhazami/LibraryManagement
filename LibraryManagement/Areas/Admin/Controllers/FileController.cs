using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LibraryManagement.WebApp.Areas.Admin.Controllers
{
    public class FileController : Controller
    {
        public FileResult ImageHandler(Guid? fileId)
        {
            var bo = new BLL.File();
            var file = bo.FirstOrDefault(x => x.FileId == fileId);
            return File(file.Context, file.ContextType, file.Title);
        }
    }
}