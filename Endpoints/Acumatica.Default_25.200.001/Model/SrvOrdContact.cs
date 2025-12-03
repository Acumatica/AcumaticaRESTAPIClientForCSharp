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
	public class SrvOrdContact : Entity
	{

		/// <summary>
		/// <para>DAC: PX.Objects.FS.FSContact</para>
		/// <para>SQL Type: nvarchar(255)</para>
		/// </summary>
		[DataMember(Name="Attention", EmitDefaultValue=false)]
		public StringValue? Attention { get; set; }

		/// <summary>
		/// <para>DAC Field Name: FullName</para>
		/// <para>DAC: PX.Objects.FS.FSContact</para>
		/// <para>Display Name: Account Name</para>
		/// <para>SQL Type: nvarchar(255)</para>
		/// </summary>
		[DataMember(Name="CompanyName", EmitDefaultValue=false)]
		public StringValue? CompanyName { get; set; }

		/// <summary>
		/// <para>DAC Field Name: EMail</para>
		/// <para>DAC: PX.Objects.FS.FSContact</para>
		/// <para>SQL Type: varchar(255)</para>
		/// </summary>
		[DataMember(Name="Email", EmitDefaultValue=false)]
		public StringValue? Email { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.FS.FSContact</para>
		/// <para>Display Name: Phone 1</para>
		/// <para>SQL Type: varchar(50)</para>
		/// </summary>
		[DataMember(Name="Phone1", EmitDefaultValue=false)]
		public StringValue? Phone1 { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.FS.FSContact</para>
		/// <para>Display Name: Phone 1 Type</para>
		/// <para>SQL Type: varchar(3)</para>
		/// </summary>
		[DataMember(Name="Phone1Type", EmitDefaultValue=false)]
		public StringValue? Phone1Type { get; set; }

	}
}