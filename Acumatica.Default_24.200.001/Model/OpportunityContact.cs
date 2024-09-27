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
		/// DAC: PX.Objects.CR.CRShippingContact 
		/// SQL Type: nvarchar(255) 
		/// </summary>
		[DataMember(Name="Attention", EmitDefaultValue=false)]
		public StringValue? Attention { get; set; }

		/// <summary>
		/// DAC Field Name: FullName 
		/// DAC: PX.Objects.CR.CRContact 
		/// Display Name: Account Name 
		/// SQL Type: nvarchar(255) 
		/// </summary>
		[DataMember(Name="CompanyName", EmitDefaultValue=false)]
		public StringValue? CompanyName { get; set; }

		/// <summary>
		/// DAC Field Name: EMail 
		/// DAC: PX.Objects.CR.CRContact 
		/// SQL Type: varchar(255) 
		/// </summary>
		[DataMember(Name="Email", EmitDefaultValue=false)]
		public StringValue? Email { get; set; }

		/// <summary>
		/// DAC: PX.Objects.CR.CRContact 
		/// SQL Type: varchar(50) 
		/// </summary>
		[DataMember(Name="Fax", EmitDefaultValue=false)]
		public StringValue? Fax { get; set; }

		/// <summary>
		/// DAC: PX.Objects.CR.CRContact 
		/// Display Name: Fax 
		/// SQL Type: varchar(3) 
		/// </summary>
		[DataMember(Name="FaxType", EmitDefaultValue=false)]
		public StringValue? FaxType { get; set; }

		/// <summary>
		/// DAC: PX.Objects.CR.CRContact 
		/// Display Name: First Name 
		/// SQL Type: nvarchar(50) 
		/// </summary>
		[DataMember(Name="FirstName", EmitDefaultValue=false)]
		public StringValue? FirstName { get; set; }

		/// <summary>
		/// DAC: PX.Objects.CR.CRContact 
		/// Display Name: Last Name 
		/// SQL Type: nvarchar(100) 
		/// </summary>
		[DataMember(Name="LastName", EmitDefaultValue=false)]
		public StringValue? LastName { get; set; }

		/// <summary>
		/// DAC: PX.Objects.CR.CRContact 
		/// Display Name: Phone 1 
		/// SQL Type: varchar(50) 
		/// </summary>
		[DataMember(Name="Phone1", EmitDefaultValue=false)]
		public StringValue? Phone1 { get; set; }

		/// <summary>
		/// DAC: PX.Objects.CR.CRContact 
		/// Display Name: Phone 1 
		/// SQL Type: varchar(3) 
		/// </summary>
		[DataMember(Name="Phone1Type", EmitDefaultValue=false)]
		public StringValue? Phone1Type { get; set; }

		/// <summary>
		/// DAC: PX.Objects.CR.CRContact 
		/// Display Name: Phone 2 
		/// SQL Type: varchar(50) 
		/// </summary>
		[DataMember(Name="Phone2", EmitDefaultValue=false)]
		public StringValue? Phone2 { get; set; }

		/// <summary>
		/// DAC: PX.Objects.CR.CRContact 
		/// Display Name: Phone 2 
		/// SQL Type: varchar(3) 
		/// </summary>
		[DataMember(Name="Phone2Type", EmitDefaultValue=false)]
		public StringValue? Phone2Type { get; set; }

		/// <summary>
		/// DAC: PX.Objects.CR.CRContact 
		/// Display Name: Phone 3 
		/// SQL Type: varchar(50) 
		/// </summary>
		[DataMember(Name="Phone3", EmitDefaultValue=false)]
		public StringValue? Phone3 { get; set; }

		/// <summary>
		/// DAC: PX.Objects.CR.CRContact 
		/// Display Name: Phone 3 
		/// SQL Type: varchar(3) 
		/// </summary>
		[DataMember(Name="Phone3Type", EmitDefaultValue=false)]
		public StringValue? Phone3Type { get; set; }

		/// <summary>
		/// DAC Field Name: Salutation 
		/// DAC: PX.Objects.CR.CRContact 
		/// Display Name: Job Title 
		/// SQL Type: nvarchar(255) 
		/// </summary>
		[DataMember(Name="Position", EmitDefaultValue=false)]
		public StringValue? Position { get; set; }

		[DataMember(Name="Title", EmitDefaultValue=false)]
		public StringValue? Title { get; set; }

		/// <summary>
		/// DAC: PX.Objects.CR.CRContact 
		/// Display Name: Web 
		/// SQL Type: nvarchar(255) 
		/// </summary>
		[DataMember(Name="WebSite", EmitDefaultValue=false)]
		public StringValue? WebSite { get; set; }

	}
}