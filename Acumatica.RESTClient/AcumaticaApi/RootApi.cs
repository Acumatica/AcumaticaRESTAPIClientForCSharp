using System;
using System.Threading.Tasks;

using Acumatica.Auth.Model;
using Acumatica.RESTClient.Api;
using Acumatica.RESTClient.Client;

using RestSharp;

namespace Acumatica.Auth.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class RootApi : BaseApi
    {
        #region Constructor
        /// <summary>
        /// Initializes a new instance of the <see cref="RootApi"/> class.
        /// </summary>
        /// <returns></returns>
        public RootApi(String basePath) : base(basePath)
        { }

        /// <summary>
        /// Initializes a new instance of the <see cref="RootApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public RootApi(Configuration configuration) : base(configuration)
        { }
		#endregion

		#region Public Methods

		/// <summary>
		/// Returns the version of the Acumatica ERP instance and the endpoints available in this instance. 
		/// Available stating from 2019 R2 version of Acumatica ERP.
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <returns>VersionAndEndpoints</returns>
		public VersionAndEndpoints RootGet()
        {
            return 
               RootGetAsync()
            .GetAwaiter().GetResult();
        }
        /// <summary>
        /// Returns the version of the Acumatica ERP instance and the endpoints available in this instance. 
        /// Available stating from 2019 R2 version of Acumatica ERP.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of VersionAndEndpoints</returns>
        public async Task<VersionAndEndpoints> RootGetAsync()
        {
            ApiResponse<VersionAndEndpoints> localVarResponse = await RootGetWithHttpInfoAsync();
            return localVarResponse.Data;
        }
		#endregion

		#region Implementation
        /// <summary>
        /// Returns the version of the Acumatica ERP instance and the endpoints available in this instance. 
        /// Available stating from 2019 R2 version of Acumatica ERP.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (VersionAndEndpoints)</returns>
        protected async Task<ApiResponse<VersionAndEndpoints>> RootGetWithHttpInfoAsync()
        {
            var localVarPath = "/entity";
           
            // make the HTTP request
            RestResponse localVarResponse = (RestResponse)await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.Get, ComposeEmptyQueryParams(), null, ComposeAcceptHeaders(HeaderContentType.Json | HeaderContentType.Xml), ComposeEmptyFormParams(), ComposeEmptyFileParams(),
                ComposeEmptyPathParams(), ComposeContentHeaders(HeaderContentType.None));
           
            VerifyResponse(localVarResponse, "RootGet");

            return DeserializeResponse<VersionAndEndpoints>(localVarResponse);
        }
        #endregion
    }
}
