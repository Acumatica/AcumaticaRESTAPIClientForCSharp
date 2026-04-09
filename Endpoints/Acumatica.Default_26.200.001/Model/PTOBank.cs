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
	public class PTOBank : Entity, ITopLevelEntity
	{

		[DataMember(Name="AccrualMethod", EmitDefaultValue=false)]
		public StringValue? AccrualMethod { get; set; }

		[DataMember(Name="AccrueonCertifiedJobOnly", EmitDefaultValue=false)]
		public BooleanValue? AccrueonCertifiedJobOnly { get; set; }

		[DataMember(Name="Active", EmitDefaultValue=false)]
		public BooleanValue? Active { get; set; }

		[DataMember(Name="ApplicableEarningTypes", EmitDefaultValue=false)]
		public PTOBankApplicableEarningType? ApplicableEarningTypes { get; set; }

		[DataMember(Name="ApplyBandingRules", EmitDefaultValue=false)]
		public BooleanValue? ApplyBandingRules { get; set; }

		[DataMember(Name="BandingRules", EmitDefaultValue=false)]
		public PTOBankBandingRule? BandingRules { get; set; }

		[DataMember(Name="CarryoverType", EmitDefaultValue=false)]
		public StringValue? CarryoverType { get; set; }

		[DataMember(Name="CreateFinTransactions", EmitDefaultValue=false)]
		public BooleanValue? CreateFinTransactions { get; set; }

		[DataMember(Name="DefaultDisbursingType", EmitDefaultValue=false)]
		public StringValue? DefaultDisbursingType { get; set; }

		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		[DataMember(Name="DisbursingEarningType", EmitDefaultValue=false)]
		public StringValue? DisbursingEarningType { get; set; }

		[DataMember(Name="EmployeeClassSettings", EmitDefaultValue=false)]
		public List<PTOBankEmployeeClassSetting>? EmployeeClassSettings { get; set; }

		[DataMember(Name="GLAccounts", EmitDefaultValue=false)]
		public PTOBankGLAccounts? GLAccounts { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? LastModifiedDateTime { get; set; }

		[DataMember(Name="OnSettlement", EmitDefaultValue=false)]
		public StringValue? OnSettlement { get; set; }

		[DataMember(Name="PTOBankID", EmitDefaultValue=false)]
		public StringValue? PTOBankID { get; set; }

		[DataMember(Name="TransferDate", EmitDefaultValue=false)]
		public DateTimeValue? TransferDate { get; set; }

		[DataMember(Name="TransferDateDay", EmitDefaultValue=false)]
		public IntValue? TransferDateDay { get; set; }

		[DataMember(Name="TransferDateMonth", EmitDefaultValue=false)]
		public StringValue? TransferDateMonth { get; set; }

		[DataMember(Name="TransferDateType", EmitDefaultValue=false)]
		public StringValue? TransferDateType { get; set; }

		public static class Expand
		{
			public const string Files = "Files";
			public const string Translations = "Translations";
			public const string ApplicableEarningTypes = "ApplicableEarningTypes";
			public const string ApplicableEarningTypes_ApplicableEarningTypeDetail = "ApplicableEarningTypes/ApplicableEarningTypeDetail";
			public const string ApplicableEarningTypes_ApplicableEarningTypeDetail_Files = "ApplicableEarningTypes/ApplicableEarningTypeDetail/Files";
			public const string BandingRules = "BandingRules";
			public const string BandingRules_BandingRuleDetails = "BandingRules/BandingRuleDetails";
			public const string BandingRules_BandingRuleDetails_Files = "BandingRules/BandingRuleDetails/Files";
			public const string EmployeeClassSettings = "EmployeeClassSettings";
			public const string EmployeeClassSettings_Files = "EmployeeClassSettings/Files";
			public const string GLAccounts = "GLAccounts";

			//Intentionally excluded
			//public const string All = "Files,Translations,ApplicableEarningTypes,ApplicableEarningTypes/ApplicableEarningTypeDetail,ApplicableEarningTypes/ApplicableEarningTypeDetail/Files,BandingRules,BandingRules/BandingRuleDetails,BandingRules/BandingRuleDetails/Files,EmployeeClassSettings,EmployeeClassSettings/Files,GLAccounts";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/Default/26.200.001";
		}
	}
}