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
	public class WorkTicketExpenseDetail : Entity
	{

		[DataMember(Name="CorpCardID", EmitDefaultValue=false)]
		public StringValue? CorpCardID { get; set; }

		[DataMember(Name="CurrencyID", EmitDefaultValue=false)]
		public StringValue? CurrencyID { get; set; }

		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		[DataMember(Name="EmployeeID", EmitDefaultValue=false)]
		public StringValue? EmployeeID { get; set; }

		[DataMember(Name="ExpenseDate", EmitDefaultValue=false)]
		public DateOnlyValue? ExpenseDate { get; set; }

		[DataMember(Name="ExpenseRefNbr", EmitDefaultValue=false)]
		public StringValue? ExpenseRefNbr { get; set; }

		[DataMember(Name="ExtCost", EmitDefaultValue=false)]
		public DecimalValue? ExtCost { get; set; }

		[DataMember(Name="InventoryID", EmitDefaultValue=false)]
		public StringValue? InventoryID { get; set; }

		[DataMember(Name="PaidWith", EmitDefaultValue=false)]
		public StringSingleSelectValue? PaidWith { get; set; }

		[DataMember(Name="Qty", EmitDefaultValue=false)]
		public DecimalValue? Qty { get; set; }

		[DataMember(Name="ReceiptNbr", EmitDefaultValue=false)]
		public StringValue? ReceiptNbr { get; set; }

		[DataMember(Name="Status", EmitDefaultValue=false)]
		public StringSingleSelectValue? Status { get; set; }

		[DataMember(Name="UOM", EmitDefaultValue=false)]
		public StringValue? UOM { get; set; }

		[DataMember(Name="UnitCost", EmitDefaultValue=false)]
		public DecimalValue? UnitCost { get; set; }

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