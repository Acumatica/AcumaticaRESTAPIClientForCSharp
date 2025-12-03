using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_24_200_001.Model
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

		public static class Expand
		{
			public const string Files = "Files";
			public const string ReportingGroups = "ReportingGroups";
			public const string ReportingGroups_Files = "ReportingGroups/Files";

			//Intentionally excluded
			//public const string All = "Files,ReportingGroups,ReportingGroups/Files";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/Default/24.200.001";
		}
	}
}