using System.Net.Http;
using System.Threading.Tasks;

using Acumatica.RESTClient.Api;
using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.RootApi.Model;


namespace Acumatica.RESTClient.RootApi
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public static class RootApi 
    {
        #region Public Methods

        /// <summary>
        /// Returns the version of the Acumatica ERP instance and the endpoints available in this instance. 
        /// Available stating from 2019 R2 version of Acumatica ERP.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <returns>VersionAndEndpoints</returns>
        public static VersionAndEndpoints RootGet(this ApiClient client)
        {
            return RootGetAsyncWithHttpInfo(client).Result;
        }
        /// <summary>
        /// Returns the version of the Acumatica ERP instance and the endpoints available in this instance. 
        /// Available stating from 2019 R2 version of Acumatica ERP.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of VersionAndEndpoints</returns>
        public static async Task<VersionAndEndpoints> RootGetAsync(this ApiClient client)
        {
            return await RootGetAsyncWithHttpInfo(client);

        }
        #endregion

        #region Implementation
        /// <summary>
        /// Returns the version of the Acumatica ERP instance and the endpoints available in this instance. 
        /// Available stating from 2019 R2 version of Acumatica ERP.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of VersionAndEndpoints</returns>
        private static async Task<VersionAndEndpoints> RootGetAsyncWithHttpInfo(ApiClient client)
        {
            HttpResponseMessage localVarResponse = await client.CallApiAsync(
                "/entity",
                HttpMethod.Get,
                null,
                null, 
                HeaderContentType.Json | HeaderContentType.Xml,     
                HeaderContentType.None);

            client.VerifyResponse(localVarResponse, "RootGet");

            return client.DeserializeResponse<VersionAndEndpoints>(localVarResponse);
        }
        #endregion
    }
}
