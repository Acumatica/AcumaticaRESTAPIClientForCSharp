using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.RESTClient.ContractBasedApi
{
    public interface ITopLevelEntity
    {
        /// <summary>
        /// Returns relative endpoint path startnig with <c>entity</c> keyword, 
        /// e.g. <c>entity/Default/22.200.001</c>
        /// </summary>
        string GetEndpointPath();
    }
}