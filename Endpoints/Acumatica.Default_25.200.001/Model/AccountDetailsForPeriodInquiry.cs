using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_25_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen <c>GL404001</c> in the Acumatica ERP
	/// </summary>
	public class AccountDetailsForPeriodInquiry : Entity, ITopLevelEntity
	{

		/// <summary>
		/// <para>DAC: PX.Data.GenericFilter</para>
		/// </summary>
		public StringValue? FromPeriod { get; set; }

		/// <summary>
		/// <para>DAC: PX.Data.GenericFilter</para>
		/// </summary>
		public StringValue? Ledger { get; set; }

		public List<AccountDetailsForPeriodInquiryDetail>? Results { get; set; }

		/// <summary>
		/// <para>DAC: PX.Data.GenericFilter</para>
		/// </summary>
		public StringValue? ToPeriod { get; set; }

		/// <summary>
		/// <para>DAC: PX.Data.GenericFilter</para>
		/// </summary>
		public BooleanValue? IncludeUnposted { get; set; }

		/// <summary>
		/// <para>DAC: PX.Data.GenericFilter</para>
		/// </summary>
		public BooleanValue? IncludeUnreleased { get; set; }

		public static class Expand
		{
			public const string Files = "Files";
			public const string Translations = "Translations";
			public const string Results = "Results";
			public const string Results_Files = "Results/Files";

			//Intentionally excluded
			//public const string All = "Files,Translations,Results,Results/Files";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/Default/25.200.001";
		}
	}
}