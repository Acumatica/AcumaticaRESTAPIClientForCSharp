using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Http;
using System.Text;

using Newtonsoft.Json.Linq;

namespace Acumatica.RESTClient.Auxiliary
{
    public static class FormUrlEncodedConverter
    {
        public static string ToFormUrlEncoded(IDictionary<string, string> keyValueContent)
        {
            var formUrlEncodedContent = new FormUrlEncodedContent(keyValueContent);
            var result = formUrlEncodedContent.ReadAsStringAsync().Result;
            return result;
        }
    }
}
