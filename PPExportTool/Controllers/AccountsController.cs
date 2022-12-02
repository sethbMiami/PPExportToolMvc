﻿using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using PracticePanther.Api.Model;
using System.Web.Http;
using HttpGetAttribute = System.Web.Http.HttpGetAttribute;

namespace PPExportTool.Controllers
{
    public class AccountsController : Controller
    {
        public IActionResult Secure()
        {
            return View();
        }

        public IActionResult Login(string returnUrl = "/")
        {
            return Challenge(new AuthenticationProperties() { RedirectUri = returnUrl });
        }

        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();
            return Redirect(Url.Content("/Home"));
        }

        [HttpGet]
        public async Task<IActionResult> AccountsData()
        {
            if (!User.Identity.IsAuthenticated)
            {
                return View("Secure");
            }
            else
            {
                var authenticationInfo = await HttpContext.AuthenticateAsync();

                var accessToken = authenticationInfo.Properties.GetTokenValue("access_token");
                var refreshToken = authenticationInfo.Properties.GetTokenValue("refresh_token");
                var expiresAt = DateTimeOffset.Parse(authenticationInfo.Properties.GetTokenValue("expires_at"));

                var client = new HttpClient();
                client.DefaultRequestHeaders.Add("Authorization", $"Bearer {accessToken}");
                var response = await client.GetAsync("https://app.practicepanther.com/api/v2/accounts");

                List<Account> accountsList = new List<Account>();

                var accounts = await response.Content.ReadAsStringAsync();

                string jsonString = accounts;


                accountsList = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Account>>(jsonString);

                ViewData["Account"] = accountsList;

                return View();
            }
        }

        [HttpGet]
        public async Task<IActionResult> ContactsData()
        {
            if (!User.Identity.IsAuthenticated)
            {
                return View("Secure");
            }
            else
            {
                var authenticationInfo = await HttpContext.AuthenticateAsync();

                var accessToken = authenticationInfo.Properties.GetTokenValue("access_token");
                var refreshToken = authenticationInfo.Properties.GetTokenValue("refresh_token");
                var expiresAt = DateTimeOffset.Parse(authenticationInfo.Properties.GetTokenValue("expires_at"));

                var client = new HttpClient();
                client.DefaultRequestHeaders.Add("Authorization", $"Bearer {accessToken}");
                var response = await client.GetAsync("https://app.practicepanther.com/api/v2/contacts");

                List<Contact> contactsList = new List<Contact>();

                var contacts = await response.Content.ReadAsStringAsync();

                string jsonString = contacts;


                contactsList = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Contact>>(jsonString);

                ViewData["Contact"] = contactsList;

                return View();
            }
        }

    }
}

//var authenticationInfo = await HttpContext.AuthenticateAsync();

//var accessToken = authenticationInfo.Properties.GetTokenValue("access_token");
//var refreshToken = authenticationInfo.Properties.GetTokenValue("refresh_token");
//var expiresAt = DateTimeOffset.Parse(authenticationInfo.Properties.GetTokenValue("expires_at"));

//var client = new HttpClient();
//client.DefaultRequestHeaders.Add("Authorization", $"Bearer {accessToken}");
//var response = await client.GetAsync("https://app.practicepanther.com/api/v2/accounts");
//var accounts = await response.Content.ReadAsStringAsync();


