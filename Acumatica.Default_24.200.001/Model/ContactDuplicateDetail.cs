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
		/// DAC Field Name: DuplicateContact__BAccountID 
		/// DAC: PX.Objects.CR.Extensions.CRDuplicateEntities.CRDuplicateRecord 
		/// </summary>
		[DataMember(Name="BusinessAccount", EmitDefaultValue=false)]
		public StringValue? BusinessAccount { get; set; }

		/// <summary>
		/// DAC Field Name: BAccountR__AcctName 
		/// DAC: PX.Objects.CR.Extensions.CRDuplicateEntities.CRDuplicateRecordForLinking 
		/// </summary>
		[DataMember(Name="BusinessAccountName", EmitDefaultValue=false)]
		public StringValue? BusinessAccountName { get; set; }

		/// <summary>
		/// DAC Field Name: BAccountR__Type 
		/// DAC: PX.Objects.CR.Extensions.CRDuplicateEntities.CRDuplicateRecord 
		/// </summary>
		[DataMember(Name="BusinessAccountType", EmitDefaultValue=false)]
		public StringValue? BusinessAccountType { get; set; }

		/// <summary>
		/// DAC Field Name: DuplicateContact__DisplayName 
		/// DAC: PX.Objects.CR.Extensions.CRDuplicateEntities.CRDuplicateRecord 
		/// </summary>
		[DataMember(Name="DisplayName", EmitDefaultValue=false)]
		public StringValue? DisplayName { get; set; }

		[DataMember(Name="Duplicate", EmitDefaultValue=false)]
		public StringValue? Duplicate { get; set; }

		/// <summary>
		/// DAC Field Name: DuplicateContact__Email 
		/// DAC: PX.Objects.CR.Extensions.CRDuplicateEntities.CRDuplicateRecordForLinking 
		/// </summary>
		[DataMember(Name="Email", EmitDefaultValue=false)]
		public StringValue? Email { get; set; }

		/// <summary>
		/// DAC Field Name: DuplicateContact__LastModifiedDateTime 
		/// DAC: PX.Objects.CR.Extensions.CRDuplicateEntities.CRDuplicateRecord 
		/// </summary>
		[DataMember(Name="LastModifiedDate", EmitDefaultValue=false)]
		public DateTimeValue? LastModifiedDate { get; set; }

		/// <summary>
		/// DAC Field Name: DuplicateContact__ContactType 
		/// DAC: PX.Objects.CR.Extensions.CRDuplicateEntities.CRDuplicateRecordForLinking 
		/// </summary>
		[DataMember(Name="Type", EmitDefaultValue=false)]
		public StringValue? Type { get; set; }

	}
}