using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_26_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen <c>SV303000</c> in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class ServiceLocation : Entity, ITopLevelEntity
	{

		[DataMember(Name="Active", EmitDefaultValue=false)]
		public BooleanValue? Active { get; set; }

		[DataMember(Name="Address", EmitDefaultValue=false)]
		public ServiceLocationAddress? Address { get; set; }

		[DataMember(Name="BranchID", EmitDefaultValue=false)]
		public StringValue? BranchID { get; set; }

		[DataMember(Name="Contacts", EmitDefaultValue=false)]
		public List<ServiceLocationContactDetail>? Contacts { get; set; }

		[DataMember(Name="Customers", EmitDefaultValue=false)]
		public List<ServiceLocationCustomerDetail>? Customers { get; set; }

		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		[DataMember(Name="ServiceAreaID", EmitDefaultValue=false)]
		public StringValue? ServiceAreaID { get; set; }

		[DataMember(Name="ServiceLocationID", EmitDefaultValue=false)]
		public StringValue? ServiceLocationID { get; set; }

		[DataMember(Name="TaxExemptionNumber", EmitDefaultValue=false)]
		public StringValue? TaxExemptionNumber { get; set; }

		[DataMember(Name="TaxExemptionType", EmitDefaultValue=false)]
		public StringSingleSelectValue? TaxExemptionType { get; set; }

		[DataMember(Name="TaxRegistrationID", EmitDefaultValue=false)]
		public StringValue? TaxRegistrationID { get; set; }

		[DataMember(Name="TaxZoneID", EmitDefaultValue=false)]
		public StringValue? TaxZoneID { get; set; }

		[DataMember(Name="TicketSignRequired", EmitDefaultValue=false)]
		public BooleanValue? TicketSignRequired { get; set; }

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
			public const string Translations = "Translations";
			public const string Address = "Address";
			public const string Contacts = "Contacts";
			public const string Customers = "Customers";

			//Intentionally excluded
			//public const string All = "Files,Translations,Address,Contacts,Customers";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/Default/26.200.001";
		}
	}
}