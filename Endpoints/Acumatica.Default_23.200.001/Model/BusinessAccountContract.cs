using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_23_200_001.Model
{
	public class BusinessAccountContract : Entity
	{

		/// <summary>
		/// <para>DAC Field Name: BAccount__AcctCD</para>
		/// <para>DAC: PX.Objects.CR.CROpportunity</para>
		/// </summary>
		public StringValue? BusinessAccountID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: BAccount__AcctName</para>
		/// <para>DAC: PX.Objects.CR.CROpportunity</para>
		/// </summary>
		public StringValue? BusinessAccountName { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ContractCD</para>
		/// <para>DAC: PX.Objects.CT.Contract</para>
		/// <para>Display Name: Contract ID</para>
		/// <para>SQL Type: nvarchar(30)</para>
		/// Key Field
		/// </summary>
		public StringValue? ContractID { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.CT.Contract</para>
		/// <para>SQL Type: nvarchar(255)</para>
		/// </summary>
		public StringValue? Description { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ExpireDate</para>
		/// <para>DAC: PX.Objects.CT.Contract</para>
		/// <para>Display Name: Expiration Date</para>
		/// </summary>
		public DateTimeValue? ExpirationDate { get; set; }

		public StringValue? Location { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.CR.BAccount</para>
		/// <para>Display Name: Customer Status</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		public StringValue? Status { get; set; }

	}
}