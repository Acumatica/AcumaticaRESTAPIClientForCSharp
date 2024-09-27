using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Manufacturing_23_100_001.Model
{
	/// <summary>
	/// Corresponds to the screen AM506000 in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class CloseProductionOrders : Entity, ITopLevelEntity
	{

		[DataMember(Name="Details", EmitDefaultValue=false)]
		public List<CloseProductionOrdersDetail>? Details { get; set; }

		/// <summary>
		/// DAC Field Name: FinancialPeriodID 
		/// DAC: PX.Objects.AM.FinancialPeriod 
		/// SQL Type: char(6) 
		/// </summary>
		[DataMember(Name="Period", EmitDefaultValue=false)]
		public StringValue? Period { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/MANUFACTURING/23.100.001";
		}
	}
}