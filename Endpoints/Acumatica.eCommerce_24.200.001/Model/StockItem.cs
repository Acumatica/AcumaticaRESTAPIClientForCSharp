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
	/// Corresponds to the screen <c>IN202500</c> in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class StockItem : Acumatica.Default_24_200_001.Model.StockItem, ITopLevelEntity
	{

		/// <summary>
		/// APS Schedule option - Check for Material Availability.
		/// <para>DAC: PX.Objects.IN.InventoryItem</para>
		/// <para>Display Name: Check for Material Availability</para>
		/// </summary>
		[DataMember(Name="AMCheckSchdMatlAvailability", EmitDefaultValue=false)]
		public StringValue? AMCheckSchdMatlAvailability { get; set; }

		public override string GetEndpointPath()
		{
			return "entity/eCommerce/24.200.001";
		}
	}
}