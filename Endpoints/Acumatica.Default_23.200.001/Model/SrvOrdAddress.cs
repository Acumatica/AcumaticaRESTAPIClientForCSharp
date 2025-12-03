using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_23_200_001.Model
{
	[DataContract]
	public class SrvOrdAddress : Entity
	{

		/// <summary>
		/// <para>DAC: PX.Objects.FS.FSAddress</para>
		/// <para>Display Name: Address Line 1</para>
		/// <para>SQL Type: nvarchar(70)</para>
		/// </summary>
		[DataMember(Name="AddressLine1", EmitDefaultValue=false)]
		public StringValue? AddressLine1 { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.FS.FSAddress</para>
		/// <para>Display Name: Address Line 2</para>
		/// <para>SQL Type: nvarchar(70)</para>
		/// </summary>
		[DataMember(Name="AddressLine2", EmitDefaultValue=false)]
		public StringValue? AddressLine2 { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.FS.FSAddress</para>
		/// <para>SQL Type: nvarchar(50)</para>
		/// </summary>
		[DataMember(Name="City", EmitDefaultValue=false)]
		public StringValue? City { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CountryID</para>
		/// <para>DAC: PX.Objects.FS.FSAddress</para>
		/// <para>SQL Type: nvarchar(2)</para>
		/// </summary>
		[DataMember(Name="Country", EmitDefaultValue=false)]
		public StringValue? Country { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.FS.FSAddress</para>
		/// <para>Display Name: Postal Code</para>
		/// <para>SQL Type: varchar(20)</para>
		/// </summary>
		[DataMember(Name="PostalCode", EmitDefaultValue=false)]
		public StringValue? PostalCode { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.FS.FSAddress</para>
		/// <para>SQL Type: nvarchar(50)</para>
		/// </summary>
		[DataMember(Name="State", EmitDefaultValue=false)]
		public StringValue? State { get; set; }

	}
}