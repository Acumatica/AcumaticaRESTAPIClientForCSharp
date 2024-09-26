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
	/// Corresponds to the screen PM304000 in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class ProjectTransaction : Entity, ITopLevelEntity
	{

		[DataMember(Name="CreatedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? CreatedDateTime { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: Description 
		/// DAC: PX.Objects.PM.PMRegister 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		[DataMember(Name="Details", EmitDefaultValue=false)]
		public List<ProjectTransactionDetail>? Details { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? LastModifiedDateTime { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: Module 
		/// DAC: PX.Objects.PM.PMRegister 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Module", EmitDefaultValue=false)]
		public StringValue? Module { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: OrigDocNbr 
		/// DAC: PX.Objects.PM.PMRegister 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="OriginalDocNbr", EmitDefaultValue=false)]
		public StringValue? OriginalDocNbr { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: OrigDocType 
		/// DAC: PX.Objects.PM.PMRegister 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="OriginalDocType", EmitDefaultValue=false)]
		public StringValue? OriginalDocType { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: RefNbr 
		/// DAC: PX.Objects.PM.PMRegister 
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
		/// DAC: PX.Objects.PM.PMRegister 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Status", EmitDefaultValue=false)]
		public StringValue? Status { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: AmtTotal 
		/// DAC: PX.Objects.PM.PMRegister 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="TotalAmount", EmitDefaultValue=false)]
		public DecimalValue? TotalAmount { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: BillableQtyTotal 
		/// DAC: PX.Objects.PM.PMRegister 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="TotalBillableQty", EmitDefaultValue=false)]
		public DecimalValue? TotalBillableQty { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: QtyTotal 
		/// DAC: PX.Objects.PM.PMRegister 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="TotalQty", EmitDefaultValue=false)]
		public DecimalValue? TotalQty { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/Default/24.200.001";
		}
	}
}