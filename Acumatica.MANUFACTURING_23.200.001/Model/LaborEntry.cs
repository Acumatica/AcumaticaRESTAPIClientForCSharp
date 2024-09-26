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
	/// Corresponds to the screen AM301000 in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class LaborEntry : Entity, ITopLevelEntity
	{

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: BatNbr 
		/// DAC: PX.Objects.AM.AMBatch 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="BatchNbr", EmitDefaultValue=false)]
		public StringValue? BatchNbr { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ControlQty 
		/// DAC: PX.Objects.AM.AMBatch 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ControlQty", EmitDefaultValue=false)]
		public DecimalValue? ControlQty { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: TranDate 
		/// DAC: PX.Objects.AM.AMBatch 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Date", EmitDefaultValue=false)]
		public DateTimeValue? Date { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: TranDesc 
		/// DAC: PX.Objects.AM.AMBatch 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		[DataMember(Name="Details", EmitDefaultValue=false)]
		public List<LaborEntryDetail>? Details { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: Hold 
		/// DAC: PX.Objects.AM.AMBatch 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Hold", EmitDefaultValue=false)]
		public BooleanValue? Hold { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: FinPeriodID 
		/// DAC: PX.Objects.AM.AMBatch 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="PostPeriod", EmitDefaultValue=false)]
		public StringValue? PostPeriod { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: Status 
		/// DAC: PX.Objects.AM.AMBatch 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Status", EmitDefaultValue=false)]
		public StringValue? Status { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: TotalQty 
		/// DAC: PX.Objects.AM.AMBatch 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="TotalQty", EmitDefaultValue=false)]
		public DecimalValue? TotalQty { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/MANUFACTURING/23.200.001";
		}
	}
}