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
	public class BusinessAccountContract : Entity
	{

		/// <summary>
		/// <para>DAC Field Name: BAccount__AcctCD</para>
		/// <para>DAC: PX.Objects.CR.CROpportunity</para>
		/// </summary>
		[DataMember(Name="BusinessAccountID", EmitDefaultValue=false)]
		public StringValue? BusinessAccountID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: BAccount__AcctName</para>
		/// <para>DAC: PX.Objects.CR.CROpportunity</para>
		/// </summary>
		[DataMember(Name="BusinessAccountName", EmitDefaultValue=false)]
		public StringValue? BusinessAccountName { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ContractCD</para>
		/// <para>DAC: PX.Objects.CT.Contract</para>
		/// <para>Display Name: Contract ID</para>
		/// <para>SQL Type: nvarchar(30)</para>
		/// Key Field
		/// </summary>
		[DataMember(Name="ContractID", EmitDefaultValue=false)]
		public StringValue? ContractID { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.CT.Contract</para>
		/// <para>SQL Type: nvarchar(255)</para>
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ExpireDate</para>
		/// <para>DAC: PX.Objects.CT.Contract</para>
		/// <para>Display Name: Expiration Date</para>
		/// </summary>
		[DataMember(Name="ExpirationDate", EmitDefaultValue=false)]
		public DateTimeValue? ExpirationDate { get; set; }

		[DataMember(Name="Location", EmitDefaultValue=false)]
		public StringValue? Location { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.CR.BAccount</para>
		/// <para>Display Name: Customer Status</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		[DataMember(Name="Status", EmitDefaultValue=false)]
		public StringValue? Status { get; set; }

	}
}