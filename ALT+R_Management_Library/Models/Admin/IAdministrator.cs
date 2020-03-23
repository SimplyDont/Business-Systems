using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALT_R_Management_Library.Models.Admin
{
    public interface IAdministrator
    {
        int AdminID {get; set;}
        string FirstName { get; set; }
        string LastName { get; set; }
        string Gender { get; set; }
        string Role { get; set; }
        string Username { get; set; }
        string EmailAddress { get; set; }
        byte[] Password { get; set; }
        byte[] Image { get; set; }

        byte[] GetImage(string email);
        IAdministrator GetAdministrator(string emailaddress, string password);
        IEnumerable<IAdministrator> GetAllAdministrators();
        void InsertAdministrator(string firstname, string lastname, string gender, string role, string username, string email, string password, byte[] image);
        void DeleteAdministrator(int adminID);
        void DeleteAdministrator(string emailaddress,string password);
        void UpdateAdministrator(IAdministrator administrator);

    }
}
