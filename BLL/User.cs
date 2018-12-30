using LibraryManagement.DAL;
using LibraryManagement.DataStructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.BLL
{
    public class User : BusinessBase<DataStructure.User>
    {
        public override bool Insert(DataStructure.User obj)
        {
            obj.Id = Guid.NewGuid();
            return base.Insert(obj);
        }

        public override void CheckConstraint(DataStructure.User obj)
        {
            if ((!string.IsNullOrEmpty(obj.Password) || !string.IsNullOrEmpty(obj.ConfirmPassword)) && obj.Password != obj.ConfirmPassword)
                throw new Exception("رمز عبور و تکرار رمز عبور مطابقت ندارد");
            if (!string.IsNullOrEmpty(obj.Password))
                obj.Password = (obj.Password.GetHashCode()).ToString();
        }

        public bool CheckLogin(string username, string password)
        {
            if (!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(password))
            {
                var pass = (password.GetHashCode()).ToString();
                var user = this.FirstOrDefault(x => x.Username == username && x.Password == pass);
                return user != null;
            }
            return false;
        }

        public DataStructure.User Login(string username, string password)
        {
            if (!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(password))
            {
                var pass = (password.GetHashCode()).ToString();
                var user = this.FirstOrDefault(x => x.Username == username && x.Password == pass);
                return user;
            }
            return null;
        }
    }
}
