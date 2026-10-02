using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_24_200_001.Model
{
	[DataContract]
	public class PTOBankApplicableEarningType : Entity
	{

		#region Fields
		[DataMember(Name="AccrueTimeOffBasedOn", EmitDefaultValue=false)]
		public StringValue? AccrueTimeOffBasedOn { get; set; }

		#endregion

		#region Details
		[DataMember(Name="ApplicableEarningTypeDetail", EmitDefaultValue=false)]
		public List<PTOBankApplicableEarningTypeDetail>? ApplicableEarningTypeDetail { get; set; }

		#endregion

	}
}