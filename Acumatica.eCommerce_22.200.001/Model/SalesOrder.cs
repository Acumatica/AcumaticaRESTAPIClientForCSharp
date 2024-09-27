using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.eCommerce_22_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen SO301000 in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class SalesOrder : Acumatica.Default_22_200_001.Model.SalesOrder, ITopLevelEntity
	{

		[DataMember(Name="MaxRiskScore", EmitDefaultValue=false)]
		public DecimalValue? MaxRiskScore { get; set; }

		[DataMember(Name="OrderRisks", EmitDefaultValue=false)]
		public List<OrderRisks>? OrderRisks { get; set; }

		/// <summary>
		/// The identifier of the branch.The field is included in the Branch foreign key.
		/// DAC Field Name: BranchID 
		/// DAC: PX.Objects.SO.SOOrder 
		/// </summary>
		[DataMember(Name="Branch", EmitDefaultValue=false)]
		public StringValue? Branch { get; set; }

		public override string GetEndpointPath()
		{
			return "entity/eCommerce/22.200.001";
		}
	}
}