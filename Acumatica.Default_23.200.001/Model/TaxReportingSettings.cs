using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_23_200_001.Model
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
		/// 
		/// Display Name:
		/// DAC Field Name: VendorID 
		/// DAC: PX.Objects.TX.TaxReport 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="TaxAgency", EmitDefaultValue=false)]
		public StringValue? TaxAgency { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/Default/23.200.001";
		}
	}
}