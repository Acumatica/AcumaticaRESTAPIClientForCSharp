using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_26_200_001.Model
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
		/// <para>SQL Type: nvarchar(256)</para>
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
		public StringSingleSelectValue? Status { get; set; }

		/// <summary>
		/// Names that can be passed in the <c>$expand</c> parameter.
		/// <para>This endpoint uses system contract 5, where a nested entity is expanded
		/// as <c>Parent($expand=Child)</c> rather than <c>Parent/Child</c>, so only the names
		/// that can be expanded directly on this entity are listed here. Use the nested
		/// entity's own <c>Expand</c> class for the inner names.</para>
		/// </summary>
		public static class Expand
		{
			public const string Files = "Files";

			//Intentionally excluded
			//public const string All = "Files";
		}
	}
}