using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_25_200_001.Model
{
	[DataContract]
	public class ReportingGroup : Entity
	{

		/// <summary>
		/// The type of the reporting group.
		/// <para>DAC Field Name: BucketType</para>
		/// <para>DAC: PX.Objects.TX.TaxBucket</para>
		/// <para>Display Name: Group Type</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		[DataMember(Name="GroupType", EmitDefaultValue=false)]
		public StringValue? GroupType { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? LastModifiedDateTime { get; set; }

		/// <summary>
		/// The name of the reporting group, which can be specified by the user.
		/// <para>DAC: PX.Objects.TX.TaxBucket</para>
		/// <para>SQL Type: nvarchar(60)</para>
		/// </summary>
		[DataMember(Name="Name", EmitDefaultValue=false)]
		public StringValue? Name { get; set; }

	}
}