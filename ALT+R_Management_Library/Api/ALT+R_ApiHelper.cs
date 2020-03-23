using ALT_R_Management_Library.Models.Auth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using ALT_R_Management_Library.Models.Admin;
using System.Net.Http.Headers;

namespace ALT_R_Management_Library.Api
{
    public static class ALT_R_ApiHelper
    {
        //Http Client only needs one port open per application 
        public static HttpClient ApiClient { get; set; }

        public static void IntializeClient()
        {
            ApiClient = new HttpClient();
            ApiClient.DefaultRequestHeaders.Accept.Clear();
            ApiClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            ApiClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/bson"));

        }



    }
}
