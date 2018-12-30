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

        public virtual DbSet<Member> Member { get; set; }

        public virtual DbSet<BookTranslator> BookTranslators { get; set; }

        public virtual DbSet<Setting> Settings { get; set; }

        public virtual DbSet<Borrow> Borrow { get; set; }

        public virtual DbSet<User> Users { get; set; }

        public virtual DbSet<UserRole> UserRoles { get; set; }

        public virtual DbSet<Role> Roles { get; set; }

        public virtual DbSet<Menu> Menus { get; set; }

        public virtual DbSet<RoleMenu> RoleMenus { get; set; }

    }
}
