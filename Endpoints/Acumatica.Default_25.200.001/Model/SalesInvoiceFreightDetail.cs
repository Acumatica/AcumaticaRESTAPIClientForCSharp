using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_25_200_001.Model
{
	[DataContract]
	public class SalesInvoiceFreightDetail : Entity
	{

		/// <summary>
		/// <para>DAC Field Name: AccountID_Account_description</para>
		/// <para>DAC: PX.Objects.AR.ARTran</para>
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		/// <summary>
		/// The amount of freight associated with the document.Given in the currency of the document.
		/// <para>DAC Field Name: CuryFreightAmt</para>
		/// <para>DAC: PX.Objects.AR.ARInvoice</para>
		/// <para>Display Name: Freight Price</para>
		/// </summary>
		[DataMember(Name="FreightAmount", EmitDefaultValue=false)]
		public DecimalValue? FreightAmount { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CuryFreightCost</para>
		/// <para>DAC: PX.Objects.SO.SOFreightDetail</para>
		/// <para>Display Name: Freight Cost</para>
		/// </summary>
		[DataMember(Name="FreightCost", EmitDefaultValue=false)]
		public DecimalValue? FreightCost { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CuryLineTotal</para>
		/// <para>DAC: PX.Objects.SO.SOFreightDetail</para>
		/// <para>Display Name: Line Total</para>
		/// </summary>
		[DataMember(Name="LineTotal", EmitDefaultValue=false)]
		public DecimalValue? LineTotal { get; set; }

		/// <summary>
		/// The amount of premium freight associated with the document.Given in the currency of the document.
		/// <para>DAC Field Name: CuryPremiumFreightAmt</para>
		/// <para>DAC: PX.Objects.AR.ARInvoice</para>
		/// <para>Display Name: Premium Freight Price</para>
		/// </summary>
		[DataMember(Name="PremiumFreightAmount", EmitDefaultValue=false)]
		public DecimalValue? PremiumFreightAmount { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.SO.SOFreightDetail</para>
		/// <para>Display Name: Shipment Nbr.</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// Key Field
		/// </summary>
		[DataMember(Name="ShipmentNbr", EmitDefaultValue=false)]
		public StringValue? ShipmentNbr { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.SO.SOFreightDetail</para>
		/// <para>Display Name: Shipment Type</para>
		/// <para>SQL Type: char(1)</para>
		/// Key Field
		/// </summary>
		[DataMember(Name="ShipmentType", EmitDefaultValue=false)]
		public StringValue? ShipmentType { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CuryTotalFreightAmt</para>
		/// <para>DAC: PX.Objects.SO.SOFreightDetail</para>
		/// <para>Display Name: Total Freight Price</para>
		/// </summary>
		[DataMember(Name="TotalFreightAmount", EmitDefaultValue=false)]
		public DecimalValue? TotalFreightAmount { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.SO.SOFreightDetail</para>
		/// </summary>
		[DataMember(Name="Volume", EmitDefaultValue=false)]
		public DecimalValue? Volume { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.SO.SOFreightDetail</para>
		/// </summary>
		[DataMember(Name="Weight", EmitDefaultValue=false)]
		public DecimalValue? Weight { get; set; }

	}
}