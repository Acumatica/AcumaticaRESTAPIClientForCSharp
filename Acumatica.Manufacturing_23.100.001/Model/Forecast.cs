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
	/// Corresponds to the screen AM202000 in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class Forecast : Entity, ITopLevelEntity
	{

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ActiveFlg 
		/// DAC: PX.Objects.AM.AMForecast 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Active", EmitDefaultValue=false)]
		public BooleanValue? Active { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: BeginDate 
		/// DAC: PX.Objects.AM.AMForecast 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="BeginDate", EmitDefaultValue=false)]
		public DateTimeValue? BeginDate { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: BranchID 
		/// DAC: PX.Objects.AM.AMForecast 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Branch", EmitDefaultValue=false)]
		public StringValue? Branch { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: CustomerID 
		/// DAC: PX.Objects.AM.AMForecast 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Customer", EmitDefaultValue=false)]
		public StringValue? Customer { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: CustomerID_description 
		/// DAC: PX.Objects.AM.AMForecast 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="CustomerName", EmitDefaultValue=false)]
		public StringValue? CustomerName { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: Dependent 
		/// DAC: PX.Objects.AM.AMForecast 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Dependent", EmitDefaultValue=false)]
		public BooleanValue? Dependent { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: InventoryID_description 
		/// DAC: PX.Objects.AM.AMForecast 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: EndDate 
		/// DAC: PX.Objects.AM.AMForecast 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="EndDate", EmitDefaultValue=false)]
		public DateTimeValue? EndDate { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ForecastID 
		/// DAC: PX.Objects.AM.AMForecast 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ForecastID", EmitDefaultValue=false)]
		public StringValue? ForecastID { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: Interval 
		/// DAC: PX.Objects.AM.AMForecast 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Interval", EmitDefaultValue=false)]
		public StringValue? Interval { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: InventoryID 
		/// DAC: PX.Objects.AM.AMForecast 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="InventoryID", EmitDefaultValue=false)]
		public StringValue? InventoryID { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: Qty 
		/// DAC: PX.Objects.AM.AMForecast 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Quantity", EmitDefaultValue=false)]
		public DecimalValue? Quantity { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: SubItemID 
		/// DAC: PX.Objects.AM.AMForecast 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Subitem", EmitDefaultValue=false)]
		public StringValue? Subitem { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: UOM 
		/// DAC: PX.Objects.AM.AMForecast 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="UOM", EmitDefaultValue=false)]
		public StringValue? UOM { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: SiteID 
		/// DAC: PX.Objects.AM.AMForecast 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Warehouse", EmitDefaultValue=false)]
		public StringValue? Warehouse { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/MANUFACTURING/23.100.001";
		}
	}
}