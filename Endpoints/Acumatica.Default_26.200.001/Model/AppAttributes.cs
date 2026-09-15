using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_26_200_001.Model
{
	[DataContract]
	public class AppAttributes : Entity
	{

		/// <summary>
		/// <para>DAC Field Name: AttributeID</para>
		/// <para>DAC: PX.Objects.CS.CSAnswers</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// Key Field
		/// </summary>
		[DataMember(Name="Attribute", EmitDefaultValue=false)]
		public StringValue? Attribute { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.FS.FSApptLineSplit</para>
		/// <para>Display Name: Related Document</para>
		/// </summary>
		[DataMember(Name="RefNoteID", EmitDefaultValue=false)]
		public GuidValue? RefNoteID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: isRequired</para>
		/// <para>DAC: PX.Objects.CS.CSAnswers</para>
		/// </summary>
		[DataMember(Name="Required", EmitDefaultValue=false)]
		public BooleanValue? Required { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.CS.CSAnswers</para>
		/// <para>SQL Type: nvarchar(255)</para>
		/// </summary>
		[DataMember(Name="Value", EmitDefaultValue=false)]
		public StringValue? Value { get; set; }

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

			//Intentionally excluded
			//public const string All = "Files";
		}
	}
}