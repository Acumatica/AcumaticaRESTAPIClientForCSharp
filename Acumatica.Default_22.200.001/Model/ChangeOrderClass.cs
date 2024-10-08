using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_22_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen PM203000 in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class ChangeOrderClass : Entity, ITopLevelEntity
	{

		/// <summary>
		/// A Boolean value that indicates (if set to true) that the change order class is available for selection on the Change Orders (PM308000) form.
		/// DAC Field Name: IsActive 
		/// DAC: PX.Objects.PM.PMChangeOrderClass 
		/// </summary>
		[DataMember(Name="Active", EmitDefaultValue=false)]
		public BooleanValue? Active { get; set; }

		[DataMember(Name="Attributes", EmitDefaultValue=false)]
		public List<BusinessAccountClassAttributeDetail>? Attributes { get; set; }

		/// <summary>
		/// The identifier of the change order class.
		/// DAC: PX.Objects.PM.PMChangeOrderClass 
		/// Display Name: Class ID 
		/// SQL Type: nvarchar(15) 
		/// Key Field
		/// </summary>
		[DataMember(Name="ClassID", EmitDefaultValue=false)]
		public StringValue? ClassID { get; set; }

		/// <summary>
		/// A Boolean value that indicates (if set to true) that the user can modify existing commitments and add new ones with change orders of this class.
		/// DAC Field Name: IsPurchaseOrderEnabled 
		/// DAC: PX.Objects.PM.PMChangeOrderClass 
		/// </summary>
		[DataMember(Name="Commitments", EmitDefaultValue=false)]
		public BooleanValue? Commitments { get; set; }

		/// <summary>
		/// A Boolean value that indicates (if set to true) that the user can modify existing cost budget lines and add new ones with change orders of this class.
		/// DAC Field Name: IsCostBudgetEnabled 
		/// DAC: PX.Objects.PM.PMChangeOrderClass 
		/// Display Name: Cost Budget 
		/// </summary>
		[DataMember(Name="CostBudget", EmitDefaultValue=false)]
		public BooleanValue? CostBudget { get; set; }

		/// <summary>
		/// The description of the change order class.
		/// DAC: PX.Objects.PM.PMChangeOrderClass 
		/// SQL Type: nvarchar(256) 
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? LastModifiedDateTime { get; set; }

		/// <summary>
		/// A Boolean value that indicates (if set to true) that the user can modify existing revenue budget lines and add new ones with change orders of this class.
		/// DAC Field Name: IsRevenueBudgetEnabled 
		/// DAC: PX.Objects.PM.PMChangeOrderClass 
		/// Display Name: Revenue Budget 
		/// </summary>
		[DataMember(Name="RevenueBudget", EmitDefaultValue=false)]
		public BooleanValue? RevenueBudget { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/Default/22.200.001";
		}
	}
}