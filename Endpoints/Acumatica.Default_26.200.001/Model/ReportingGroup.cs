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
	public class ReportingGroup : Entity
	{

		/// <summary>
		/// The type of the reporting group.
		/// <para>DAC Field Name: BucketType</para>
		/// <para>DAC: PX.Objects.TX.TaxBucket</para>
		/// <para>Display Name: Group Type</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		[DataMember(Name="GroupType", EmitDefaultValue=false)]
		public StringValue? GroupType { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? LastModifiedDateTime { get; set; }

		/// <summary>
		/// The name of the reporting group, which can be specified by the user.
		/// <para>DAC: PX.Objects.TX.TaxBucket</para>
		/// <para>SQL Type: nvarchar(60)</para>
		/// </summary>
		[DataMember(Name="Name", EmitDefaultValue=false)]
		public StringValue? Name { get; set; }

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