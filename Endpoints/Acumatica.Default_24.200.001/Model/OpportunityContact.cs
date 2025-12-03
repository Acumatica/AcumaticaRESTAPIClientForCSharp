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
	public class OpportunityContact : Entity
	{

		/// <summary>
		/// <para>DAC: PX.Objects.CR.CRShippingContact</para>
		/// <para>SQL Type: nvarchar(255)</para>
		/// </summary>
		[DataMember(Name="Attention", EmitDefaultValue=false)]
		public StringValue? Attention { get; set; }

		/// <summary>
		/// <para>DAC Field Name: FullName</para>
		/// <para>DAC: PX.Objects.CR.CRContact</para>
		/// <para>Display Name: Account Name</para>
		/// <para>SQL Type: nvarchar(255)</para>
		/// </summary>
		[DataMember(Name="CompanyName", EmitDefaultValue=false)]
		public StringValue? CompanyName { get; set; }

		/// <summary>
		/// <para>DAC Field Name: EMail</para>
		/// <para>DAC: PX.Objects.CR.CRContact</para>
		/// <para>SQL Type: varchar(255)</para>
		/// </summary>
		[DataMember(Name="Email", EmitDefaultValue=false)]
		public StringValue? Email { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.CR.CRContact</para>
		/// <para>SQL Type: varchar(50)</para>
		/// </summary>
		[DataMember(Name="Fax", EmitDefaultValue=false)]
		public StringValue? Fax { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.CR.CRContact</para>
		/// <para>Display Name: Fax</para>
		/// <para>SQL Type: varchar(3)</para>
		/// </summary>
		[DataMember(Name="FaxType", EmitDefaultValue=false)]
		public StringValue? FaxType { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.CR.CRContact</para>
		/// <para>Display Name: First Name</para>
		/// <para>SQL Type: nvarchar(50)</para>
		/// </summary>
		[DataMember(Name="FirstName", EmitDefaultValue=false)]
		public StringValue? FirstName { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.CR.CRContact</para>
		/// <para>Display Name: Last Name</para>
		/// <para>SQL Type: nvarchar(100)</para>
		/// </summary>
		[DataMember(Name="LastName", EmitDefaultValue=false)]
		public StringValue? LastName { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.CR.CRContact</para>
		/// <para>Display Name: Phone 1</para>
		/// <para>SQL Type: varchar(50)</para>
		/// </summary>
		[DataMember(Name="Phone1", EmitDefaultValue=false)]
		public StringValue? Phone1 { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.CR.CRContact</para>
		/// <para>Display Name: Phone 1</para>
		/// <para>SQL Type: varchar(3)</para>
		/// </summary>
		[DataMember(Name="Phone1Type", EmitDefaultValue=false)]
		public StringValue? Phone1Type { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.CR.CRContact</para>
		/// <para>Display Name: Phone 2</para>
		/// <para>SQL Type: varchar(50)</para>
		/// </summary>
		[DataMember(Name="Phone2", EmitDefaultValue=false)]
		public StringValue? Phone2 { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.CR.CRContact</para>
		/// <para>Display Name: Phone 2</para>
		/// <para>SQL Type: varchar(3)</para>
		/// </summary>
		[DataMember(Name="Phone2Type", EmitDefaultValue=false)]
		public StringValue? Phone2Type { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.CR.CRContact</para>
		/// <para>Display Name: Phone 3</para>
		/// <para>SQL Type: varchar(50)</para>
		/// </summary>
		[DataMember(Name="Phone3", EmitDefaultValue=false)]
		public StringValue? Phone3 { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.CR.CRContact</para>
		/// <para>Display Name: Phone 3</para>
		/// <para>SQL Type: varchar(3)</para>
		/// </summary>
		[DataMember(Name="Phone3Type", EmitDefaultValue=false)]
		public StringValue? Phone3Type { get; set; }

		/// <summary>
		/// <para>DAC Field Name: Salutation</para>
		/// <para>DAC: PX.Objects.CR.CRContact</para>
		/// <para>Display Name: Job Title</para>
		/// <para>SQL Type: nvarchar(255)</para>
		/// </summary>
		[DataMember(Name="Position", EmitDefaultValue=false)]
		public StringValue? Position { get; set; }

		[DataMember(Name="Title", EmitDefaultValue=false)]
		public StringValue? Title { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.CR.CRContact</para>
		/// <para>Display Name: Web</para>
		/// <para>SQL Type: nvarchar(255)</para>
		/// </summary>
		[DataMember(Name="WebSite", EmitDefaultValue=false)]
		public StringValue? WebSite { get; set; }

	}
}