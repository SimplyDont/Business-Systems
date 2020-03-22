using System;
using System.Web.Http;
using ALT_R_WebApi.Sql;
using Microsoft.Owin;
using Microsoft.Owin.Security.OAuth;
using Owin;

[assembly: OwinStartup(typeof(ALT_R_WebApi.Startup))]

namespace ALT_R_WebApi
{
    public class Startup
    {
        
        public void Configuration(IAppBuilder app)
        {
            // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=316888
            app.UseCors(Microsoft.Owin.Cors.CorsOptions.AllowAll);
            var _provider = new Authentication.ALT_RAuthorizationProvider();
            OAuthAuthorizationServerOptions _options = new OAuthAuthorizationServerOptions()
            {

                AccessTokenExpireTimeSpan = TimeSpan.FromDays(1),
                AllowInsecureHttp=true,
                TokenEndpointPath=new PathString("/token"),
                Provider=_provider,
                RefreshTokenProvider=new Authentication.ALT_RRefreshTokenProvider()
            };
            app.UseOAuthAuthorizationServer(_options);
            app.UseOAuthBearerAuthentication(new OAuthBearerAuthenticationOptions());
            HttpConfiguration _configuration = new HttpConfiguration();
            WebApiConfig.Register(_configuration);
        }
    }
}
