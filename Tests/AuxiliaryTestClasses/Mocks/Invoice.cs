using System.Runtime.Serialization;

using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace RESTClientTests.Mocks
{
    /// <summary>
    /// A document with a date-only field (<c>DateOnlyValue</c>), as in the 26.200.001 endpoint.
    /// </summary>
    public class Invoice : Entity, ITopLevelEntity
    {
        [DataMember(Name = "Date", EmitDefaultValue = false)]
        public DateOnlyValue? Date { get; set; }

        public virtual string GetEndpointPath()
        {
            return "entity/Default/26.200.001";
        }
    }
}
