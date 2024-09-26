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
	/// Corresponds to the screen GL202500 in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class Account : Entity, ITopLevelEntity
	{

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: AccountCD 
		/// DAC: PX.Objects.GL.Account 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="AccountCD", EmitDefaultValue=false)]
		public StringValue? AccountCD { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: AccountClassID 
		/// DAC: PX.Objects.GL.Account 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="AccountClass", EmitDefaultValue=false)]
		public StringValue? AccountClass { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: AccountGroupID 
		/// DAC: PX.Objects.GL.Account 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="AccountGroup", EmitDefaultValue=false)]
		public StringValue? AccountGroup { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: AccountID 
		/// DAC: PX.Objects.GL.Account 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="AccountID", EmitDefaultValue=false)]
		public IntValue? AccountID { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: Active 
		/// DAC: PX.Objects.GL.Account 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Active", EmitDefaultValue=false)]
		public BooleanValue? Active { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: IsCashAccount 
		/// DAC: PX.Objects.GL.Account 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="CashAccount", EmitDefaultValue=false)]
		public BooleanValue? CashAccount { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: COAOrder 
		/// DAC: PX.Objects.GL.Account 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ChartOfAccountsOrder", EmitDefaultValue=false)]
		public IntValue? ChartOfAccountsOrder { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: GLConsolAccountCD 
		/// DAC: PX.Objects.GL.Account 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ConsolidationAccount", EmitDefaultValue=false)]
		public StringValue? ConsolidationAccount { get; set; }

		[DataMember(Name="CreatedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? CreatedDateTime { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: CuryID 
		/// DAC: PX.Objects.GL.Account 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="CurrencyID", EmitDefaultValue=false)]
		public StringValue? CurrencyID { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: Description 
		/// DAC: PX.Objects.GL.Account 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? LastModifiedDateTime { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: PostOption 
		/// DAC: PX.Objects.GL.Account 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="PostOption", EmitDefaultValue=false)]
		public StringValue? PostOption { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: RequireUnits 
		/// DAC: PX.Objects.GL.Account 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="RequireUnits", EmitDefaultValue=false)]
		public BooleanValue? RequireUnits { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: RevalCuryRateTypeId 
		/// DAC: PX.Objects.GL.Account 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="RevaluationRateType", EmitDefaultValue=false)]
		public StringValue? RevaluationRateType { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: Secured 
		/// DAC: PX.Objects.GL.Account 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Secured", EmitDefaultValue=false)]
		public BooleanValue? Secured { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: TaxCategoryID 
		/// DAC: PX.Objects.GL.Account 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="TaxCategory", EmitDefaultValue=false)]
		public StringValue? TaxCategory { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: Type 
		/// DAC: PX.Objects.GL.Account 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Type", EmitDefaultValue=false)]
		public StringValue? Type { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: NoSubDetail 
		/// DAC: PX.Objects.GL.Account 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="UseDefaultSubaccount", EmitDefaultValue=false)]
		public BooleanValue? UseDefaultSubaccount { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/Default/22.200.001";
		}
	}
}