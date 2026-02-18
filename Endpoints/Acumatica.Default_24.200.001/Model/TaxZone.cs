using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_24_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen <c>TX206000</c> in the Acumatica ERP
	/// <para>Key Fields: TaxZoneID</para>
	/// </summary>
	public class TaxZone : Entity, ITopLevelEntity
	{

		public List<TaxZoneApplicableTaxDetail>? ApplicableTaxes { get; set; }

		public DateTimeValue? CreatedDateTime { get; set; }

		/// <summary>
		/// The description of the tax zone, which can be specified by the user.
		/// <para>DAC Field Name: Descr</para>
		/// <para>DAC: PX.Objects.TX.TaxZone</para>
		/// <para>SQL Type: nvarchar(60)</para>
		/// </summary>
		public StringValue? Description { get; set; }

		public DateTimeValue? LastModifiedDateTime { get; set; }

		/// <summary>
		/// A key field, which can be specified by the user.
		/// <para>DAC: PX.Objects.TX.TaxZone</para>
		/// <para>Display Name: Tax Zone ID</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// Key Field
		/// </summary>
		public StringValue? TaxZoneID { get; set; }

		public static class Expand
		{
			public const string Files = "Files";
			public const string Translations = "Translations";
			public const string ApplicableTaxes = "ApplicableTaxes";
			public const string ApplicableTaxes_Files = "ApplicableTaxes/Files";

			//Intentionally excluded
			//public const string All = "Files,Translations,ApplicableTaxes,ApplicableTaxes/Files";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/Default/24.200.001";
		}
	}
}