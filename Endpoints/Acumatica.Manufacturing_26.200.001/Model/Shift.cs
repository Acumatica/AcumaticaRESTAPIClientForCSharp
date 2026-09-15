using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Manufacturing_26_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen <c>AM205000</c> in the Acumatica ERP
	/// <para>Key Fields: Shift</para>
	/// </summary>
	[DataContract]
	public class Shift : Entity, ITopLevelEntity
	{

		/// <summary>
		/// <para>DAC Field Name: AMCrewSize</para>
		/// <para>DAC: PX.Objects.EP.EPShiftCode</para>
		/// <para>Display Name: Crew Size</para>
		/// </summary>
		[DataMember(Name="CrewSize", EmitDefaultValue=false)]
		public DecimalValue? CrewSize { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.EP.EPShiftCode</para>
		/// <para>SQL Type: nvarchar(256)</para>
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.EP.EPShiftCode</para>
		/// <para>Display Name: Differential Type</para>
		/// <para>SQL Type: nchar(1)</para>
		/// </summary>
		[DataMember(Name="DiffType", EmitDefaultValue=false)]
		public StringValue? DiffType { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ShiftCD</para>
		/// <para>DAC: PX.Objects.EP.EPShiftCode</para>
		/// <para>Display Name: Code</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// Key Field
		/// </summary>
		[DataMember(Name="shift", EmitDefaultValue=false)]
		public StringValue? shift { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ShftDiff</para>
		/// <para>DAC: PX.Objects.EP.EPShiftCode</para>
		/// <para>Display Name: Shift Differential</para>
		/// </summary>
		[DataMember(Name="ShiftDiff", EmitDefaultValue=false)]
		public DecimalValue? ShiftDiff { get; set; }

		/// <summary>
		/// Names that can be passed in the <c>$expand</c> parameter.
		/// <para>This endpoint uses system contract 5, where a nested entity is expanded
		/// as <c>Parent($expand=Child)</c> rather than <c>Parent/Child</c>, so only the names
		/// that can be expanded directly on this entity are listed here. Use the nested
		/// entity's own <c>Expand</c> class for the inner names.</para>
		/// </summary>
		public static class Expand
		{
			public const string Files = "Files";
			public const string Translations = "Translations";

			//Intentionally excluded
			//public const string All = "Files,Translations";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/MANUFACTURING/26.200.001";
		}
	}
}