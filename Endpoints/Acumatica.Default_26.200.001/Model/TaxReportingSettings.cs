using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_26_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen <c>TX205100</c> in the Acumatica ERP
	/// <para>Key Fields: TaxAgency</para>
	/// </summary>
	[DataContract]
	public class TaxReportingSettings : Entity, ITopLevelEntity
	{

		[DataMember(Name="ReportingGroups", EmitDefaultValue=false)]
		public List<ReportingGroup>? ReportingGroups { get; set; }

		/// <summary>
		/// <para>DAC Field Name: VendorID</para>
		/// <para>DAC: PX.Objects.TX.TaxReport</para>
		/// <para>Display Name: Tax Agency</para>
		/// Key Field
		/// </summary>
		[DataMember(Name="TaxAgency", EmitDefaultValue=false)]
		public StringValue? TaxAgency { get; set; }

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
			public const string ReportingGroups = "ReportingGroups";

			//Intentionally excluded
			//public const string All = "Files,Translations,ReportingGroups";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/Default/26.200.001";
		}
	}
}