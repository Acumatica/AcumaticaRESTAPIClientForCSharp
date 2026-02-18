using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_25_200_001.Model
{
	public class BusinessAccountContact : Entity
	{

		/// <summary>
		/// This field indicates whether the location is active.
		/// <para>DAC Field Name: IsActive</para>
		/// <para>DAC: PX.Objects.CR.Standalone.Location</para>
		/// </summary>
		public BooleanValue? Active { get; set; }

		/// <summary>
		/// <para>DAC Field Name: Address__City</para>
		/// <para>DAC: PX.Objects.CR.Standalone.Location</para>
		/// </summary>
		public StringValue? City { get; set; }

		/// <summary>
		/// The identifier of the contact.This field is the key field.
		/// <para>DAC: PX.Objects.CR.Contact</para>
		/// <para>Display Name: Contact ID</para>
		/// Key Field
		/// </summary>
		public IntValue? ContactID { get; set; }

		/// <summary>
		/// The display name of the contact.Its value is made up of the LastName, FirstName, MidName, andTitle values. The format depends on the PersonNameFormat site setting.
		/// <para>DAC: PX.Objects.CR.Contact</para>
		/// <para>Display Name: Contact</para>
		/// <para>SQL Type: nvarchar(255)</para>
		/// </summary>
		/// <remarks>
		/// This field is changed when the fields it depends on are changed.
		/// </remarks>
		public StringValue? DisplayName { get; set; }

		/// <summary>
		/// The email address of the contact.
		/// <para>DAC Field Name: EMail</para>
		/// <para>DAC: PX.Objects.CR.Contact</para>
		/// <para>SQL Type: nvarchar(255)</para>
		/// </summary>
		public StringValue? Email { get; set; }

		/// <summary>
		/// The job title of the person.
		/// <para>DAC Field Name: Salutation</para>
		/// <para>DAC: PX.Objects.CR.Contact</para>
		/// <para>Display Name: Job Title</para>
		/// <para>SQL Type: nvarchar(255)</para>
		/// </summary>
		public StringValue? JobTitle { get; set; }

		/// <summary>
		/// The identifier of the user responsible for the current document.If the WorkgroupID is specified, only a user that belongsto the specified workgroup can be used.
		/// <para>DAC Field Name: OwnerID</para>
		/// <para>DAC: PX.Objects.CR.BAccount</para>
		/// </summary>
		public StringValue? Owner { get; set; }

		/// <summary>
		/// The phone number.
		/// <para>DAC: PX.Objects.CR.Contact</para>
		/// <para>Display Name: Phone 1</para>
		/// <para>SQL Type: nvarchar(50)</para>
		/// </summary>
		public StringValue? Phone1 { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ContactType</para>
		/// <para>DAC: PX.Objects.CS.NotificationRecipient</para>
		/// <para>Display Name: Contact Type</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		public StringValue? Type { get; set; }

		/// <summary>
		/// The identifier of the workgroup responsible for the current document.
		/// <para>DAC Field Name: WorkgroupID</para>
		/// <para>DAC: PX.Objects.CR.BAccount</para>
		/// </summary>
		public StringValue? Workgroup { get; set; }

	}
}