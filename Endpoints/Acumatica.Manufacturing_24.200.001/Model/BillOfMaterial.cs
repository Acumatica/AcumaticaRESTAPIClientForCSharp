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
	/// Corresponds to the screen AM208000 in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class BillOfMaterial : Entity, ITopLevelEntity
	{

		/// <summary>
		/// The identifier of the bill of material.
		/// DAC: PX.Objects.AM.AMBomItem 
		/// Display Name: BOM ID 
		/// SQL Type: nvarchar(15) 
		/// Key Field
		/// </summary>
		[DataMember(Name="BOMID", EmitDefaultValue=false)]
		public StringValue? BOMID { get; set; }

		/// <summary>
		/// A description of the bill of material. The system copies the description to production orders that are created by using the bill of material.
		/// DAC Field Name: Descr 
		/// DAC: PX.Objects.AM.AMBomItem 
		/// SQL Type: nvarchar(256) 
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		/// <summary>
		/// The last date when the BOM revision was effective.
		/// DAC: PX.Objects.AM.AMBomItem 
		/// Display Name: End Date 
		/// </summary>
		[DataMember(Name="EffEndDate", EmitDefaultValue=false)]
		public DateTimeValue? EffEndDate { get; set; }

		/// <summary>
		/// The date when the BOM revision becomes effective.
		/// DAC: PX.Objects.AM.AMBomItem 
		/// Display Name: Start Date 
		/// </summary>
		[DataMember(Name="EffStartDate", EmitDefaultValue=false)]
		public DateTimeValue? EffStartDate { get; set; }

		/// <summary>
		/// A Boolean value that indicates whether the BOM item is on hold.
		/// DAC: PX.Objects.AM.AMBomItem 
		/// </summary>
		[DataMember(Name="Hold", EmitDefaultValue=false)]
		public BooleanValue? Hold { get; set; }

		/// <summary>
		/// The identifier of the stock item that is produced by using the bill of material.
		/// DAC: PX.Objects.AM.AMBomItem 
		/// Display Name: Inventory ID 
		/// </summary>
		[DataMember(Name="InventoryID", EmitDefaultValue=false)]
		public StringValue? InventoryID { get; set; }

		[DataMember(Name="Operations", EmitDefaultValue=false)]
		public List<OperationDetail>? Operations { get; set; }

		/// <summary>
		/// The identifier of the BOM revision, which is the modification of the bill of material.
		/// DAC Field Name: RevisionID 
		/// DAC: PX.Objects.AM.AMBomItem 
		/// SQL Type: nvarchar(10) 
		/// Key Field
		/// </summary>
		[DataMember(Name="Revision", EmitDefaultValue=false)]
		public StringValue? Revision { get; set; }

		/// <summary>
		/// The status of the revision.
		/// DAC: PX.Objects.AM.AMBomItem 
		/// SQL Type: char(1) 
		/// </summary>
		[DataMember(Name="Status", EmitDefaultValue=false)]
		public StringValue? Status { get; set; }

		/// <summary>
		/// The subitem of the stock item.
		/// DAC Field Name: SubItemID 
		/// DAC: PX.Objects.AM.AMBomItem 
		/// </summary>
		[DataMember(Name="Subitem", EmitDefaultValue=false)]
		public StringValue? Subitem { get; set; }

		/// <summary>
		/// The warehouse to which the produced stock item is received when the item production is completed.
		/// DAC Field Name: SiteID 
		/// DAC: PX.Objects.AM.AMBomItem 
		/// </summary>
		[DataMember(Name="Warehouse", EmitDefaultValue=false)]
		public StringValue? Warehouse { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/MANUFACTURING/24.200.001";
		}
	}
}