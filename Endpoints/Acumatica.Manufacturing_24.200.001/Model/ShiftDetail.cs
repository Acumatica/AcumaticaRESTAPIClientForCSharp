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
	public class ShiftDetail : Entity
	{

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMShift</para>
		/// <para>Display Name: Calendar ID</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// </summary>
		[DataMember(Name="CalendarID", EmitDefaultValue=false)]
		public StringValue? CalendarID { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMShift</para>
		/// <para>Display Name: Crew Size</para>
		/// </summary>
		[DataMember(Name="CrewSize", EmitDefaultValue=false)]
		public DecimalValue? CrewSize { get; set; }

		/// <summary>
		/// <para>DAC Field Name: EPShiftCode__DiffType</para>
		/// <para>DAC: PX.Objects.AM.AMShift</para>
		/// </summary>
		[DataMember(Name="DiffType", EmitDefaultValue=false)]
		public StringValue? DiffType { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ShftEff</para>
		/// <para>DAC: PX.Objects.AM.AMShift</para>
		/// </summary>
		[DataMember(Name="Efficiency", EmitDefaultValue=false)]
		public DecimalValue? Efficiency { get; set; }

		/// <summary>
		/// <para>DAC Field Name: LaborCodeID</para>
		/// <para>DAC: PX.Objects.AM.AMShift</para>
		/// <para>Display Name: Labor Code</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// </summary>
		[DataMember(Name="LaborCode", EmitDefaultValue=false)]
		public StringValue? LaborCode { get; set; }

		/// <summary>
		/// <para>DAC Field Name: MachNbr</para>
		/// <para>DAC: PX.Objects.AM.AMShift</para>
		/// </summary>
		[DataMember(Name="Machines", EmitDefaultValue=false)]
		public DecimalValue? Machines { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ShiftCD</para>
		/// <para>DAC: PX.Objects.AM.AMShift</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// Key Field
		/// </summary>
		[DataMember(Name="Shift", EmitDefaultValue=false)]
		public StringValue? Shift { get; set; }

		/// <summary>
		/// <para>DAC Field Name: EPShiftCode__ShftDiff</para>
		/// <para>DAC: PX.Objects.AM.AMShift</para>
		/// </summary>
		[DataMember(Name="ShiftDiff", EmitDefaultValue=false)]
		public DecimalValue? ShiftDiff { get; set; }

	}
}