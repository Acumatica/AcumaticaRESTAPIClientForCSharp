using System;
using System.Runtime.CompilerServices;

using Acumatica.RESTClient.FileApi.Model;
using Acumatica.RESTClient.Model;

[assembly: InternalsVisibleTo("RESTClientTests")]
namespace Acumatica.RESTClient.Api
{

    internal static class UrlParser
    {
        private const string entityKeyword = "/entity/";
        private static char[] pathSeparators = new char[] { '/' };

        public static ActionLocation ParseActionLocation(string location)
        {
            var result = new ActionLocation();

            int indexOfEntity = FindEntityKeyword(location);
            result.Site = location.Substring(0, indexOfEntity);

            string restOfLocation = location.Substring(indexOfEntity);
            var parts = restOfLocation.Split(pathSeparators, StringSplitOptions.RemoveEmptyEntries);

            result.ID = parts[parts.Length - 1];
            result.EndpointName = parts[1];
            result.EndpointVersion = parts[2];
            result.EntityName = parts[3];
            if (parts.Length == 7)
            {
                result.ActionName = parts[4];
                result.Status = parts[5];
            }

            return result;
        }


        public static FileLocation ParseFileLocation(string location)
        {
            var result = new FileLocation();

            int indexOfEntity = FindEntityKeyword(location);
            result.Site = location.Substring(0, indexOfEntity);

            string restOfLocation = location.Substring(indexOfEntity);
            var parts = restOfLocation.Split(pathSeparators, StringSplitOptions.RemoveEmptyEntries);

            result.ID = parts[parts.Length - 1];
            result.EndpointName = parts[1];
            result.EndpointVersion = parts[2];

            return result;
        }

        private static int FindEntityKeyword(string location)
        {
            int indexOfEntity = location.IndexOf(entityKeyword, StringComparison.OrdinalIgnoreCase);

            if (indexOfEntity < 0)
                throw new Exception("Incorrect location");
            if (location.Substring(indexOfEntity + entityKeyword.Length).IndexOf(entityKeyword, StringComparison.OrdinalIgnoreCase) >= 0)
                throw new Exception("Location cannot be parsed as it contains more than 1 entity keyword");
            return indexOfEntity;
        }
    }
}