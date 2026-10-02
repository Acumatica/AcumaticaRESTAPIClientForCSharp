using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_26_200_001.Model
{
	public class ContactDuplicateDetail : Entity
	{

		#region Fields
		/// <summary>
		/// <para>DAC Field Name: DuplicateContact__DisplayName</para>
		/// <para>DAC: PX.Objects.CR.Extensions.CRDuplicateEntities.CRDuplicateRecord</para>
		/// </summary>
		public StringValue? DisplayName { get; set; }

		/// <summary>
		/// <para>DAC Field Name: DuplicateContact__BAccountID</para>
		/// <para>DAC: PX.Objects.CR.Extensions.CRDuplicateEntities.CRDuplicateRecord</para>
		/// </summary>
		public StringValue? BusinessAccount { get; set; }

		/// <summary>
		/// <para>DAC Field Name: BAccountR__Type</para>
		/// <para>DAC: PX.Objects.CR.Extensions.CRDuplicateEntities.CRDuplicateRecord</para>
		/// </summary>
		public StringValue? BusinessAccountType { get; set; }

		/// <summary>
		/// <para>DAC Field Name: DuplicateContact__LastModifiedDateTime</para>
		/// <para>DAC: PX.Objects.CR.Extensions.CRDuplicateEntities.CRDuplicateRecord</para>
		/// </summary>
		public DateTimeValue? LastModifiedDateTime { get; set; }

		/// <summary>
		/// <para>DAC Field Name: DuplicateContact__ContactType</para>
		/// <para>DAC: PX.Objects.CR.Extensions.CRDuplicateEntities.CRDuplicateRecordForLinking</para>
		/// </summary>
		public StringValue? Type { get; set; }

		/// <summary>
		/// <para>DAC Field Name: DuplicateContact__Email</para>
		/// <para>DAC: PX.Objects.CR.Extensions.CRDuplicateEntities.CRDuplicateRecordForLinking</para>
		/// </summary>
		public StringValue? Email { get; set; }

		/// <summary>
		/// <para>DAC Field Name: BAccountR__AcctName</para>
		/// <para>DAC: PX.Objects.CR.Extensions.CRDuplicateEntities.CRDuplicateRecordForLinking</para>
		/// </summary>
		public StringValue? BusinessAccountName { get; set; }

		public StringValue? Duplicate { get; set; }

		#endregion

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