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

        public byte[] GetImage(string email)
        {
            var p = new
            {
                email = email
            };
            return SqlHelper.GetData<byte[],dynamic>("GetImageByEmail", "TestCon",p).FirstOrDefault();

        }

        public void InsertAdmin(string firstname,string lastname, string gender, string role,string username,string email,string password,byte[] image)
        {
            var p = new
            {
                firstname= firstname,
                lastname=lastname,
                gender=gender,
                role=role,
                username=username,
                email=email,
                password=password,
                image = image
            };
             SqlHelper.SaveData<dynamic>("InsertAdmin", "TestCon", p);
        }
    }
}
