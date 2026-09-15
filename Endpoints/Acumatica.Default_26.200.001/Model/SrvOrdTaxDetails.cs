using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_26_200_001.Model
{
	[DataContract]
	public class SrvOrdTaxDetails : Entity
	{

		/// <summary>
		/// <para>DAC Field Name: Tax__ExemptTax</para>
		/// <para>DAC: PX.Objects.FS.FSServiceOrderTaxTran</para>
		/// </summary>
		[DataMember(Name="IncludeinVATExemptTotal", EmitDefaultValue=false)]
		public BooleanValue? IncludeinVATExemptTotal { get; set; }

		/// <summary>
		/// <para>DAC Field Name: Tax__PendingTax</para>
		/// <para>DAC: PX.Objects.FS.FSServiceOrderTaxTran</para>
		/// </summary>
		[DataMember(Name="PendingVAT", EmitDefaultValue=false)]
		public BooleanValue? PendingVAT { get; set; }

		[DataMember(Name="RecordID", EmitDefaultValue=false)]
		public IntValue? RecordID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: Tax__ReverseTax</para>
		/// <para>DAC: PX.Objects.FS.FSServiceOrderTaxTran</para>
		/// </summary>
		[DataMember(Name="ReverseVAT", EmitDefaultValue=false)]
		public BooleanValue? ReverseVAT { get; set; }

		/// <summary>
		/// <para>DAC Field Name: RefNbr</para>
		/// <para>DAC: PX.Objects.FS.FSServiceOrder</para>
		/// <para>Display Name: Order Nbr.</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// Key Field
		/// </summary>
		[DataMember(Name="ServiceOrderNbr", EmitDefaultValue=false)]
		public StringValue? ServiceOrderNbr { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SrvOrdType</para>
		/// <para>DAC: PX.Objects.FS.FSServiceOrder</para>
		/// <para>Display Name: Order Type</para>
		/// <para>SQL Type: char(4)</para>
		/// Key Field
		/// </summary>
		[DataMember(Name="ServiceOrderType", EmitDefaultValue=false)]
		public StringValue? ServiceOrderType { get; set; }

		/// <summary>
		/// <para>DAC Field Name: Tax__StatisticalTax</para>
		/// <para>DAC: PX.Objects.FS.FSServiceOrderTaxTran</para>
		/// </summary>
		[DataMember(Name="StatisticalVAT", EmitDefaultValue=false)]
		public BooleanValue? StatisticalVAT { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CuryTaxableAmt</para>
		/// <para>DAC: PX.Objects.FS.FSServiceOrderTaxTran</para>
		/// <para>Display Name: Taxable Amount</para>
		/// </summary>
		[DataMember(Name="TaxableAmount", EmitDefaultValue=false)]
		public DecimalValue? TaxableAmount { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CuryTaxAmt</para>
		/// <para>DAC: PX.Objects.FS.FSServiceOrderTaxTran</para>
		/// <para>Display Name: Tax Amount</para>
		/// </summary>
		[DataMember(Name="TaxAmount", EmitDefaultValue=false)]
		public DecimalValue? TaxAmount { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.FS.FSServiceOrderTaxTran</para>
		/// <para>Display Name: Tax ID</para>
		/// <para>SQL Type: nvarchar(60)</para>
		/// Key Field
		/// </summary>
		[DataMember(Name="TaxID", EmitDefaultValue=false)]
		public StringValue? TaxID { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.FS.FSServiceOrderTaxTran</para>
		/// <para>Display Name: Tax Rate</para>
		/// </summary>
		[DataMember(Name="TaxRate", EmitDefaultValue=false)]
		public DecimalValue? TaxRate { get; set; }

		/// <summary>
		/// <para>DAC Field Name: Tax__TaxType</para>
		/// <para>DAC: PX.Objects.FS.FSServiceOrderTaxTran</para>
		/// </summary>
		[DataMember(Name="TaxType", EmitDefaultValue=false)]
		public StringValue? TaxType { get; set; }

		/// <summary>
		/// Names that can be passed in the <c>$expand</c> parameter.
		/// <para>This endpoint uses system contract 5, where a nested entity is expanded
		/// as <c>Parent($expand=Child)</c> rather than <c>Parent/Child</c>, so only the names
		/// that can be expanded directly on this entity are listed here. Use the nested
		/// entity's own <c>Expand</c> class for the inner names.</para>
		/// </summary>
		public static class Expand
		{
			public const string Files = "Files";

			//Intentionally excluded
			//public const string All = "Files";
		}
	}
}