﻿using ALT_R_Management_Library.Models.Admin;
using ALT_R_Management_Library.Models.Auth;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace ALT_R_Management_Library.Api
{
    public class ALT_R_ApiProcessor
    {
        public string AuthToken { get; internal set; }
        public AdministratorModel AppUser { get; internal set; }

        public async Task<AutheticatedModel> AuthenticateUser(string username, string password)
        {
            var data = new FormUrlEncodedContent(new[]
            {
                new KeyValuePair<string,string>("grant_type","password"),
                new KeyValuePair<string,string>("username",username),
                new KeyValuePair<string,string>("password",password)
            });
            using (HttpResponseMessage response = await ALT_R_ApiHelper.ApiClient.PostAsync("http://localhost:60079/token", data))
            {
                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadAsAsync<AutheticatedModel>();
                    ALT_R_ApiHelper.ApiClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("bearer", result.Access_Token);
                    AuthToken = result.Access_Token;
                    return result;
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }

        }
        public  async Task<AdministratorModel> SignIn(string username, string password, string token)
        {
            using (HttpRequestMessage request = new HttpRequestMessage())
            {
                request.Method = HttpMethod.Get;
                request.RequestUri = new Uri($"http://localhost:60079/api/admin/gbe/{username}/{password}");
                request.Headers.Add("Authorization", $"bearer {token}");


                using (HttpResponseMessage response = await ALT_R_ApiHelper.ApiClient.SendAsync(request))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        var result = await response.Content.ReadAsAsync<AdministratorModel>();
                        AppUser = result;
                        return result;
                    }
                    else
                    {
                        throw new Exception(response.ReasonPhrase);
                    }
                }
            }

        }
        public async Task<List<AdministratorModel>> GetAllAdmins()
        {
            using (HttpRequestMessage request = new HttpRequestMessage())
            {
                request.Method = HttpMethod.Get;
                request.RequestUri = new Uri($"http://localhost:60079/api/admin/getall");
                request.Headers.Add("Authorization", $"bearer {AuthToken}");


                using (HttpResponseMessage response = await ALT_R_ApiHelper.ApiClient.SendAsync(request))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        var result = await response.Content.ReadAsAsync<List<AdministratorModel>>();
                        return result;
                    }
                    else
                    {
                        throw new Exception(response.ReasonPhrase);
                    }
                }
            }

        }

        public async Task<string> InsertAdmin(string firstname, string lastname, string gender, string role, string username, string email, string password, byte[] image)
        {


            using (HttpRequestMessage request = new HttpRequestMessage())
            {
                request.Method = HttpMethod.Post;
                request.RequestUri = new Uri($"http://localhost:60079/api/admin/ina/{firstname}/{lastname}/{gender}/{role}/{username}/{email}/{password}");
                request.Headers.Add("Authorization", $"bearer {AuthToken}");

                using (HttpResponseMessage response = await ALT_R_ApiHelper.ApiClient.PostAsync(request.RequestUri,new ByteArrayContent(image),new BsonMediaTypeFormatter()))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        return "Sucess";
                    }
                    else
                    {
                        throw new Exception(response.ReasonPhrase);
                    }
                }
            }

           

        }
    }
}
