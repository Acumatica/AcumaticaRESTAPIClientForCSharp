using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_22_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen CS207500 in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class ShipVia : Entity, ITopLevelEntity
	{

		/// <summary>
		/// The method used to calculate freight charges using the rate breakdown specified in the related FreightRate records.
		/// DAC Field Name: CalcMethod 
		/// DAC: PX.Objects.CS.Carrier 
		/// Display Name: Calculation Method 
		/// SQL Type: char(1) 
		/// </summary>
		[DataMember(Name="CalculationMethod", EmitDefaultValue=false)]
		public StringValue? CalculationMethod { get; set; }

		/// <summary>
		/// The Calendar associated with the carrier, which reflects its work hours and the days when it ships the goods.
		/// DAC Field Name: CalendarID 
		/// DAC: PX.Objects.CS.Carrier 
		/// SQL Type: nvarchar(10) 
		/// </summary>
		[DataMember(Name="Calendar", EmitDefaultValue=false)]
		public StringValue? Calendar { get; set; }

		/// <summary>
		/// Key field.A unique code of a non-integrated carrier, a method of the integrated carrier or a shipping option of the company.
		/// DAC: PX.Objects.CS.Carrier 
		/// Display Name: Ship Via 
		/// SQL Type: nvarchar(15) 
		/// Key Field
		/// </summary>
		[DataMember(Name="CarrierID", EmitDefaultValue=false)]
		public StringValue? CarrierID { get; set; }

		/// <summary>
		/// Indicates whether the carrier is a common carrier.Because common carriers deliver goods from a company branch to the customer location that isa selling point, the value of this field affects the set of taxes that applies to the corresponding invoice.
		/// DAC Field Name: IsCommonCarrier 
		/// DAC: PX.Objects.CS.Carrier 
		/// Display Name: Common Carrier 
		/// </summary>
		[DataMember(Name="CommonCarrier", EmitDefaultValue=false)]
		public BooleanValue? CommonCarrier { get; set; }

		/// <summary>
		/// The description of the carrier or shipping option.
		/// DAC: PX.Objects.CS.Carrier 
		/// SQL Type: nvarchar(60) 
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		/// <summary>
		/// Identifier of the General Ledger expense Account, that is used to record the freight charges to be paid to the Carrier.
		/// DAC Field Name: FreightExpenseAcctID 
		/// DAC: PX.Objects.CS.Carrier 
		/// Display Name: Freight Expense Account 
		/// </summary>
		[DataMember(Name="FreightExpenseAccount", EmitDefaultValue=false)]
		public StringValue? FreightExpenseAccount { get; set; }

		/// <summary>
		/// Identifier of the General Ledger Subaccount, that is used to record the freight charges to be paid to the Carrier.
		/// DAC Field Name: FreightExpenseSubID 
		/// DAC: PX.Objects.CS.Carrier 
		/// Display Name: Freight Expense Sub. 
		/// </summary>
		[DataMember(Name="FreightExpenseSubaccount", EmitDefaultValue=false)]
		public StringValue? FreightExpenseSubaccount { get; set; }

		[DataMember(Name="FreightRates", EmitDefaultValue=false)]
		public List<ShipViaFreightRate>? FreightRates { get; set; }

		/// <summary>
		/// Identifier of the General Ledger income Account, that is used to record the freight charges to be paid to the company.
		/// DAC Field Name: FreightSalesAcctID 
		/// DAC: PX.Objects.CS.Carrier 
		/// Display Name: Freight Sales Account 
		/// </summary>
		[DataMember(Name="FreightSalesAccount", EmitDefaultValue=false)]
		public StringValue? FreightSalesAccount { get; set; }

		/// <summary>
		/// Identifier of the General Ledger Subaccount, that is used to record the freight charges to be paid to the company.
		/// DAC Field Name: FreightSalesSubID 
		/// DAC: PX.Objects.CS.Carrier 
		/// Display Name: Freight Sales Sub. 
		/// </summary>
		[DataMember(Name="FreightSalesSubaccount", EmitDefaultValue=false)]
		public StringValue? FreightSalesSubaccount { get; set; }

		[DataMember(Name="Packages", EmitDefaultValue=false)]
		public List<ShippingBox>? Packages { get; set; }

		/// <summary>
		/// Identifier of the Tax Category to be applied to the freight amountwhen goods are shipped with this shipping option.
		/// DAC Field Name: TaxCategoryID 
		/// DAC: PX.Objects.CS.Carrier 
		/// Display Name: Tax Category 
		/// SQL Type: nvarchar(15) 
		/// </summary>
		[DataMember(Name="TaxCategory", EmitDefaultValue=false)]
		public StringValue? TaxCategory { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/Default/22.200.001";
		}
	}
}