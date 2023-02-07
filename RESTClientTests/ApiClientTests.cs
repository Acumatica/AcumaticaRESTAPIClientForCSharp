using System.Collections.Generic;
using System.Threading.Tasks;

using Acumatica.RESTClient.Auth;
using Acumatica.RESTClient.Client;

using RestSharp;

using Xunit;

namespace RESTClientTests
{
	internal class ApiClientMock : ApiClient
	{
		public ApiClientMock(Session session) : base(session)
		{ 

		}
		public override async Task<RestResponse> CallApiAsync(string path, Method method, List<KeyValuePair<string, string>> queryParams, object postBody, Dictionary<string, string> headerParams, Dictionary<string, string> formParams, Dictionary<string, FileParameter> fileParams, Dictionary<string, string> pathParams, string contentType)
		{
			return CallApi();
		}
		private RestResponse CallApi()
		{
            var response = new RestResponse();
            response.StatusCode = System.Net.HttpStatusCode.NotFound;
            return response;
        }

	}
	public class ApiClientTests
	{
		[Fact]
		public void ThrowsAnApiException()
		{
			var authApi = new AuthApi("http://test.org");
			authApi.Session._apiClient = new ApiClientMock(authApi.Session);

            Assert.Throws<ApiException>(()=>authApi.LogIn("admin", "123"));
		}
	}
}
