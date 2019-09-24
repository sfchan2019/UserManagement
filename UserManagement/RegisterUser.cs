using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net.Http;
using System.Net.Http.Headers;
using UserManagement.Models;

namespace UserManagement
{
    public class RegisterUser
    {
        public static string post(Login register)
        {
            string success;
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:44317/api");
                var postUserResult = client.PostAsXmlAsync("user", register);
                postUserResult.Wait();
                var result = postUserResult.Result;

                if (result.IsSuccessStatusCode)
                {
                    success = "true";
                }
                else {
                    success = "false";
                }

            }
            return success;
        }
        
    }
}