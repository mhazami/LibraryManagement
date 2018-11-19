using LibraryManagement.DAL;
using LibraryManagement.DataStructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.BLL
{
    public class CategoryBO : BusinessBase<Category>
    {
        public override bool Insert(Category obj)
        {
            obj.CategoryId = Guid.NewGuid();
            return base.Insert(obj);
        }

       

    }

   
}
