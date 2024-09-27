using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Manufacturing_23_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen AM209000 in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class ProductionOrderDetail : Entity, ITopLevelEntity
	{

		/// <summary>
		/// DAC Field Name: BranchID 
		/// DAC: PX.Objects.AM.AMProdItem 
		/// </summary>
		[DataMember(Name="Branch", EmitDefaultValue=false)]
		public StringValue? Branch { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMProdItem 
		/// </summary>
		[DataMember(Name="Hold", EmitDefaultValue=false)]
		public BooleanValue? Hold { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMProdItem 
		/// Display Name: Inventory ID 
		/// </summary>
		[DataMember(Name="InventoryID", EmitDefaultValue=false)]
		public StringValue? InventoryID { get; set; }

		[DataMember(Name="Operations", EmitDefaultValue=false)]
		public List<OrderOperationDetail>? Operations { get; set; }

		/// <summary>
		/// DAC Field Name: ProdDate 
		/// DAC: PX.Objects.AM.AMProdItem 
		/// Display Name: Order Date 
		/// </summary>
		[DataMember(Name="OrderDate", EmitDefaultValue=false)]
		public DateTimeValue? OrderDate { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMProdItem 
		/// Display Name: Order Type 
		/// SQL Type: char(2) 
		/// Key Field
		/// </summary>
		[DataMember(Name="OrderType", EmitDefaultValue=false)]
		public StringValue? OrderType { get; set; }

		/// <summary>
		/// DAC Field Name: ProdOrdID 
		/// DAC: PX.Objects.AM.AMProdItem 
		/// Display Name: Production Nbr. 
		/// SQL Type: nvarchar(19) 
		/// Key Field
		/// </summary>
		[DataMember(Name="ProductionNbr", EmitDefaultValue=false)]
		public StringValue? ProductionNbr { get; set; }

		/// <summary>
		/// DAC Field Name: StatusID 
		/// DAC: PX.Objects.AM.AMProdItem 
		/// SQL Type: char(1) 
		/// </summary>
		[DataMember(Name="Status", EmitDefaultValue=false)]
		public StringValue? Status { get; set; }

		/// <summary>
		/// DAC Field Name: SubItemID 
		/// DAC: PX.Objects.AM.AMProdItem 
		/// </summary>
		[DataMember(Name="Subitem", EmitDefaultValue=false)]
		public StringValue? Subitem { get; set; }

		/// <summary>
		/// DAC Field Name: SiteId 
		/// DAC: PX.Objects.AM.AMProdItem 
		/// </summary>
		[DataMember(Name="Warehouse", EmitDefaultValue=false)]
		public StringValue? Warehouse { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/MANUFACTURING/23.200.001";
		}
	}
}