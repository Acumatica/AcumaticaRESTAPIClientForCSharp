using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Manufacturing_24_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen AM209000 in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class ProductionOrderDetail : Entity, ITopLevelEntity
	{

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: BranchID 
		/// DAC: PX.Objects.AM.AMProdItem 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Branch", EmitDefaultValue=false)]
		public StringValue? Branch { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: Hold 
		/// DAC: PX.Objects.AM.AMProdItem 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Hold", EmitDefaultValue=false)]
		public BooleanValue? Hold { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: InventoryID 
		/// DAC: PX.Objects.AM.AMProdItem 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="InventoryID", EmitDefaultValue=false)]
		public StringValue? InventoryID { get; set; }

		[DataMember(Name="Operations", EmitDefaultValue=false)]
		public List<OrderOperationDetail>? Operations { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ProdDate 
		/// DAC: PX.Objects.AM.AMProdItem 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="OrderDate", EmitDefaultValue=false)]
		public DateTimeValue? OrderDate { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: OrderType 
		/// DAC: PX.Objects.AM.AMProdItem 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="OrderType", EmitDefaultValue=false)]
		public StringValue? OrderType { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ProdOrdID 
		/// DAC: PX.Objects.AM.AMProdItem 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ProductionNbr", EmitDefaultValue=false)]
		public StringValue? ProductionNbr { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: StatusID 
		/// DAC: PX.Objects.AM.AMProdItem 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Status", EmitDefaultValue=false)]
		public StringValue? Status { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: SubItemID 
		/// DAC: PX.Objects.AM.AMProdItem 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Subitem", EmitDefaultValue=false)]
		public StringValue? Subitem { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: SiteId 
		/// DAC: PX.Objects.AM.AMProdItem 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Warehouse", EmitDefaultValue=false)]
		public StringValue? Warehouse { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/MANUFACTURING/24.200.001";
		}
	}
}