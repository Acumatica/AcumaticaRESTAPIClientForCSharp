using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Manufacturing_24_200_001.Model
{
	[DataContract]
	public class EstimateOverheadDetail : Entity
	{

		/// <summary>
		/// DAC: PX.Objects.AM.AMEstimateOper 
		/// Display Name: Operation Desc 
		/// SQL Type: nvarchar(256) 
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		/// <summary>
		/// DAC Field Name: OFactor 
		/// DAC: PX.Objects.AM.AMEstimateOvhd 
		/// </summary>
		[DataMember(Name="Factor", EmitDefaultValue=false)]
		public DecimalValue? Factor { get; set; }

		/// <summary>
		/// DAC Field Name: LineID 
		/// DAC: PX.Objects.AM.AMEstimateMatl 
		/// Display Name: Line Nbr. 
		/// Key Field
		/// </summary>
		[DataMember(Name="LineNbr", EmitDefaultValue=false)]
		public IntValue? LineNbr { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMEstimateOvhd 
		/// Display Name: Overhead Cost Rate 
		/// </summary>
		[DataMember(Name="OverheadCostRate", EmitDefaultValue=false)]
		public DecimalValue? OverheadCostRate { get; set; }

		/// <summary>
		/// DAC Field Name: OvhdID 
		/// DAC: PX.Objects.AM.AMEstimateOvhd 
		/// Display Name: Overhead ID 
		/// SQL Type: nvarchar(20) 
		/// </summary>
		[DataMember(Name="OverheadID", EmitDefaultValue=false)]
		public StringValue? OverheadID { get; set; }

		/// <summary>
		/// AMOverhead type
		/// DAC Field Name: OvhdType 
		/// DAC: PX.Objects.AM.AMEstimateOvhd 
		/// SQL Type: char(1) 
		/// </summary>
		[DataMember(Name="Type", EmitDefaultValue=false)]
		public StringValue? Type { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMEstimateOvhd 
		/// Display Name: WC Flag 
		/// </summary>
		[DataMember(Name="WCFlag", EmitDefaultValue=false)]
		public BooleanValue? WCFlag { get; set; }

	}
}