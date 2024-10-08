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
	/// Corresponds to the screen AM301000 in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class LaborEntry : Entity, ITopLevelEntity
	{

		/// <summary>
		/// The reference number of the transaction.
		/// DAC Field Name: BatNbr 
		/// DAC: PX.Objects.AM.AMBatch 
		/// Display Name: Batch Nbr. 
		/// SQL Type: nvarchar(15) 
		/// Key Field
		/// </summary>
		[DataMember(Name="BatchNbr", EmitDefaultValue=false)]
		public StringValue? BatchNbr { get; set; }

		/// <summary>
		/// The control quantity of the transaction.
		/// DAC: PX.Objects.AM.AMBatch 
		/// Display Name: Control Qty. 
		/// </summary>
		[DataMember(Name="ControlQty", EmitDefaultValue=false)]
		public DecimalValue? ControlQty { get; set; }

		/// <summary>
		/// The date when the transaction was created.
		/// DAC Field Name: TranDate 
		/// DAC: PX.Objects.AM.AMBatch 
		/// </summary>
		[DataMember(Name="Date", EmitDefaultValue=false)]
		public DateTimeValue? Date { get; set; }

		/// <summary>
		/// A brief description of the transaction.
		/// DAC Field Name: TranDesc 
		/// DAC: PX.Objects.AM.AMBatch 
		/// SQL Type: nvarchar(256) 
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		[DataMember(Name="Details", EmitDefaultValue=false)]
		public List<LaborEntryDetail>? Details { get; set; }

		/// <summary>
		/// A Boolean value that indicates whether the batch is on hold.
		/// DAC: PX.Objects.AM.AMBatch 
		/// </summary>
		[DataMember(Name="Hold", EmitDefaultValue=false)]
		public BooleanValue? Hold { get; set; }

		/// <summary>
		/// The financial period that corresponds to the transaction date.
		/// DAC Field Name: FinPeriodID 
		/// DAC: PX.Objects.AM.AMBatch 
		/// Display Name: Post Period 
		/// SQL Type: char(6) 
		/// </summary>
		[DataMember(Name="PostPeriod", EmitDefaultValue=false)]
		public StringValue? PostPeriod { get; set; }

		/// <summary>
		/// The status of the transaction set by the system.
		/// DAC: PX.Objects.AM.AMBatch 
		/// SQL Type: char(1) 
		/// </summary>
		[DataMember(Name="Status", EmitDefaultValue=false)]
		public StringValue? Status { get; set; }

		/// <summary>
		/// The total quantity of the transaction, which the system calculates as the sum of the values in Qty.
		/// DAC: PX.Objects.AM.AMBatch 
		/// Display Name: Total Qty. 
		/// </summary>
		[DataMember(Name="TotalQty", EmitDefaultValue=false)]
		public DecimalValue? TotalQty { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/MANUFACTURING/24.200.001";
		}
	}
}