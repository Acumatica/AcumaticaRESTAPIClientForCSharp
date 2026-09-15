using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.eCommerce_24_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen <c>IN304000</c> in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class TransferOrder : Acumatica.Default_24_200_001.Model.TransferOrder, ITopLevelEntity
	{

		/// <summary>
		/// <para>DAC Field Name: BranchID</para>
		/// <para>DAC: PX.Objects.IN.INRegister</para>
		/// </summary>
		[DataMember(Name="Branch", EmitDefaultValue=false)]
		public StringValue? Branch { get; set; }

		public override string GetEndpointPath()
		{
			return "entity/eCommerce/24.200.001";
		}
	}
}