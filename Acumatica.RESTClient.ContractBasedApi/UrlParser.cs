using System;
using System.Runtime.CompilerServices;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.FileApi.Model;
using Acumatica.RESTClient.ContractBasedApi.Model;

[assembly: InternalsVisibleTo("RESTClientTests")]
namespace Acumatica.RESTClient.Api
{

    internal static class UrlParser
    {
        private const string entityKeyword = "/entity/";
        private static readonly char[] pathSeparators = new char[] { '/' };

        public static ActionLocation ParseActionLocation(string location)
        {
            var result = new ActionLocation();

            int indexOfEntity = FindEntityKeyword(location);
            result.Site = location.Substring(0, indexOfEntity);

            string restOfLocation = location.Substring(indexOfEntity);
            var parts = restOfLocation.Split(pathSeparators, StringSplitOptions.RemoveEmptyEntries);

            VerifySegmentCount(parts, 4, location);

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
        public static ReportLocation ParseReportLocation(string location)
        {
            var result = new ReportLocation();

            int indexOfEntity = FindEntityKeyword(location);
            result.Site = location.Substring(0, indexOfEntity);

            string restOfLocation = location.Substring(indexOfEntity);
            var parts = restOfLocation.Split(pathSeparators, StringSplitOptions.RemoveEmptyEntries);

            VerifySegmentCount(parts, 7, location);

            result.ID = parts[parts.Length - 1];
            result.EndpointName = parts[1];
            result.EndpointVersion = parts[2];
            result.EntityName = parts[3];
            result.Locale = parts[5];
            result.Format = parts[6];


            return result;
        }


        public static FileLocation ParseFileLocation(string location)
        {
            var result = new FileLocation();

            int indexOfEntity = FindEntityKeyword(location);
            result.Site = location.Substring(0, indexOfEntity);

            string restOfLocation = location.Substring(indexOfEntity);
            var parts = restOfLocation.Split(pathSeparators, StringSplitOptions.RemoveEmptyEntries);

            VerifySegmentCount(parts, 3, location);

            result.ID = parts[parts.Length - 1];
            result.EndpointName = parts[1];
            result.EndpointVersion = parts[2];

            return result;
        }

        public static FilePutLocation ParseFilePutLocation(string location)
        {
            var result = new FilePutLocation();

            int indexOfEntity = FindEntityKeyword(location);
            result.Site = location.Substring(0, indexOfEntity);

            string restOfLocation = location.Substring(indexOfEntity);
            var parts = restOfLocation.Split(pathSeparators, StringSplitOptions.RemoveEmptyEntries);

            VerifySegmentCount(parts, 4, location);

            result.ID = parts[parts.Length - 2];
            result.ViewName = parts[parts.Length - 3];
            result.GraphType = parts[parts.Length - 4];
            result.EndpointName = parts[1];
            result.EndpointVersion = parts[2];

            return result;
        }


        private static int FindEntityKeyword(string location)
        {
            if (location == null)
                throw new ApiException(400, "Incorrect location: the value is null.");

            int indexOfEntity = location.IndexOf(entityKeyword, StringComparison.OrdinalIgnoreCase);

            if (indexOfEntity < 0)
                throw new ApiException(400, $"Incorrect location: '{location}' does not contain '{entityKeyword}'.");
            if (location.Substring(indexOfEntity + entityKeyword.Length).IndexOf(entityKeyword, StringComparison.OrdinalIgnoreCase) >= 0)
                throw new ApiException(400, $"Location '{location}' cannot be parsed as it contains more than 1 entity keyword");
            return indexOfEntity;
        }

        /// <summary>
        /// Verifies that the location has at least <paramref name="requiredCount"/> path segments
        /// before they are indexed, so a malformed or unexpected location reports what failed
        /// instead of throwing <see cref="IndexOutOfRangeException"/>.
        /// </summary>
        private static void VerifySegmentCount(string[] parts, int requiredCount, string location)
        {
            if (parts.Length < requiredCount)
                throw new ApiException(400, $"Location '{location}' cannot be parsed: expected at least {requiredCount} path segments after '{entityKeyword}' but found {parts.Length}.");
        }
    }
}