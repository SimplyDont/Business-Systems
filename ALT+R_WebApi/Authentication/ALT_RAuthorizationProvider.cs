using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;
using ALT_R_WebApi.Sql;
using Microsoft.Owin;
using Microsoft.Owin.Security;
using Microsoft.Owin.Security.OAuth;
using ALT_R_WebApi.Models;
using ALT_R_Management_Library.Models.Admin;

namespace ALT_R_WebApi.Authentication
{
    public class ALT_RAuthorizationProvider:OAuthAuthorizationServerProvider
    {
        
        public override async Task ValidateClientAuthentication(OAuthValidateClientAuthenticationContext context)
        {
            
                context.Validated();

            
        }
        public override Task GrantRefreshToken(OAuthGrantRefreshTokenContext context)
        {

            // Change authentication ticket for refresh token requests  
            var newIdentity = new ClaimsIdentity(context.Ticket.Identity);
            newIdentity.AddClaim(new Claim("newClaim", "newValue"));

            var newTicket = new AuthenticationTicket(newIdentity, context.Ticket.Properties);
            context.Validated(newTicket);

            return Task.FromResult<object>(null);

        }
        public override async Task GrantResourceOwnerCredentials(OAuthGrantResourceOwnerCredentialsContext context)
        {
            SqlDataAcess sqlDataAcess = new SqlDataAcess();
            try
            {
                var identity = new ClaimsIdentity(context.Options.AuthenticationType);
                var admin = sqlDataAcess.GetAdmin<AdministratorModel>(context.UserName, context.Password);
                if (!(admin == null))
                {
                    identity.AddClaim(new Claim(ClaimTypes.Role, admin.Role));
                    identity.AddClaim(new Claim("Username", admin.EmailAddress));
                    identity.AddClaim(new Claim(ClaimTypes.Name, $"{admin.FirstName} {admin.LastName}"));
                    var prinicipal = new ClaimsPrincipal(identity);
                    context.Validated(identity);
                }
            }
            catch
            {
                context.SetError("invalid_grant", "The user name or password is incorrect.");
                return;
            }
            
        }
    }
}