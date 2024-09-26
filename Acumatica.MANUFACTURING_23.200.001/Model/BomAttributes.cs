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
	/// Corresponds to the screen AM208500 in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class BomAttributes : Entity, ITopLevelEntity
	{

		[DataMember(Name="Attributes", EmitDefaultValue=false)]
		public List<AttributeDetail>? Attributes { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: BOMID 
		/// DAC: PX.Objects.AM.AMBomItem 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="BOMID", EmitDefaultValue=false)]
		public StringValue? BOMID { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: EffEndDate 
		/// DAC: PX.Objects.AM.AMBomItem 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="EndDate", EmitDefaultValue=false)]
		public DateTimeValue? EndDate { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: Hold 
		/// DAC: PX.Objects.AM.AMBomItem 
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
		/// DAC: PX.Objects.AM.AMBomItem 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="InventoryID", EmitDefaultValue=false)]
		public StringValue? InventoryID { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: RevisionID 
		/// DAC: PX.Objects.AM.AMBomItem 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Revision", EmitDefaultValue=false)]
		public StringValue? Revision { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: EffStartDate 
		/// DAC: PX.Objects.AM.AMBomItem 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="StartDate", EmitDefaultValue=false)]
		public DateTimeValue? StartDate { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: Status 
		/// DAC: PX.Objects.AM.AMBomItem 
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
		/// DAC: PX.Objects.AM.AMBomItem 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Subitem", EmitDefaultValue=false)]
		public StringValue? Subitem { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: SiteID 
		/// DAC: PX.Objects.AM.AMBomItem 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Warehouse", EmitDefaultValue=false)]
		public StringValue? Warehouse { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/MANUFACTURING/23.200.001";
		}
	}
}