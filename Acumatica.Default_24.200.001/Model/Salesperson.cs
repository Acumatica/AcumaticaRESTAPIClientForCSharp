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
		/// 
		/// Display Name:
		/// DAC Field Name: CommnPct 
		/// DAC: PX.Objects.AR.SalesPerson 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="DefaultCommission", EmitDefaultValue=false)]
		public DecimalValue? DefaultCommission { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: IsActive 
		/// DAC: PX.Objects.AR.SalesPerson 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="IsActive", EmitDefaultValue=false)]
		public BooleanValue? IsActive { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? LastModifiedDateTime { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: Descr 
		/// DAC: PX.Objects.AR.SalesPerson 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Name", EmitDefaultValue=false)]
		public StringValue? Name { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: SalesPersonCD 
		/// DAC: PX.Objects.AR.SalesPerson 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="SalespersonID", EmitDefaultValue=false)]
		public StringValue? SalespersonID { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: SalesSubID 
		/// DAC: PX.Objects.AR.SalesPerson 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="SalesSubaccount", EmitDefaultValue=false)]
		public StringValue? SalesSubaccount { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/Default/24.200.001";
		}
	}
}