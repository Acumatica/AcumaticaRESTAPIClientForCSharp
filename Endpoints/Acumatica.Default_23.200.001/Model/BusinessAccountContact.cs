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
	public class BusinessAccountContact : Entity
	{

		/// <summary>
		/// This field indicates whether the location is active.
		/// DAC Field Name: IsActive 
		/// DAC: PX.Objects.CR.Standalone.Location 
		/// </summary>
		[DataMember(Name="Active", EmitDefaultValue=false)]
		public BooleanValue? Active { get; set; }

		/// <summary>
		/// DAC Field Name: Address__City 
		/// DAC: PX.Objects.CR.Standalone.Location 
		/// </summary>
		[DataMember(Name="City", EmitDefaultValue=false)]
		public StringValue? City { get; set; }

		/// <summary>
		/// The identifier of the contact.This field is the key field.
		/// DAC: PX.Objects.CR.Contact 
		/// Display Name: Contact ID 
		/// Key Field
		/// </summary>
		[DataMember(Name="ContactID", EmitDefaultValue=false)]
		public IntValue? ContactID { get; set; }

		/// <summary>
		/// The display name of the contact.Its value is made up of the LastName, FirstName, MidName, andTitle values. The format depends on the PersonNameFormat site setting.
		/// DAC: PX.Objects.CR.Contact 
		/// Display Name: Contact 
		/// SQL Type: nvarchar(255) 
		/// </summary>
		/// <remarks>
		/// This field is changed when the fields it depends on are changed.
		/// </remarks>
		[DataMember(Name="DisplayName", EmitDefaultValue=false)]
		public StringValue? DisplayName { get; set; }

		/// <summary>
		/// The email address of the contact.
		/// DAC Field Name: EMail 
		/// DAC: PX.Objects.CR.Contact 
		/// SQL Type: nvarchar(255) 
		/// </summary>
		[DataMember(Name="Email", EmitDefaultValue=false)]
		public StringValue? Email { get; set; }

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
		/// The identifier of the user responsible for the current document.If the WorkgroupID is specified, only a user that belongsto the specified workgroup can be used.
		/// DAC Field Name: OwnerID 
		/// DAC: PX.Objects.CR.BAccount 
		/// </summary>
		[DataMember(Name="Owner", EmitDefaultValue=false)]
		public StringValue? Owner { get; set; }

		/// <summary>
		/// The phone number.
		/// DAC: PX.Objects.CR.Contact 
		/// Display Name: Phone 1 
		/// SQL Type: nvarchar(50) 
		/// </summary>
		[DataMember(Name="Phone1", EmitDefaultValue=false)]
		public StringValue? Phone1 { get; set; }

		/// <summary>
		/// DAC Field Name: ContactType 
		/// DAC: PX.Objects.CS.NotificationRecipient 
		/// Display Name: Contact Type 
		/// SQL Type: char(1) 
		/// </summary>
		[DataMember(Name="Type", EmitDefaultValue=false)]
		public StringValue? Type { get; set; }

		/// <summary>
		/// The identifier of the workgroup responsible for the current document.
		/// DAC Field Name: WorkgroupID 
		/// DAC: PX.Objects.CR.BAccount 
		/// </summary>
		[DataMember(Name="Workgroup", EmitDefaultValue=false)]
		public StringValue? Workgroup { get; set; }

	}
}