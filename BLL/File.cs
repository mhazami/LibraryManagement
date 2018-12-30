using LibraryManagement.DAL;
using LibraryManagement.DataStructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace LibraryManagement.BLL
{
    public class File : BusinessBase<DataStructure.File>
    {
        public override bool Insert(DataStructure.File obj)
        {
            obj.FileId = Guid.NewGuid();
            return base.Insert(obj);
        }

        public DataStructure.File Insert(HttpPostedFileBase file)
        {
            var obj = new DataStructure.File();
            if (file != null)
            {
                obj.Context = new byte[file.ContentLength];
                file.InputStream.Read(obj.Context, 0, file.ContentLength);
                obj.ContextType = file.ContentType;
                obj.Title = file.FileName;
                obj.FileSize = file.ContentLength / 1024 / 1024;
            }
            if (this.Insert(obj))
                return obj;
            return null;

        }

        public override void CheckConstraint(DataStructure.File obj)
        {
            if (obj.FileSize > 1)
                throw new Exception("حجم فایل نمیتواند بیش از 1 مگا بایت باشد");
            if (!(obj.ContextType == "image/jpeg" || obj.ContextType == "image/png"))
                throw new Exception("نوع فایل آپلود شده نامعتبر میباشد");
        }

        public bool Update(HttpPostedFileBase file)
        {
            var obj = new DataStructure.File();
            if (file != null)
            {
                obj.Context = new byte[file.ContentLength];
                file.InputStream.Read(obj.Context, 0, file.ContentLength);
                obj.ContextType = file.ContentType;
                obj.Title = file.FileName;
                obj.FileSize = file.ContentLength / 1024 / 1024;
            }
            return this.Update(obj);
            
        }
    }
}