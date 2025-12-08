using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.MANUFACTURING_25_100_001.Model
{
	/// <summary>
	/// Corresponds to the screen <c>AM505000</c> in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class RegenerateMRP : Entity, ITopLevelEntity
	{

		/// <summary>
		/// <para>DAC Field Name: LastMrpRegenCompletedDateTime</para>
		/// <para>DAC: PX.Objects.AM.MrpProcessingSetup</para>
		/// <para>Display Name: Last Completed At</para>
		/// </summary>
		[DataMember(Name="LastCompletedAt", EmitDefaultValue=false)]
		public DateTimeValue? LastCompletedAt { get; set; }

		/// <summary>
		/// <para>DAC Field Name: LastMrpRegenCompletedByID</para>
		/// <para>DAC: PX.Objects.AM.MrpProcessingSetup</para>
		/// <para>Display Name: Last Completed By</para>
		/// </summary>
		[DataMember(Name="LastCompletedBy", EmitDefaultValue=false)]
		public StringValue? LastCompletedBy { get; set; }

		[DataMember(Name="Messages", EmitDefaultValue=false)]
		public List<RegenerateMRPMessage>? Messages { get; set; }

		public static class Expand
		{
			public const string Files = "Files";
			public const string Messages = "Messages";
			public const string Messages_Files = "Messages/Files";

			//Intentionally excluded
			//public const string All = "Files,Messages,Messages/Files";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/MANUFACTURING/25.100.001";
		}
	}
}