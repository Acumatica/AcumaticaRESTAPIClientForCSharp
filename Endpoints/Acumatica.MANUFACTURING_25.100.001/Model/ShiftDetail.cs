using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.MANUFACTURING_25_100_001.Model
{
	public class ShiftDetail : Entity
	{

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMShift</para>
		/// <para>Display Name: Calendar ID</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// </summary>
		public StringValue? CalendarID { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMShift</para>
		/// <para>Display Name: Crew Size</para>
		/// </summary>
		public DecimalValue? CrewSize { get; set; }

		/// <summary>
		/// <para>DAC Field Name: EPShiftCode__DiffType</para>
		/// <para>DAC: PX.Objects.AM.AMShift</para>
		/// </summary>
		public StringValue? DiffType { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ShftEff</para>
		/// <para>DAC: PX.Objects.AM.AMShift</para>
		/// </summary>
		public DecimalValue? Efficiency { get; set; }

		/// <summary>
		/// <para>DAC Field Name: LaborCodeID</para>
		/// <para>DAC: PX.Objects.AM.AMShift</para>
		/// <para>Display Name: Labor Code</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// </summary>
		public StringValue? LaborCode { get; set; }

		/// <summary>
		/// <para>DAC Field Name: MachNbr</para>
		/// <para>DAC: PX.Objects.AM.AMShift</para>
		/// </summary>
		public DecimalValue? Machines { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ShiftCD</para>
		/// <para>DAC: PX.Objects.AM.AMShift</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// Key Field
		/// </summary>
		public StringValue? Shift { get; set; }

		/// <summary>
		/// <para>DAC Field Name: EPShiftCode__ShftDiff</para>
		/// <para>DAC: PX.Objects.AM.AMShift</para>
		/// </summary>
		public DecimalValue? ShiftDiff { get; set; }

	}
}