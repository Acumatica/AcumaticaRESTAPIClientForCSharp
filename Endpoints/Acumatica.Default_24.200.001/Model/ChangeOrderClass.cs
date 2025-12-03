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
	/// Corresponds to the screen <c>PM203000</c> in the Acumatica ERP
	/// <para>Key Fields: ClassID</para>
	/// </summary>
	[DataContract]
	public class ChangeOrderClass : Entity, ITopLevelEntity
	{

		/// <summary>
		/// A Boolean value that indicates (if set to true) that the change order class is available for selection on the Change Orders (PM308000) form.
		/// <para>DAC Field Name: IsActive</para>
		/// <para>DAC: PX.Objects.PM.PMChangeOrderClass</para>
		/// </summary>
		[DataMember(Name="Active", EmitDefaultValue=false)]
		public BooleanValue? Active { get; set; }

		[DataMember(Name="Attributes", EmitDefaultValue=false)]
		public List<BusinessAccountClassAttributeDetail>? Attributes { get; set; }

		/// <summary>
		/// The identifier of the change order class.
		/// <para>DAC: PX.Objects.PM.PMChangeOrderClass</para>
		/// <para>Display Name: Class ID</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// Key Field
		/// </summary>
		[DataMember(Name="ClassID", EmitDefaultValue=false)]
		public StringValue? ClassID { get; set; }

		/// <summary>
		/// A Boolean value that indicates (if set to true) that the user can modify existing commitments and add new ones with change orders of this class.
		/// <para>DAC Field Name: IsPurchaseOrderEnabled</para>
		/// <para>DAC: PX.Objects.PM.PMChangeOrderClass</para>
		/// </summary>
		[DataMember(Name="Commitments", EmitDefaultValue=false)]
		public BooleanValue? Commitments { get; set; }

		/// <summary>
		/// A Boolean value that indicates (if set to true) that the user can modify existing cost budget lines and add new ones with change orders of this class.
		/// <para>DAC Field Name: IsCostBudgetEnabled</para>
		/// <para>DAC: PX.Objects.PM.PMChangeOrderClass</para>
		/// <para>Display Name: Cost Budget</para>
		/// </summary>
		[DataMember(Name="CostBudget", EmitDefaultValue=false)]
		public BooleanValue? CostBudget { get; set; }

		/// <summary>
		/// The description of the change order class.
		/// <para>DAC: PX.Objects.PM.PMChangeOrderClass</para>
		/// <para>SQL Type: nvarchar(256)</para>
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? LastModifiedDateTime { get; set; }

		/// <summary>
		/// A Boolean value that indicates (if set to true) that the user can modify existing revenue budget lines and add new ones with change orders of this class.
		/// <para>DAC Field Name: IsRevenueBudgetEnabled</para>
		/// <para>DAC: PX.Objects.PM.PMChangeOrderClass</para>
		/// <para>Display Name: Revenue Budget</para>
		/// </summary>
		[DataMember(Name="RevenueBudget", EmitDefaultValue=false)]
		public BooleanValue? RevenueBudget { get; set; }

		public static class Expand
		{
			public const string Files = "Files";
			public const string Attributes = "Attributes";

			//Intentionally excluded
			//public const string All = "Files,Attributes";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/Default/24.200.001";
		}
	}
}