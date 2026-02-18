using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.GLConsolidation_22_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen <c>GL509001</c> in the Acumatica ERP
	/// </summary>
	public class ConsolidationData : Entity, ITopLevelEntity
	{

		/// <summary>
		/// <para>DAC: PX.Objects.GL.Consolidation.ConsolSourceDataMaint+ConsolRecordsFilter</para>
		/// </summary>
		public StringValue? BranchCD { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.GL.Consolidation.ConsolSourceDataMaint+ConsolRecordsFilter</para>
		/// </summary>
		public StringValue? LedgerCD { get; set; }

		public List<ConsolidationItem>? Result { get; set; }

		public static class Expand
		{
			public const string Files = "Files";
			public const string Translations = "Translations";
			public const string Result = "Result";
			public const string Result_Files = "Result/Files";

			//Intentionally excluded
			//public const string All = "Files,Translations,Result,Result/Files";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/GLConsolidation/22.200.001";
		}
	}
}