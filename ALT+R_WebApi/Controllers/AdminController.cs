using ALT_R_Management_Library.Models.Admin;
using ALT_R_WebApi.Authentication;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web;
using System.Web.Http;

namespace ALT_R_WebApi.Controllers
{
    [ALT_RAuthorization]
    [RoutePrefix("api/admin")]
    public class AdminController : ApiController
    {
        private IAdministrator administrator;

        public AdminController(IAdministrator administrator_)
        {
            administrator = administrator_;
        }
        // GET: api/Admin
        [Route("getall")]
        [HttpGet]
        public IEnumerable<IAdministrator> GetAll()
        {
            return administrator.GetAllAdministrators();
        }

        // GET: api/Admin/5
        [AllowAnonymous]
        [HttpGet]
        [Route("gbe/{email}/{password}")]
        
        public IAdministrator GetByEmail(string email,string password)
        {
            return administrator.GetAdministrator(email,password);
        }

        // POST: api/Admin
        [ALT_RAuthorization(Roles = "Database Manager")]
        [Route("insertadmin")]
        [HttpPost]
        public void InsertAdmin([FromBody] IAdministrator administrator)
        {
            administrator.InsertAdministrator(administrator);
        }

        // PUT: api/Admin/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Admin/5
        [ALT_RAuthorization(Roles = "Database Manager")]
        [Route("deleteadmin")]
        [HttpDelete]
        public void Delete()
        {
            var _email = HttpContext.Current.Request.Form["email"];
            var _password = HttpContext.Current.Request.Form["password"];

            administrator.DeleteAdministrator(_email, _password);
        }
    }
}
