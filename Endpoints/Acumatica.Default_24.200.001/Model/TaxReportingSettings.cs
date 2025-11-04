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
	/// Corresponds to the screen TX205100 in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class TaxReportingSettings : Entity, ITopLevelEntity
	{

		[DataMember(Name="ReportingGroups", EmitDefaultValue=false)]
		public List<ReportingGroup>? ReportingGroups { get; set; }

		/// <summary>
		/// DAC Field Name: VendorID 
		/// DAC: PX.Objects.TX.TaxReport 
		/// Display Name: Tax Agency 
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