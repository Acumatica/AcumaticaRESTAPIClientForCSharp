using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_23_200_001.Model
{
	[DataContract]
	public class ShippingTermDetail : Entity
	{

		/// <summary>
		/// DAC: PX.Objects.CS.ShipTermsDetail 
		/// Display Name: Break Amount 
		/// </summary>
		[DataMember(Name="BreakAmount", EmitDefaultValue=false)]
		public DecimalValue? BreakAmount { get; set; }

		/// <summary>
		/// DAC Field Name: FreightCostPercent 
		/// DAC: PX.Objects.CS.ShipTermsDetail 
		/// Display Name: Freight Cost % 
		/// </summary>
		[DataMember(Name="FreightCost", EmitDefaultValue=false)]
		public DecimalValue? FreightCost { get; set; }

		/// <summary>
		/// DAC Field Name: InvoiceAmountPercent 
		/// DAC: PX.Objects.CS.ShipTermsDetail 
		/// Display Name: Invoice Amount % 
		/// </summary>
		[DataMember(Name="InvoiceAmount", EmitDefaultValue=false)]
		public DecimalValue? InvoiceAmount { get; set; }

		/// <summary>
		/// DAC: PX.Objects.CS.ShipTermsDetail 
		/// Display Name: Line Handling 
		/// </summary>
		[DataMember(Name="LineHandling", EmitDefaultValue=false)]
		public DecimalValue? LineHandling { get; set; }

		[DataMember(Name="LineNbr", EmitDefaultValue=false)]
		public IntValue? LineNbr { get; set; }

		/// <summary>
		/// DAC Field Name: ShippingHandling 
		/// DAC: PX.Objects.CS.ShipTermsDetail 
		/// Display Name: Shipping and Handling 
		/// </summary>
		[DataMember(Name="ShippingandHandling", EmitDefaultValue=false)]
		public DecimalValue? ShippingandHandling { get; set; }

	}
}