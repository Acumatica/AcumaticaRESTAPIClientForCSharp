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
	public class ContactDuplicateDetail : Entity
	{

		/// <summary>
		/// <para>DAC Field Name: DuplicateContact__BAccountID</para>
		/// <para>DAC: PX.Objects.CR.Extensions.CRDuplicateEntities.CRDuplicateRecord</para>
		/// </summary>
		[DataMember(Name="BusinessAccount", EmitDefaultValue=false)]
		public StringValue? BusinessAccount { get; set; }

		/// <summary>
		/// <para>DAC Field Name: BAccountR__AcctName</para>
		/// <para>DAC: PX.Objects.CR.Extensions.CRDuplicateEntities.CRDuplicateRecordForLinking</para>
		/// </summary>
		[DataMember(Name="BusinessAccountName", EmitDefaultValue=false)]
		public StringValue? BusinessAccountName { get; set; }

		/// <summary>
		/// <para>DAC Field Name: BAccountR__Type</para>
		/// <para>DAC: PX.Objects.CR.Extensions.CRDuplicateEntities.CRDuplicateRecord</para>
		/// </summary>
		[DataMember(Name="BusinessAccountType", EmitDefaultValue=false)]
		public StringValue? BusinessAccountType { get; set; }

		/// <summary>
		/// <para>DAC Field Name: DuplicateContact__DisplayName</para>
		/// <para>DAC: PX.Objects.CR.Extensions.CRDuplicateEntities.CRDuplicateRecord</para>
		/// </summary>
		[DataMember(Name="DisplayName", EmitDefaultValue=false)]
		public StringValue? DisplayName { get; set; }

		[DataMember(Name="Duplicate", EmitDefaultValue=false)]
		public StringValue? Duplicate { get; set; }

		/// <summary>
		/// <para>DAC Field Name: DuplicateContact__Email</para>
		/// <para>DAC: PX.Objects.CR.Extensions.CRDuplicateEntities.CRDuplicateRecordForLinking</para>
		/// </summary>
		[DataMember(Name="Email", EmitDefaultValue=false)]
		public StringValue? Email { get; set; }

		/// <summary>
		/// <para>DAC Field Name: DuplicateContact__LastModifiedDateTime</para>
		/// <para>DAC: PX.Objects.CR.Extensions.CRDuplicateEntities.CRDuplicateRecord</para>
		/// </summary>
		[DataMember(Name="LastModifiedDate", EmitDefaultValue=false)]
		public DateTimeValue? LastModifiedDate { get; set; }

		/// <summary>
		/// <para>DAC Field Name: DuplicateContact__ContactType</para>
		/// <para>DAC: PX.Objects.CR.Extensions.CRDuplicateEntities.CRDuplicateRecordForLinking</para>
		/// </summary>
		[DataMember(Name="Type", EmitDefaultValue=false)]
		public StringValue? Type { get; set; }

	}
}