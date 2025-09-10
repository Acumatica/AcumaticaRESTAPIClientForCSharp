using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_24_200_001.Model
{
	[DataContract]
	public class ReportingGroup : Entity
	{

		/// <summary>
		/// The type of the reporting group.
		/// DAC Field Name: BucketType 
		/// DAC: PX.Objects.TX.TaxBucket 
		/// Display Name: Group Type 
		/// SQL Type: char(1) 
		/// </summary>
		[DataMember(Name="GroupType", EmitDefaultValue=false)]
		public StringValue? GroupType { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? LastModifiedDateTime { get; set; }

		/// <summary>
		/// The name of the reporting group, which can be specified by the user.
		/// DAC: PX.Objects.TX.TaxBucket 
		/// SQL Type: nvarchar(60) 
		/// </summary>
		[DataMember(Name="Name", EmitDefaultValue=false)]
		public StringValue? Name { get; set; }

	}
}