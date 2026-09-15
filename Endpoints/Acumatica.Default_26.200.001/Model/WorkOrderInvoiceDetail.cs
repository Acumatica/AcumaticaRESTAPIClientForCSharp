using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_26_200_001.Model
{
	[DataContract]
	public class WorkOrderInvoiceDetail : Entity
	{

		[DataMember(Name="Balance", EmitDefaultValue=false)]
		public DecimalValue? Balance { get; set; }

		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		[DataMember(Name="DetailTotal", EmitDefaultValue=false)]
		public DecimalValue? DetailTotal { get; set; }

		[DataMember(Name="DocDate", EmitDefaultValue=false)]
		public DateOnlyValue? DocDate { get; set; }

		[DataMember(Name="DocType", EmitDefaultValue=false)]
		public StringSingleSelectValue? DocType { get; set; }

		[DataMember(Name="RefNbr", EmitDefaultValue=false)]
		public StringValue? RefNbr { get; set; }

		[DataMember(Name="Status", EmitDefaultValue=false)]
		public StringSingleSelectValue? Status { get; set; }

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

			//Intentionally excluded
			//public const string All = "Files";
		}
	}
}