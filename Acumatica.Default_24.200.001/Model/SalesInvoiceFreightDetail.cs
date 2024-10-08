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
	public class SalesInvoiceFreightDetail : Entity
	{

		/// <summary>
		/// DAC Field Name: AccountID_Account_description 
		/// DAC: PX.Objects.AR.ARTran 
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		/// <summary>
		/// The amount of freight associated with the document.Given in the currency of the document.
		/// DAC Field Name: CuryFreightAmt 
		/// DAC: PX.Objects.AR.ARInvoice 
		/// Display Name: Freight Price 
		/// </summary>
		[DataMember(Name="FreightAmount", EmitDefaultValue=false)]
		public DecimalValue? FreightAmount { get; set; }

		/// <summary>
		/// DAC Field Name: CuryFreightCost 
		/// DAC: PX.Objects.SO.SOFreightDetail 
		/// Display Name: Freight Cost 
		/// </summary>
		[DataMember(Name="FreightCost", EmitDefaultValue=false)]
		public DecimalValue? FreightCost { get; set; }

		/// <summary>
		/// DAC Field Name: CuryLineTotal 
		/// DAC: PX.Objects.SO.SOFreightDetail 
		/// Display Name: Line Total 
		/// </summary>
		[DataMember(Name="LineTotal", EmitDefaultValue=false)]
		public DecimalValue? LineTotal { get; set; }

		/// <summary>
		/// The amount of premium freight associated with the document.Given in the currency of the document.
		/// DAC Field Name: CuryPremiumFreightAmt 
		/// DAC: PX.Objects.AR.ARInvoice 
		/// Display Name: Premium Freight Price 
		/// </summary>
		[DataMember(Name="PremiumFreightAmount", EmitDefaultValue=false)]
		public DecimalValue? PremiumFreightAmount { get; set; }

		/// <summary>
		/// DAC: PX.Objects.SO.SOFreightDetail 
		/// Display Name: Shipment Nbr. 
		/// SQL Type: nvarchar(15) 
		/// Key Field
		/// </summary>
		[DataMember(Name="ShipmentNbr", EmitDefaultValue=false)]
		public StringValue? ShipmentNbr { get; set; }

		/// <summary>
		/// DAC: PX.Objects.SO.SOFreightDetail 
		/// Display Name: Shipment Type 
		/// SQL Type: char(1) 
		/// Key Field
		/// </summary>
		[DataMember(Name="ShipmentType", EmitDefaultValue=false)]
		public StringValue? ShipmentType { get; set; }

		/// <summary>
		/// DAC Field Name: CuryTotalFreightAmt 
		/// DAC: PX.Objects.SO.SOFreightDetail 
		/// Display Name: Total Freight Price 
		/// </summary>
		[DataMember(Name="TotalFreightAmount", EmitDefaultValue=false)]
		public DecimalValue? TotalFreightAmount { get; set; }

		/// <summary>
		/// DAC: PX.Objects.SO.SOFreightDetail 
		/// </summary>
		[DataMember(Name="Volume", EmitDefaultValue=false)]
		public DecimalValue? Volume { get; set; }

		/// <summary>
		/// DAC: PX.Objects.SO.SOFreightDetail 
		/// </summary>
		[DataMember(Name="Weight", EmitDefaultValue=false)]
		public DecimalValue? Weight { get; set; }

	}
}