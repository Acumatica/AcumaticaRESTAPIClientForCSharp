﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Acumatica.RESTClient.Api;
using Acumatica.RESTClient.Client;
using Acumatica.RESTClient;
using AcumaticaRestApiExample;
using Acumatica.Auth.Api;
using System.IO;
using Acumatica.Auth.Model;

namespace Acumatica_REST_API_Example_Console_Application
{
    public class CustomizationPublishingExample
    {
        public static void ImportAndPublishCustomization(string siteURL, string username, string password)
        {
            Console.WriteLine("Sign in");
            var authApi = new AuthApi(siteURL,
                requestInterceptor: RequestLogger.LogRequest,
                responseInterceptor: RequestLogger.LogResponse);
            var conf = authApi.LogIn(username, password);
            
            CustomizationApi customizationApi = new CustomizationApi(conf);

            Console.WriteLine("Import customization package");
            customizationApi.Import(new FileStream("endpoint.zip",FileMode.Open),"test");

            Console.WriteLine("Start Publishing");
            customizationApi.PublishBegin("test");

            Console.WriteLine("Wait");
            customizationApi.WaitPublishingCompletion();


            Console.WriteLine("Done!");

            Console.WriteLine("Logging out");
            authApi.TryLogout();

        }
    }
}
