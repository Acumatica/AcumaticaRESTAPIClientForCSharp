using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_25_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen <c>AR205000</c> in the Acumatica ERP
	/// <para>Key Fields: SalespersonID</para>
	/// </summary>
	public class Salesperson : Entity, ITopLevelEntity
	{

		public DateTimeValue? CreatedDateTime { get; set; }

		/// <summary>
		/// The default commission percentage of the salesperson.
		/// <para>DAC Field Name: CommnPct</para>
		/// <para>DAC: PX.Objects.AR.SalesPerson</para>
		/// <para>Display Name: Default Commission %</para>
		/// </summary>
		public DecimalValue? DefaultCommission { get; set; }

		/// <summary>
		/// Indicates (if set to true) that the salesperson is active and can be used for recording sales in invoice lines or sales order lines.
		/// <para>DAC: PX.Objects.AR.SalesPerson</para>
		/// <para>Display Name: Is Active</para>
		/// </summary>
		public BooleanValue? IsActive { get; set; }

		public DateTimeValue? LastModifiedDateTime { get; set; }

		/// <summary>
		/// The name of the salesperson.
		/// <para>DAC Field Name: Descr</para>
		/// <para>DAC: PX.Objects.AR.SalesPerson</para>
		/// <para>SQL Type: nvarchar(60)</para>
		/// </summary>
		public StringValue? Name { get; set; }

		/// <summary>
		/// The unique identifier of the salesperson. This field is the key field.
		/// <para>DAC Field Name: SalesPersonCD</para>
		/// <para>DAC: PX.Objects.AR.SalesPerson</para>
		/// <para>Display Name: Salesperson ID</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// Key Field
		/// </summary>
		public StringValue? SalespersonID { get; set; }

		/// <summary>
		/// The default sales subaccount associated with the salesperson.The value of this field can be used to construct the sales subaccount in the invoice line that references the salesperson according to the rules defined by SalesSubMask.
		/// <para>DAC Field Name: SalesSubID</para>
		/// <para>DAC: PX.Objects.AR.SalesPerson</para>
		/// <para>Display Name: Sales Sub.</para>
		/// </summary>
		public StringValue? SalesSubaccount { get; set; }

		public static class Expand
		{
			public const string Files = "Files";
			public const string Translations = "Translations";

			//Intentionally excluded
			//public const string All = "Files,Translations";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/Default/25.200.001";
		}
	}
}