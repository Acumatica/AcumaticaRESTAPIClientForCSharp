using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_23_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen <c>CS207500</c> in the Acumatica ERP
	/// <para>Key Fields: CarrierID</para>
	/// </summary>
	[DataContract]
	public class ShipVia : Entity, ITopLevelEntity
	{

		/// <summary>
		/// The method used to calculate freight charges using the rate breakdown specified in the related FreightRate records.
		/// <para>DAC Field Name: CalcMethod</para>
		/// <para>DAC: PX.Objects.CS.Carrier</para>
		/// <para>Display Name: Calculation Method</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		[DataMember(Name="CalculationMethod", EmitDefaultValue=false)]
		public StringValue? CalculationMethod { get; set; }

		/// <summary>
		/// The Calendar associated with the carrier, which reflects its work hours and the days when it ships the goods.
		/// <para>DAC Field Name: CalendarID</para>
		/// <para>DAC: PX.Objects.CS.Carrier</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// </summary>
		[DataMember(Name="Calendar", EmitDefaultValue=false)]
		public StringValue? Calendar { get; set; }

		/// <summary>
		/// Key field.A unique code of a non-integrated carrier, a method of the integrated carrier or a shipping option of the company.
		/// <para>DAC: PX.Objects.CS.Carrier</para>
		/// <para>Display Name: Ship Via</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// Key Field
		/// </summary>
		[DataMember(Name="CarrierID", EmitDefaultValue=false)]
		public StringValue? CarrierID { get; set; }

		/// <summary>
		/// Indicates whether the carrier is a common carrier.Because common carriers deliver goods from a company branch to the customer location that isa selling point, the value of this field affects the set of taxes that applies to the corresponding invoice.
		/// <para>DAC Field Name: IsCommonCarrier</para>
		/// <para>DAC: PX.Objects.CS.Carrier</para>
		/// <para>Display Name: Common Carrier</para>
		/// </summary>
		[DataMember(Name="CommonCarrier", EmitDefaultValue=false)]
		public BooleanValue? CommonCarrier { get; set; }

		/// <summary>
		/// The description of the carrier or shipping option.
		/// <para>DAC: PX.Objects.CS.Carrier</para>
		/// <para>SQL Type: nvarchar(60)</para>
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		/// <summary>
		/// Identifier of the General Ledger expense Account, that is used to record the freight charges to be paid to the Carrier.
		/// <para>DAC Field Name: FreightExpenseAcctID</para>
		/// <para>DAC: PX.Objects.CS.Carrier</para>
		/// <para>Display Name: Freight Expense Account</para>
		/// </summary>
		[DataMember(Name="FreightExpenseAccount", EmitDefaultValue=false)]
		public StringValue? FreightExpenseAccount { get; set; }

		/// <summary>
		/// Identifier of the General Ledger Subaccount, that is used to record the freight charges to be paid to the Carrier.
		/// <para>DAC Field Name: FreightExpenseSubID</para>
		/// <para>DAC: PX.Objects.CS.Carrier</para>
		/// <para>Display Name: Freight Expense Sub.</para>
		/// </summary>
		[DataMember(Name="FreightExpenseSubaccount", EmitDefaultValue=false)]
		public StringValue? FreightExpenseSubaccount { get; set; }

		[DataMember(Name="FreightRates", EmitDefaultValue=false)]
		public List<ShipViaFreightRate>? FreightRates { get; set; }

		/// <summary>
		/// Identifier of the General Ledger income Account, that is used to record the freight charges to be paid to the company.
		/// <para>DAC Field Name: FreightSalesAcctID</para>
		/// <para>DAC: PX.Objects.CS.Carrier</para>
		/// <para>Display Name: Freight Sales Account</para>
		/// </summary>
		[DataMember(Name="FreightSalesAccount", EmitDefaultValue=false)]
		public StringValue? FreightSalesAccount { get; set; }

		/// <summary>
		/// Identifier of the General Ledger Subaccount, that is used to record the freight charges to be paid to the company.
		/// <para>DAC Field Name: FreightSalesSubID</para>
		/// <para>DAC: PX.Objects.CS.Carrier</para>
		/// <para>Display Name: Freight Sales Sub.</para>
		/// </summary>
		[DataMember(Name="FreightSalesSubaccount", EmitDefaultValue=false)]
		public StringValue? FreightSalesSubaccount { get; set; }

		[DataMember(Name="Packages", EmitDefaultValue=false)]
		public List<ShippingBox>? Packages { get; set; }

		/// <summary>
		/// Identifier of the Tax Category to be applied to the freight amountwhen goods are shipped with this shipping option.
		/// <para>DAC Field Name: TaxCategoryID</para>
		/// <para>DAC: PX.Objects.CS.Carrier</para>
		/// <para>Display Name: Tax Category</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// </summary>
		[DataMember(Name="TaxCategory", EmitDefaultValue=false)]
		public StringValue? TaxCategory { get; set; }

		public static class Expand
		{
			public const string Files = "Files";
			public const string FreightRates = "FreightRates";
			public const string FreightRates_Files = "FreightRates/Files";
			public const string Packages = "Packages";
			public const string Packages_Files = "Packages/Files";

			//Intentionally excluded
			//public const string All = "Files,FreightRates,FreightRates/Files,Packages,Packages/Files";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/Default/23.200.001";
		}
	}
}