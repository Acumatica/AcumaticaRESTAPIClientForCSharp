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
	public class AttributeDefinitionValue : Entity
	{

		/// <summary>
		/// <para>DAC: PX.Objects.CS.CSAttribute</para>
		/// <para>SQL Type: nvarchar(60)</para>
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.CS.CSAttributeDetail</para>
		/// </summary>
		[DataMember(Name="Disabled", EmitDefaultValue=false)]
		public BooleanValue? Disabled { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.CS.CSAttributeDetail</para>
		/// <para>Display Name: Sort Order</para>
		/// </summary>
		[DataMember(Name="SortOrder", EmitDefaultValue=false)]
		public ShortValue? SortOrder { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.CS.CSAttributeDetail</para>
		/// <para>Display Name: Value ID</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// Key Field
		/// </summary>
		[DataMember(Name="ValueID", EmitDefaultValue=false)]
		public StringValue? ValueID { get; set; }

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