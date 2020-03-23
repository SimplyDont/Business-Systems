using System.Collections.Generic;
using ALT_R_Management_Library.Models.Admin;

namespace ALT_R_WebApi.Models
{
    public interface ISqlDataAcess
    {
        List<T> GetAdmin<T>();
        T GetAdmin<T>(string email, string password);
        byte[] GetImage(string email);
        void InsertAdmin(string firstname, string lastname, string gender, string role, string username, string email, string password, byte[] image);
    }
}