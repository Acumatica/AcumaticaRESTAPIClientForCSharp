using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_24_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen IN305000 in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class PhysicalInventoryReview : Entity, ITopLevelEntity
	{

		[DataMember(Name="CreatedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? CreatedDateTime { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: Descr 
		/// DAC: PX.Objects.IN.INPIHeader 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		[DataMember(Name="Details", EmitDefaultValue=false)]
		public List<PhysicalInventoryReviewDetail>? Details { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: CountDate 
		/// DAC: PX.Objects.IN.INPIHeader 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="FreezeDate", EmitDefaultValue=false)]
		public DateTimeValue? FreezeDate { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: PIID 
		/// DAC: PX.Objects.IN.INPIHeader 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ReferenceNbr", EmitDefaultValue=false)]
		public StringValue? ReferenceNbr { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: Status 
		/// DAC: PX.Objects.IN.INPIHeader 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Status", EmitDefaultValue=false)]
		public StringValue? Status { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: TotalPhysicalQty 
		/// DAC: PX.Objects.IN.INPIHeader 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="TotalPhysicalQty", EmitDefaultValue=false)]
		public DecimalValue? TotalPhysicalQty { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: TotalVarCost 
		/// DAC: PX.Objects.IN.INPIHeader 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="TotalVarianceCost", EmitDefaultValue=false)]
		public DecimalValue? TotalVarianceCost { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: TotalVarQty 
		/// DAC: PX.Objects.IN.INPIHeader 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="TotalVarianceQty", EmitDefaultValue=false)]
		public DecimalValue? TotalVarianceQty { get; set; }

		[DataMember(Name="TypeID", EmitDefaultValue=false)]
		public StringValue? TypeID { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: SiteID 
		/// DAC: PX.Objects.IN.INPIHeader 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="WarehouseID", EmitDefaultValue=false)]
		public StringValue? WarehouseID { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/Default/24.200.001";
		}
	}
}