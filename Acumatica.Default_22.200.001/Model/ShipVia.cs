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
		/// 
		/// Display Name:
		/// DAC Field Name: CalcMethod 
		/// DAC: PX.Objects.CS.Carrier 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="CalculationMethod", EmitDefaultValue=false)]
		public StringValue? CalculationMethod { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: CalendarID 
		/// DAC: PX.Objects.CS.Carrier 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Calendar", EmitDefaultValue=false)]
		public StringValue? Calendar { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: CarrierID 
		/// DAC: PX.Objects.CS.Carrier 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="CarrierID", EmitDefaultValue=false)]
		public StringValue? CarrierID { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: IsCommonCarrier 
		/// DAC: PX.Objects.CS.Carrier 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="CommonCarrier", EmitDefaultValue=false)]
		public BooleanValue? CommonCarrier { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: Description 
		/// DAC: PX.Objects.CS.Carrier 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: FreightExpenseAcctID 
		/// DAC: PX.Objects.CS.Carrier 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="FreightExpenseAccount", EmitDefaultValue=false)]
		public StringValue? FreightExpenseAccount { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: FreightExpenseSubID 
		/// DAC: PX.Objects.CS.Carrier 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="FreightExpenseSubaccount", EmitDefaultValue=false)]
		public StringValue? FreightExpenseSubaccount { get; set; }

		[DataMember(Name="FreightRates", EmitDefaultValue=false)]
		public List<ShipViaFreightRate>? FreightRates { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: FreightSalesAcctID 
		/// DAC: PX.Objects.CS.Carrier 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="FreightSalesAccount", EmitDefaultValue=false)]
		public StringValue? FreightSalesAccount { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: FreightSalesSubID 
		/// DAC: PX.Objects.CS.Carrier 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="FreightSalesSubaccount", EmitDefaultValue=false)]
		public StringValue? FreightSalesSubaccount { get; set; }

		[DataMember(Name="Packages", EmitDefaultValue=false)]
		public List<ShippingBox>? Packages { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: TaxCategoryID 
		/// DAC: PX.Objects.CS.Carrier 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="TaxCategory", EmitDefaultValue=false)]
		public StringValue? TaxCategory { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/Default/22.200.001";
		}
	}
}