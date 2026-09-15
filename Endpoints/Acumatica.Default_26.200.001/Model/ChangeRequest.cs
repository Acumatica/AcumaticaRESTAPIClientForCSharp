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
	/// Corresponds to the screen <c>PM308500</c> in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class ChangeRequest : Entity, ITopLevelEntity
	{

		[DataMember(Name="Address", EmitDefaultValue=false)]
		public ChangeRequestAddress? Address { get; set; }

		[DataMember(Name="ApprovalDetails", EmitDefaultValue=false)]
		public List<Approval>? ApprovalDetails { get; set; }

		[DataMember(Name="ChangeDate", EmitDefaultValue=false)]
		public DateOnlyValue? ChangeDate { get; set; }

		[DataMember(Name="ChangeOrderNbr", EmitDefaultValue=false)]
		public StringValue? ChangeOrderNbr { get; set; }

		[DataMember(Name="ChangeRequestNbr", EmitDefaultValue=false)]
		public StringValue? ChangeRequestNbr { get; set; }

		[DataMember(Name="ChangeRequestTaskNbr", EmitDefaultValue=false)]
		public StringValue? ChangeRequestTaskNbr { get; set; }

		[DataMember(Name="ChangeTotal", EmitDefaultValue=false)]
		public DecimalValue? ChangeTotal { get; set; }

		[DataMember(Name="CommonTaskforChangeRequest", EmitDefaultValue=false)]
		public StringValue? CommonTaskforChangeRequest { get; set; }

		[DataMember(Name="Contact", EmitDefaultValue=false)]
		public ChangeRequestContact? Contact { get; set; }

		[DataMember(Name="ContractChangeDays", EmitDefaultValue=false)]
		public IntValue? ContractChangeDays { get; set; }

		[DataMember(Name="CostChangeOrderNbr", EmitDefaultValue=false)]
		public StringValue? CostChangeOrderNbr { get; set; }

		[DataMember(Name="CostTotal", EmitDefaultValue=false)]
		public DecimalValue? CostTotal { get; set; }

		[DataMember(Name="Customer", EmitDefaultValue=false)]
		public StringValue? Customer { get; set; }

		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		[DataMember(Name="DetailedDescription", EmitDefaultValue=false)]
		public StringValue? DetailedDescription { get; set; }

		[DataMember(Name="Details", EmitDefaultValue=false)]
		public List<ChangeRequestLine>? Details { get; set; }

		[DataMember(Name="ExternalRefNbr", EmitDefaultValue=false)]
		public StringValue? ExternalRefNbr { get; set; }

		[DataMember(Name="GrossMargin", EmitDefaultValue=false)]
		public DecimalValue? GrossMargin { get; set; }

		[DataMember(Name="Hold", EmitDefaultValue=false)]
		public BooleanValue? Hold { get; set; }

		[DataMember(Name="LineTotal", EmitDefaultValue=false)]
		public DecimalValue? LineTotal { get; set; }

		[DataMember(Name="Markups", EmitDefaultValue=false)]
		public List<ChangeRequestMarkup>? Markups { get; set; }

		[DataMember(Name="MarkupTotal", EmitDefaultValue=false)]
		public DecimalValue? MarkupTotal { get; set; }

		[DataMember(Name="PriceTotal", EmitDefaultValue=false)]
		public DecimalValue? PriceTotal { get; set; }

		[DataMember(Name="Project", EmitDefaultValue=false)]
		public StringValue? Project { get; set; }

		[DataMember(Name="ProjectIssue", EmitDefaultValue=false)]
		public GuidValue? ProjectIssue { get; set; }

		[DataMember(Name="ReferenceNbr", EmitDefaultValue=false)]
		public StringValue? ReferenceNbr { get; set; }

		[DataMember(Name="RFI", EmitDefaultValue=false)]
		public GuidValue? RFI { get; set; }

		[DataMember(Name="Status", EmitDefaultValue=false)]
		public StringValue? Status { get; set; }

		[DataMember(Name="Taxes", EmitDefaultValue=false)]
		public List<ChangeRequestTaxTran>? Taxes { get; set; }

		[DataMember(Name="TaxSettings", EmitDefaultValue=false)]
		public ChangeRequestTaxSettings? TaxSettings { get; set; }

		[DataMember(Name="TaxTotal", EmitDefaultValue=false)]
		public DecimalValue? TaxTotal { get; set; }

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