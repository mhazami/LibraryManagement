using LibraryManagement.DAL;
using LibraryManagement.DataStructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.BLL
{
    public class Category : BusinessBase<DataStructure.Category>
    {
        public override bool Insert(DataStructure.Category obj)
        {
            obj.CategoryId = Guid.NewGuid();
            return base.Insert(obj);
        }


       

    }

   
}
