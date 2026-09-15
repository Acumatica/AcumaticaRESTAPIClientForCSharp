using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Manufacturing_26_200_001.Model
{
	[DataContract]
	public class WorkCenterOverheadDetail : Entity
	{

		/// <summary>
		/// <para>DAC Field Name: AMOverhead__Descr</para>
		/// <para>DAC: PX.Objects.AM.AMWCOvhd</para>
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		/// <summary>
		/// <para>DAC Field Name: OFactor</para>
		/// <para>DAC: PX.Objects.AM.AMWCOvhd</para>
		/// </summary>
		[DataMember(Name="Factor", EmitDefaultValue=false)]
		public DecimalValue? Factor { get; set; }

		/// <summary>
		/// <para>DAC Field Name: OvhdID</para>
		/// <para>DAC: PX.Objects.AM.AMWCOvhd</para>
		/// <para>Display Name: Overhead ID</para>
		/// <para>SQL Type: nvarchar(20)</para>
		/// Key Field
		/// </summary>
		[DataMember(Name="Overhead", EmitDefaultValue=false)]
		public StringValue? Overhead { get; set; }

		/// <summary>
		/// <para>DAC Field Name: AMOverhead__OvhdType</para>
		/// <para>DAC: PX.Objects.AM.AMWCOvhd</para>
		/// </summary>
		[DataMember(Name="Type", EmitDefaultValue=false)]
		public StringValue? Type { get; set; }

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