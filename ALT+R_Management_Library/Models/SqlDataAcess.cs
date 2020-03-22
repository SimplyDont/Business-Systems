using ALT_R_Management_Library.Models.Admin;
using ALT_R_WebApi.Sql.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALT_R_WebApi.Models
{
    public class SqlDataAcess : ISqlDataAcess
    {
        public T GetAdmin<T>(string email, string password)
        {
            var p = new
            {
                email = email,
                password = password
            };
            return SqlHelper.GetData<T,dynamic>("GetAdmin", "TestCon", p).FirstOrDefault();
        }
        public List<T> GetAdmin<T>()
        {
            return SqlHelper.GetData<T>("GetAllAdmins", "TestCon").ToList();
        }

        public void InsertAdmin(IAdministrator admin)
        {
            var p = new
            {
                firstname=admin.FirstName,
                lastname=admin.LastName,
                gender=admin.Gender,
                role=admin.Role,
                username=admin.Username,
                email=admin.EmailAddress,
                password=Encoding.ASCII.GetString(admin.Password),
                image=admin.Image
            };
             SqlHelper.SaveData<dynamic>("InsertAdmin", "TestCon", p);
        }
    }
}
