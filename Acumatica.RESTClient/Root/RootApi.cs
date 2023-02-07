using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.Root.Model;

using RestSharp;

namespace Acumatica.RESTClient.Root
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
        public RootApi(string basePath) : base(basePath)
        { }

        /// <summary>
        /// Initializes a new instance of the <see cref="RootApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="Session">An API session</param>
        /// <returns></returns>
        public RootApi(Session Session) : base(Session)
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
            ApiResponse<VersionAndEndpoints> localVarResponse = RootGetWithHttpInfo();
            return localVarResponse.Data;
        }
        /// <summary>
        /// Returns the version of the Acumatica ERP instance and the endpoints available in this instance. 
        /// Available stating from 2019 R2 version of Acumatica ERP.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of VersionAndEndpoints</returns>
        public async System.Threading.Tasks.Task<VersionAndEndpoints> RootGetAsync()
        {
            ApiResponse<VersionAndEndpoints> localVarResponse = await RootGetAsyncWithHttpInfo();
            return localVarResponse.Data;

        }
        #endregion

        #region Implementation
        /// <summary>
        /// Returns the version of the Acumatica ERP instance and the endpoints available in this instance. 
        /// Available stating from 2019 R2 version of Acumatica ERP.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of VersionAndEndpoints</returns>
        protected ApiResponse<VersionAndEndpoints> RootGetWithHttpInfo()
        {
            var localVarPath = "/entity";

            // make the HTTP request
            RestResponse localVarResponse = Session.ApiClient.CallApiAsync(localVarPath,
                Method.Get, ComposeEmptyQueryParams(), null, ComposeAcceptHeaders(HeaderContentType.Xml | HeaderContentType.Json), ComposeEmptyFormParams(), ComposeEmptyFileParams(),
                ComposeEmptyPathParams(), ComposeContentHeaders(HeaderContentType.None)).Result;

            VerifyResponse(localVarResponse, "RootGet");

            return DeserializeResponse<VersionAndEndpoints>(localVarResponse);
        }

        /// <summary>
        /// Returns the version of the Acumatica ERP instance and the endpoints available in this instance. 
        /// Available stating from 2019 R2 version of Acumatica ERP.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (VersionAndEndpoints)</returns>
        protected async System.Threading.Tasks.Task<ApiResponse<VersionAndEndpoints>> RootGetAsyncWithHttpInfo()
        {
            var localVarPath = "/entity";

            // make the HTTP request
            RestResponse localVarResponse = await Session.ApiClient.CallApiAsync(localVarPath,
                Method.Get, ComposeEmptyQueryParams(), null, ComposeAcceptHeaders(HeaderContentType.Json | HeaderContentType.Xml), ComposeEmptyFormParams(), ComposeEmptyFileParams(),
                ComposeEmptyPathParams(), ComposeContentHeaders(HeaderContentType.None));

            VerifyResponse(localVarResponse, "RootGet");

            return DeserializeResponse<VersionAndEndpoints>(localVarResponse);
        }
        #endregion
    }
}
