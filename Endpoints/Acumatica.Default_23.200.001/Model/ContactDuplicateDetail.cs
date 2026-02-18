using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_23_200_001.Model
{
	public class ContactDuplicateDetail : Entity
	{

		/// <summary>
		/// <para>DAC Field Name: DuplicateContact__BAccountID</para>
		/// <para>DAC: PX.Objects.CR.Extensions.CRDuplicateEntities.CRDuplicateRecord</para>
		/// </summary>
		public StringValue? BusinessAccount { get; set; }

		/// <summary>
		/// <para>DAC Field Name: BAccountR__AcctName</para>
		/// <para>DAC: PX.Objects.CR.Extensions.CRDuplicateEntities.CRDuplicateRecordForLinking</para>
		/// </summary>
		public StringValue? BusinessAccountName { get; set; }

		/// <summary>
		/// <para>DAC Field Name: BAccountR__Type</para>
		/// <para>DAC: PX.Objects.CR.Extensions.CRDuplicateEntities.CRDuplicateRecord</para>
		/// </summary>
		public StringValue? BusinessAccountType { get; set; }

		/// <summary>
		/// <para>DAC Field Name: DuplicateContact__DisplayName</para>
		/// <para>DAC: PX.Objects.CR.Extensions.CRDuplicateEntities.CRDuplicateRecord</para>
		/// </summary>
		public StringValue? DisplayName { get; set; }

		public StringValue? Duplicate { get; set; }

		/// <summary>
		/// <para>DAC Field Name: DuplicateContact__Email</para>
		/// <para>DAC: PX.Objects.CR.Extensions.CRDuplicateEntities.CRDuplicateRecordForLinking</para>
		/// </summary>
		public StringValue? Email { get; set; }

		/// <summary>
		/// <para>DAC Field Name: DuplicateContact__LastModifiedDateTime</para>
		/// <para>DAC: PX.Objects.CR.Extensions.CRDuplicateEntities.CRDuplicateRecord</para>
		/// </summary>
		public DateTimeValue? LastModifiedDate { get; set; }

		/// <summary>
		/// <para>DAC Field Name: DuplicateContact__ContactType</para>
		/// <para>DAC: PX.Objects.CR.Extensions.CRDuplicateEntities.CRDuplicateRecordForLinking</para>
		/// </summary>
		public StringValue? Type { get; set; }

	}
}