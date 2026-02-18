using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Manufacturing_24_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen <c>AM505000</c> in the Acumatica ERP
	/// </summary>
	public class RegenerateMRP : Entity, ITopLevelEntity
	{

		/// <summary>
		/// <para>DAC Field Name: LastMrpRegenCompletedDateTime</para>
		/// <para>DAC: PX.Objects.AM.MrpProcessingSetup</para>
		/// <para>Display Name: Last Completed At</para>
		/// </summary>
		public DateTimeValue? LastCompletedAt { get; set; }

		/// <summary>
		/// <para>DAC Field Name: LastMrpRegenCompletedByID</para>
		/// <para>DAC: PX.Objects.AM.MrpProcessingSetup</para>
		/// <para>Display Name: Last Completed By</para>
		/// </summary>
		public StringValue? LastCompletedBy { get; set; }

		public List<RegenerateMRPMessage>? Messages { get; set; }

		public static class Expand
		{
			public const string Files = "Files";
			public const string Translations = "Translations";
			public const string Messages = "Messages";
			public const string Messages_Files = "Messages/Files";

			//Intentionally excluded
			//public const string All = "Files,Translations,Messages,Messages/Files";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/MANUFACTURING/24.200.001";
		}
	}
}