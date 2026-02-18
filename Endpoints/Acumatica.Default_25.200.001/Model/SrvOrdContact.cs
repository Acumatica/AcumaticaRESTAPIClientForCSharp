using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_25_200_001.Model
{
	public class SrvOrdContact : Entity
	{

		/// <summary>
		/// <para>DAC: PX.Objects.FS.FSContact</para>
		/// <para>SQL Type: nvarchar(255)</para>
		/// </summary>
		public StringValue? Attention { get; set; }

		/// <summary>
		/// <para>DAC Field Name: FullName</para>
		/// <para>DAC: PX.Objects.FS.FSContact</para>
		/// <para>Display Name: Account Name</para>
		/// <para>SQL Type: nvarchar(255)</para>
		/// </summary>
		public StringValue? CompanyName { get; set; }

		/// <summary>
		/// <para>DAC Field Name: EMail</para>
		/// <para>DAC: PX.Objects.FS.FSContact</para>
		/// <para>SQL Type: varchar(255)</para>
		/// </summary>
		public StringValue? Email { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.FS.FSContact</para>
		/// <para>Display Name: Phone 1</para>
		/// <para>SQL Type: varchar(50)</para>
		/// </summary>
		public StringValue? Phone1 { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.FS.FSContact</para>
		/// <para>Display Name: Phone 1 Type</para>
		/// <para>SQL Type: varchar(3)</para>
		/// </summary>
		public StringValue? Phone1Type { get; set; }

	}
}