using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.eCommerce_22_200_001.Model
{
	[DataContract]
	public class EmploymentDates : Entity
	{

		[DataMember(Name="HireDate", EmitDefaultValue=false)]
		public DateTimeValue? HireDate { get; set; }

		[DataMember(Name="TerminationDate", EmitDefaultValue=false)]
		public DateTimeValue? TerminationDate { get; set; }

	}
}