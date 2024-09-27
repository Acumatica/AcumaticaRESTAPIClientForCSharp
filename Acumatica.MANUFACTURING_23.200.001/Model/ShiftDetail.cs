using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Manufacturing_23_200_001.Model
{
	[DataContract]
	public class ShiftDetail : Entity
	{

		/// <summary>
		/// DAC: PX.Objects.AM.AMShift 
		/// Display Name: Calendar ID 
		/// SQL Type: nvarchar(10) 
		/// </summary>
		[DataMember(Name="CalendarID", EmitDefaultValue=false)]
		public StringValue? CalendarID { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMShift 
		/// Display Name: Crew Size 
		/// </summary>
		[DataMember(Name="CrewSize", EmitDefaultValue=false)]
		public DecimalValue? CrewSize { get; set; }

		/// <summary>
		/// DAC Field Name: EPShiftCode__DiffType 
		/// DAC: PX.Objects.AM.AMShift 
		/// </summary>
		[DataMember(Name="DiffType", EmitDefaultValue=false)]
		public StringValue? DiffType { get; set; }

		/// <summary>
		/// DAC Field Name: ShftEff 
		/// DAC: PX.Objects.AM.AMShift 
		/// </summary>
		[DataMember(Name="Efficiency", EmitDefaultValue=false)]
		public DecimalValue? Efficiency { get; set; }

		/// <summary>
		/// DAC Field Name: LaborCodeID 
		/// DAC: PX.Objects.AM.AMShift 
		/// Display Name: Labor Code 
		/// SQL Type: nvarchar(15) 
		/// </summary>
		[DataMember(Name="LaborCode", EmitDefaultValue=false)]
		public StringValue? LaborCode { get; set; }

		/// <summary>
		/// DAC Field Name: MachNbr 
		/// DAC: PX.Objects.AM.AMShift 
		/// </summary>
		[DataMember(Name="Machines", EmitDefaultValue=false)]
		public DecimalValue? Machines { get; set; }

		/// <summary>
		/// DAC Field Name: ShiftCD 
		/// DAC: PX.Objects.AM.AMShift 
		/// SQL Type: nvarchar(15) 
		/// Key Field
		/// </summary>
		[DataMember(Name="Shift", EmitDefaultValue=false)]
		public StringValue? Shift { get; set; }

		/// <summary>
		/// DAC Field Name: EPShiftCode__ShftDiff 
		/// DAC: PX.Objects.AM.AMShift 
		/// </summary>
		[DataMember(Name="ShiftDiff", EmitDefaultValue=false)]
		public DecimalValue? ShiftDiff { get; set; }

	}
}