using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_22_200_001.Model
{
	[DataContract]
	public class BusinessAccountShippingContact : Entity
	{

		/// <summary>
		/// The name of the document recipient (a person or team) used in the documents.
		/// DAC: PX.Objects.CR.Contact 
		/// SQL Type: nvarchar(255) 
		/// </summary>
		/// <remarks>
		/// Not used in primary graph, only in documents, for instance, CROpportunity, SOOrder, and so on.
		/// </remarks>
		[DataMember(Name="Attention", EmitDefaultValue=false)]
		public StringValue? Attention { get; set; }

		/// <summary>
		/// The email address of the contact.
		/// DAC Field Name: EMail 
		/// DAC: PX.Objects.CR.Contact 
		/// SQL Type: nvarchar(255) 
		/// </summary>
		[DataMember(Name="Email", EmitDefaultValue=false)]
		public StringValue? Email { get; set; }

		/// <summary>
		/// The fax number.
		/// DAC: PX.Objects.CR.Contact 
		/// SQL Type: nvarchar(50) 
		/// </summary>
		[DataMember(Name="Fax", EmitDefaultValue=false)]
		public StringValue? Fax { get; set; }

		/// <summary>
		/// The job title of the person.
		/// DAC Field Name: Salutation 
		/// DAC: PX.Objects.CR.Contact 
		/// Display Name: Job Title 
		/// SQL Type: nvarchar(255) 
		/// </summary>
		[DataMember(Name="JobTitle", EmitDefaultValue=false)]
		public StringValue? JobTitle { get; set; }

		/// <summary>
		/// The phone number.
		/// DAC: PX.Objects.CR.Contact 
		/// Display Name: Phone 1 
		/// SQL Type: nvarchar(50) 
		/// </summary>
		[DataMember(Name="Phone1", EmitDefaultValue=false)]
		public StringValue? Phone1 { get; set; }

		/// <summary>
		/// The second phone number.
		/// DAC: PX.Objects.CR.Contact 
		/// Display Name: Phone 2 
		/// SQL Type: nvarchar(50) 
		/// </summary>
		[DataMember(Name="Phone2", EmitDefaultValue=false)]
		public StringValue? Phone2 { get; set; }

		/// <summary>
		/// If set to true, indicates that the addressoverrides the default Contact record, which isreferenced by DefContactID.
		/// DAC Field Name: OverrideContact 
		/// DAC: PX.Objects.CR.Standalone.Location 
		/// </summary>
		[DataMember(Name="Override", EmitDefaultValue=false)]
		public BooleanValue? Override { get; set; }

	}
}