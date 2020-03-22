using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALT_R_Management_Library.Models.Auth
{
    public class AutheticatedModel
    {
        public string Access_Token { get; set; }
        public string Username { get; set; }
        public string Refresh_Token { get; set; }
    }
}
