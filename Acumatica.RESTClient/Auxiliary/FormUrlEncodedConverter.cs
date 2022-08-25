using System.Collections.Generic;
using System.Net.Http;

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
