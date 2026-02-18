using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Manufacturing_24_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen <c>AM205000</c> in the Acumatica ERP
	/// <para>Key Fields: Shift</para>
	/// </summary>
	public class Shift : Entity, ITopLevelEntity
	{

		/// <summary>
		/// <para>DAC Field Name: AMCrewSize</para>
		/// <para>DAC: PX.Objects.EP.EPShiftCode</para>
		/// </summary>
		public DecimalValue? CrewSize { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.EP.EPShiftCode</para>
		/// <para>SQL Type: nvarchar(256)</para>
		/// </summary>
		public StringValue? Description { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.EP.EPShiftCode</para>
		/// </summary>
		public StringValue? DiffType { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ShiftCD</para>
		/// <para>DAC: PX.Objects.EP.EPShiftCode</para>
		/// <para>Display Name: Code</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// Key Field
		/// </summary>
		public StringValue? shift { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ShftDiff</para>
		/// <para>DAC: PX.Objects.EP.EPShiftCode</para>
		/// </summary>
		public DecimalValue? ShiftDiff { get; set; }

		public static class Expand
		{
			public const string Files = "Files";
			public const string Translations = "Translations";

			//Intentionally excluded
			//public const string All = "Files,Translations";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/MANUFACTURING/24.200.001";
		}
	}
}