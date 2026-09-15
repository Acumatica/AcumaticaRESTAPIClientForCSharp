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
	/// Corresponds to the screen <c>AM202500</c> in the Acumatica ERP
	/// <para>Key Fields: OverheadID</para>
	/// </summary>
	[DataContract]
	public class Overhead : Entity, ITopLevelEntity
	{

		/// <summary>
		/// <para>DAC Field Name: AcctID</para>
		/// <para>DAC: PX.Objects.AM.AMOverhead</para>
		/// </summary>
		[DataMember(Name="Account", EmitDefaultValue=false)]
		public StringValue? Account { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMOverhead</para>
		/// <para>Display Name: Cost Rate</para>
		/// </summary>
		[DataMember(Name="CostRate", EmitDefaultValue=false)]
		public DecimalValue? CostRate { get; set; }

		/// <summary>
		/// <para>DAC Field Name: Descr</para>
		/// <para>DAC: PX.Objects.AM.AMOverhead</para>
		/// <para>SQL Type: nvarchar(256)</para>
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		/// <summary>
		/// <para>DAC Field Name: OvhdID</para>
		/// <para>DAC: PX.Objects.AM.AMOverhead</para>
		/// <para>Display Name: Overhead ID</para>
		/// <para>SQL Type: nvarchar(20)</para>
		/// Key Field
		/// </summary>
		[DataMember(Name="OverheadID", EmitDefaultValue=false)]
		public StringValue? OverheadID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: OvhdType</para>
		/// <para>DAC: PX.Objects.AM.AMOverhead</para>
		/// <para>Display Name: Type</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		[DataMember(Name="OverheadType", EmitDefaultValue=false)]
		public StringValue? OverheadType { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SubID</para>
		/// <para>DAC: PX.Objects.AM.AMOverhead</para>
		/// </summary>
		[DataMember(Name="Subaccount", EmitDefaultValue=false)]
		public StringValue? Subaccount { get; set; }

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