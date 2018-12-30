using LibraryManagement.DAL;
using LibraryManagement.DataStructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.BLL
{
    public class Borrow : BusinessBase<DataStructure.Borrow>
    {
        public override bool Insert(DataStructure.Borrow obj)
        {
            obj.BookId = Guid.NewGuid();
            return base.Insert(obj);
        }
    }
}
