using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_26_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen <c>SV303000</c> in the Acumatica ERP
	/// </summary>
	public class ServiceLocation : Entity, ITopLevelEntity
	{

		#region Fields
		public BooleanValue? Active { get; set; }

		public StringValue? BranchID { get; set; }

		public StringValue? Description { get; set; }

		public StringValue? ServiceAreaID { get; set; }

		public StringValue? ServiceLocationID { get; set; }

		public StringValue? TaxExemptionNumber { get; set; }

		public StringSingleSelectValue? TaxExemptionType { get; set; }

		public StringValue? TaxRegistrationID { get; set; }

		public StringValue? TaxZoneID { get; set; }

		public BooleanValue? TicketSignRequired { get; set; }

		#endregion

		#region LinkedEntities
		public ServiceLocationAddress? Address { get; set; }

		#endregion

		#region Details
		public List<ServiceLocationContactDetail>? Contacts { get; set; }

		public List<ServiceLocationCustomerDetail>? Customers { get; set; }

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