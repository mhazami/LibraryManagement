using LibraryManagement.DataStructure;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.DAL
{
    public class ConnectionHandler : DbContext
    {
        public ConnectionHandler() : base("name=LibraryManagementConnectionString") { }

        public virtual DbSet<Book> Book { get; set; }

        public virtual DbSet<Category> Category { get; set; }

        public virtual DbSet<File> File { get; set; }


    }
}
