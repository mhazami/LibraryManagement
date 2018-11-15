using LibraryManagement.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.BLL.Base
{
    public class BusinessBase<T> where T : class
    {
        private ConnectionHandler db;

        public BusinessBase()
        {
            db = new ConnectionHandler();
        }
    }
}
