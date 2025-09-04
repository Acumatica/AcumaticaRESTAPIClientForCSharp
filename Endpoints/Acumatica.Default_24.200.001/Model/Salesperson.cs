using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_24_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen AR205000 in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class Salesperson : Entity, ITopLevelEntity
	{

		[DataMember(Name="CreatedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? CreatedDateTime { get; set; }

		/// <summary>
		/// The default commission percentage of the salesperson.
		/// DAC Field Name: CommnPct 
		/// DAC: PX.Objects.AR.SalesPerson 
		/// Display Name: Default Commission % 
		/// </summary>
		[DataMember(Name="DefaultCommission", EmitDefaultValue=false)]
		public DecimalValue? DefaultCommission { get; set; }

		/// <summary>
		/// Indicates (if set to true) that the salesperson is active and can be used for recording sales in invoice lines or sales order lines.
		/// DAC: PX.Objects.AR.SalesPerson 
		/// Display Name: Is Active 
		/// </summary>
		[DataMember(Name="IsActive", EmitDefaultValue=false)]
		public BooleanValue? IsActive { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? LastModifiedDateTime { get; set; }

		/// <summary>
		/// The name of the salesperson.
		/// DAC Field Name: Descr 
		/// DAC: PX.Objects.AR.SalesPerson 
		/// SQL Type: nvarchar(60) 
		/// </summary>
		[DataMember(Name="Name", EmitDefaultValue=false)]
		public StringValue? Name { get; set; }

		/// <summary>
		/// The unique identifier of the salesperson. This field is the key field.
		/// DAC Field Name: SalesPersonCD 
		/// DAC: PX.Objects.AR.SalesPerson 
		/// Display Name: Salesperson ID 
		/// SQL Type: nvarchar(15) 
		/// Key Field
		/// </summary>
		[DataMember(Name="SalespersonID", EmitDefaultValue=false)]
		public StringValue? SalespersonID { get; set; }

		/// <summary>
		/// The default sales subaccount associated with the salesperson.The value of this field can be used to construct the sales subaccount in the invoice line that references the salesperson according to the rules defined by SalesSubMask.
		/// DAC Field Name: SalesSubID 
		/// DAC: PX.Objects.AR.SalesPerson 
		/// Display Name: Sales Sub. 
		/// </summary>
		[DataMember(Name="SalesSubaccount", EmitDefaultValue=false)]
		public StringValue? SalesSubaccount { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/Default/24.200.001";
		}
	}
}