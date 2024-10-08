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
	/// Corresponds to the screen GL404001 in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class AccountDetailsForPeriodInquiry : Entity, ITopLevelEntity
	{

		/// <summary>
		/// DAC: PX.Data.GenericFilter 
		/// </summary>
		[DataMember(Name="FromPeriod", EmitDefaultValue=false)]
		public StringValue? FromPeriod { get; set; }

		/// <summary>
		/// DAC: PX.Data.GenericFilter 
		/// </summary>
		[DataMember(Name="Ledger", EmitDefaultValue=false)]
		public StringValue? Ledger { get; set; }

		[DataMember(Name="Results", EmitDefaultValue=false)]
		public List<AccountDetailsForPeriodInquiryDetail>? Results { get; set; }

		/// <summary>
		/// DAC: PX.Data.GenericFilter 
		/// </summary>
		[DataMember(Name="ToPeriod", EmitDefaultValue=false)]
		public StringValue? ToPeriod { get; set; }

		/// <summary>
		/// DAC: PX.Data.GenericFilter 
		/// </summary>
		[DataMember(Name="IncludeUnposted", EmitDefaultValue=false)]
		public BooleanValue? IncludeUnposted { get; set; }

		/// <summary>
		/// DAC: PX.Data.GenericFilter 
		/// </summary>
		[DataMember(Name="IncludeUnreleased", EmitDefaultValue=false)]
		public BooleanValue? IncludeUnreleased { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/Default/23.200.001";
		}
	}
}