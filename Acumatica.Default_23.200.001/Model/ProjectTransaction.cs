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
	/// Corresponds to the screen PM304000 in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class ProjectTransaction : Entity, ITopLevelEntity
	{

		[DataMember(Name="CreatedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? CreatedDateTime { get; set; }

		/// <summary>
		/// The description of the document.
		/// DAC: PX.Objects.PM.PMRegister 
		/// SQL Type: nvarchar(255) 
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		[DataMember(Name="Details", EmitDefaultValue=false)]
		public List<ProjectTransactionDetail>? Details { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? LastModifiedDateTime { get; set; }

		/// <summary>
		/// The identifier of the functional area, to which the batch belongs.
		/// DAC: PX.Objects.PM.PMRegister 
		/// SQL Type: char(2) 
		/// Key Field
		/// </summary>
		[DataMember(Name="Module", EmitDefaultValue=false)]
		public StringValue? Module { get; set; }

		/// <summary>
		/// The reference number of the original document.
		/// DAC Field Name: OrigDocNbr 
		/// DAC: PX.Objects.PM.PMRegister 
		/// Display Name: Orig. Doc. Nbr. 
		/// SQL Type: nvarchar(30) 
		/// </summary>
		[DataMember(Name="OriginalDocNbr", EmitDefaultValue=false)]
		public StringValue? OriginalDocNbr { get; set; }

		/// <summary>
		/// The type of the original document.
		/// DAC Field Name: OrigDocType 
		/// DAC: PX.Objects.PM.PMRegister 
		/// Display Name: Orig. Doc. Type 
		/// SQL Type: char(2) 
		/// </summary>
		[DataMember(Name="OriginalDocType", EmitDefaultValue=false)]
		public StringValue? OriginalDocType { get; set; }

		/// <summary>
		/// The reference number of the document.
		/// DAC Field Name: RefNbr 
		/// DAC: PX.Objects.PM.PMRegister 
		/// Display Name: Ref. Number 
		/// SQL Type: nvarchar(15) 
		/// Key Field
		/// </summary>
		[DataMember(Name="ReferenceNbr", EmitDefaultValue=false)]
		public StringValue? ReferenceNbr { get; set; }

		/// <summary>
		/// The read-only status of the document.
		/// DAC: PX.Objects.PM.PMRegister 
		/// SQL Type: char(1) 
		/// </summary>
		[DataMember(Name="Status", EmitDefaultValue=false)]
		public StringValue? Status { get; set; }

		/// <summary>
		/// The total amount for the project transactions in the base currency.
		/// DAC Field Name: AmtTotal 
		/// DAC: PX.Objects.PM.PMRegister 
		/// Display Name: Total Amount 
		/// </summary>
		[DataMember(Name="TotalAmount", EmitDefaultValue=false)]
		public DecimalValue? TotalAmount { get; set; }

		/// <summary>
		/// The total billable quantity for the project transactions.
		/// DAC Field Name: BillableQtyTotal 
		/// DAC: PX.Objects.PM.PMRegister 
		/// Display Name: Total Billable Quantity 
		/// </summary>
		[DataMember(Name="TotalBillableQty", EmitDefaultValue=false)]
		public DecimalValue? TotalBillableQty { get; set; }

		/// <summary>
		/// The total quantity of items in the project transactions.
		/// DAC Field Name: QtyTotal 
		/// DAC: PX.Objects.PM.PMRegister 
		/// Display Name: Total Quantity 
		/// </summary>
		[DataMember(Name="TotalQty", EmitDefaultValue=false)]
		public DecimalValue? TotalQty { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/Default/23.200.001";
		}
	}
}