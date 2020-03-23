using ALT_R_WebApi.Sql;
using ALT_R_WebApi.Sql.Internal;
using ALT_R_WebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ALT_R_Management_Library.Models.Admin
{
    public class AdministratorModel : IAdministrator
    {
        public int AdminID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public string Role { get; set; }
        public string Username { get; set; }
        public string EmailAddress { get; set; }
        public byte[] Password { get; set; }
        public byte[] Image { get; set; }

        private ISqlDataAcess sqlData=new SqlDataAcess();
 

        public void DeleteAdministrator(int adminID)
        {
            throw new NotImplementedException();
        }

        public void DeleteAdministrator(string emailaddress, string password)
        {
            throw new NotImplementedException();
        }

        public IAdministrator GetAdministrator(string emailaddress, string password)
        {
            return sqlData.GetAdmin<AdministratorModel>(emailaddress, password);
        }

        public IEnumerable<IAdministrator> GetAllAdministrators()
        {
            return sqlData.GetAdmin<AdministratorModel>();

        }

        public void InsertAdministrator(string firstname, string lastname, string gender, string role, string username, string email, string password, byte[] image)
        {
            sqlData.InsertAdmin(firstname, lastname, gender, role, username, email, password, image);
        }

        public void UpdateAdministrator(IAdministrator administrator)
        {
            throw new NotImplementedException();
        }

        public byte[] GetImage(string email)
        {
            return sqlData.GetImage(email);
        }
    }
}