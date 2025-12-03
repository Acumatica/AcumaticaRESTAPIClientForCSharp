using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_23_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen <c>AR205000</c> in the Acumatica ERP
	/// <para>Key Fields: SalespersonID</para>
	/// </summary>
	[DataContract]
	public class Salesperson : Entity, ITopLevelEntity
	{

		[DataMember(Name="CreatedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? CreatedDateTime { get; set; }

		/// <summary>
		/// The default commission percentage of the salesperson.
		/// <para>DAC Field Name: CommnPct</para>
		/// <para>DAC: PX.Objects.AR.SalesPerson</para>
		/// <para>Display Name: Default Commission %</para>
		/// </summary>
		[DataMember(Name="DefaultCommission", EmitDefaultValue=false)]
		public DecimalValue? DefaultCommission { get; set; }

		/// <summary>
		/// Indicates (if set to true) that the salesperson is active and can be used for recording sales in invoice lines or sales order lines.
		/// <para>DAC: PX.Objects.AR.SalesPerson</para>
		/// <para>Display Name: Is Active</para>
		/// </summary>
		[DataMember(Name="IsActive", EmitDefaultValue=false)]
		public BooleanValue? IsActive { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? LastModifiedDateTime { get; set; }

		/// <summary>
		/// The name of the salesperson.
		/// <para>DAC Field Name: Descr</para>
		/// <para>DAC: PX.Objects.AR.SalesPerson</para>
		/// <para>SQL Type: nvarchar(60)</para>
		/// </summary>
		[DataMember(Name="Name", EmitDefaultValue=false)]
		public StringValue? Name { get; set; }

		/// <summary>
		/// The unique identifier of the salesperson. This field is the key field.
		/// <para>DAC Field Name: SalesPersonCD</para>
		/// <para>DAC: PX.Objects.AR.SalesPerson</para>
		/// <para>Display Name: Salesperson ID</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// Key Field
		/// </summary>
		[DataMember(Name="SalespersonID", EmitDefaultValue=false)]
		public StringValue? SalespersonID { get; set; }

		/// <summary>
		/// The default sales subaccount associated with the salesperson.The value of this field can be used to construct the sales subaccount in the invoice line that references the salesperson according to the rules defined by SalesSubMask.
		/// <para>DAC Field Name: SalesSubID</para>
		/// <para>DAC: PX.Objects.AR.SalesPerson</para>
		/// <para>Display Name: Sales Sub.</para>
		/// </summary>
		[DataMember(Name="SalesSubaccount", EmitDefaultValue=false)]
		public StringValue? SalesSubaccount { get; set; }

		public static class Expand
		{
			public const string Files = "Files";

			//Intentionally excluded
			//public const string All = "Files";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/Default/23.200.001";
		}
	}
}