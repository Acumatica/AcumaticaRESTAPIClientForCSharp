using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_26_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen <c>PM308500</c> in the Acumatica ERP
	/// </summary>
	public class ChangeRequest : Entity, ITopLevelEntity
	{

		#region Fields
		public DateOnlyValue? ChangeDate { get; set; }

		public StringValue? ChangeOrderNbr { get; set; }

		public StringValue? ChangeRequestNbr { get; set; }

		public StringValue? ChangeRequestTaskNbr { get; set; }

		public DecimalValue? ChangeTotal { get; set; }

		public StringValue? CommonTaskforChangeRequest { get; set; }

		public IntValue? ContractChangeDays { get; set; }

		public StringValue? CostChangeOrderNbr { get; set; }

		public DecimalValue? CostTotal { get; set; }

		public StringValue? Customer { get; set; }

		public StringValue? Description { get; set; }

		public StringValue? DetailedDescription { get; set; }

		public StringValue? ExternalRefNbr { get; set; }

		public DecimalValue? GrossMargin { get; set; }

		public BooleanValue? Hold { get; set; }

		public DecimalValue? LineTotal { get; set; }

		public DecimalValue? MarkupTotal { get; set; }

		public DecimalValue? PriceTotal { get; set; }

		public StringValue? Project { get; set; }

		public GuidValue? ProjectIssue { get; set; }

		public StringValue? ReferenceNbr { get; set; }

		public GuidValue? RFI { get; set; }

		public StringValue? Status { get; set; }

		public DecimalValue? TaxTotal { get; set; }

		#endregion

		#region LinkedEntities
		public ChangeRequestAddress? Address { get; set; }

		public ChangeRequestContact? Contact { get; set; }

		public ChangeRequestTaxSettings? TaxSettings { get; set; }

		#endregion

		#region Details
		public List<Approval>? ApprovalDetails { get; set; }

		public List<ChangeRequestLine>? Details { get; set; }

		public List<ChangeRequestMarkup>? Markups { get; set; }

		public List<ChangeRequestTaxTran>? Taxes { get; set; }

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
			public const string ApprovalDetails = "ApprovalDetails";
			public const string Contact = "Contact";
			public const string Details = "Details";
			public const string Markups = "Markups";
			public const string Taxes = "Taxes";
			public const string TaxSettings = "TaxSettings";

			//Intentionally excluded
			//public const string All = "Files,Translations,Address,ApprovalDetails,Contact,Details,Markups,Taxes,TaxSettings";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/Default/26.200.001";
		}
	}
}