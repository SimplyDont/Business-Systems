using System.Collections.Generic;
using ALT_R_Management_Library.Models.Admin;

namespace ALT_R_WebApi.Models
{
    public interface ISqlDataAcess
    {
        List<T> GetAdmin<T>();
        T GetAdmin<T>(string email, string password);
        void InsertAdmin(IAdministrator admin);
    }
}