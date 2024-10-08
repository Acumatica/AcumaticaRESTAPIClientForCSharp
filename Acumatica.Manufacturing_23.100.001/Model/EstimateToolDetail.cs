using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Manufacturing_23_100_001.Model
{
	[DataContract]
	public class EstimateToolDetail : Entity
	{

		/// <summary>
		/// DAC: PX.Objects.AM.AMEstimateOper 
		/// Display Name: Operation Desc 
		/// SQL Type: nvarchar(256) 
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		/// <summary>
		/// DAC Field Name: LineID 
		/// DAC: PX.Objects.AM.AMEstimateMatl 
		/// Display Name: Line Nbr. 
		/// Key Field
		/// </summary>
		[DataMember(Name="LineNbr", EmitDefaultValue=false)]
		public IntValue? LineNbr { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMEstimateMatl 
		/// Display Name: Qty Required 
		/// </summary>
		[DataMember(Name="QtyReq", EmitDefaultValue=false)]
		public DecimalValue? QtyReq { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMEstimateTool 
		/// Display Name: Tool ID 
		/// SQL Type: nvarchar(30) 
		/// </summary>
		[DataMember(Name="ToolID", EmitDefaultValue=false)]
		public StringValue? ToolID { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMEstimateMatl 
		/// Display Name: Unit Cost 
		/// </summary>
		[DataMember(Name="UnitCost", EmitDefaultValue=false)]
		public DecimalValue? UnitCost { get; set; }

	}
}