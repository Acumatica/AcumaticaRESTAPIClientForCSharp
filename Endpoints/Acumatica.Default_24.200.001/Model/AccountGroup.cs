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
	/// Corresponds to the screen PM201000 in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class AccountGroup : Entity, ITopLevelEntity
	{

		/// <summary>
		/// Gets or Sets the AccountGroup identifier.This is a segmented key and format is configured under segmented key maintenance screen in CS module.
		/// DAC Field Name: GroupCD 
		/// DAC: PX.Objects.PM.PMAccountGroup 
		/// Display Name: Account Group ID 
		/// SQL Type: nvarchar(10) 
		/// Key Field
		/// </summary>
		[DataMember(Name="AccountGroupID", EmitDefaultValue=false)]
		public StringValue? AccountGroupID { get; set; }

		/// <summary>
		/// Gets or sets whether Account group is active or not.
		/// DAC Field Name: IsActive 
		/// DAC: PX.Objects.PM.PMAccountGroup 
		/// </summary>
		[DataMember(Name="Active", EmitDefaultValue=false)]
		public BooleanValue? Active { get; set; }

		[DataMember(Name="Attributes", EmitDefaultValue=false)]
		public List<AttributeValue>? Attributes { get; set; }

		/// <summary>
		/// DAC Field Name: AccountID 
		/// DAC: PX.Objects.PM.AccountGroupMaint+AccountPtr 
		/// </summary>
		[DataMember(Name="DefaultAccountID", EmitDefaultValue=false)]
		public StringValue? DefaultAccountID { get; set; }

		/// <summary>
		/// Gets or Sets the AccountGroup description.
		/// DAC: PX.Objects.PM.PMAccountGroup 
		/// SQL Type: nvarchar(250) 
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		/// <summary>
		/// A Boolean value that indicates whether the account group is an expense account groupand can be selected on the Cost Budget tab of the Projects (PM301000) form.
		/// DAC Field Name: IsExpense 
		/// DAC: PX.Objects.PM.PMAccountGroup 
		/// </summary>
		[DataMember(Name="Expense", EmitDefaultValue=false)]
		public BooleanValue? Expense { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? LastModifiedDateTime { get; set; }

		/// <summary>
		/// Gets or sets sort order. Sort order is used in displaying the Balances for the Project.
		/// DAC: PX.Objects.PM.PMAccountGroup 
		/// Display Name: Sort Order 
		/// </summary>
		[DataMember(Name="SortOrder", EmitDefaultValue=false)]
		public ShortValue? SortOrder { get; set; }

		/// <summary>
		/// The type of the account group, which can be one of the following: Asset, Liability, Expense, Income, and Off-Balance.
		/// DAC: PX.Objects.PM.PMAccountGroup 
		/// SQL Type: char(1) 
		/// </summary>
		[DataMember(Name="Type", EmitDefaultValue=false)]
		public StringValue? Type { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/Default/24.200.001";
		}
	}
}