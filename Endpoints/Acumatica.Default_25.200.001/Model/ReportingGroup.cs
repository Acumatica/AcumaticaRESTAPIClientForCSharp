using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_25_200_001.Model
{
	public class ReportingGroup : Entity
	{

		/// <summary>
		/// The type of the reporting group.
		/// <para>DAC Field Name: BucketType</para>
		/// <para>DAC: PX.Objects.TX.TaxBucket</para>
		/// <para>Display Name: Group Type</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		public StringValue? GroupType { get; set; }

		public DateTimeValue? LastModifiedDateTime { get; set; }

		/// <summary>
		/// The name of the reporting group, which can be specified by the user.
		/// <para>DAC: PX.Objects.TX.TaxBucket</para>
		/// <para>SQL Type: nvarchar(60)</para>
		/// </summary>
		public StringValue? Name { get; set; }

	}
}