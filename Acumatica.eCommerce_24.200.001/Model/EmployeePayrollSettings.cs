using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.eCommerce_24_200_001.Model
{
	[DataContract]
	public class EmployeePayrollSettings : Entity, ITopLevelEntity
	{

		[DataMember(Name="Active", EmitDefaultValue=false)]
		public BooleanValue? Active { get; set; }

		[DataMember(Name="AddressInfo", EmitDefaultValue=false)]
		public Address? AddressInfo { get; set; }

		[DataMember(Name="CashAccount", EmitDefaultValue=false)]
		public StringValue? CashAccount { get; set; }

		[DataMember(Name="ClassID", EmitDefaultValue=false)]
		public StringValue? ClassID { get; set; }

		[DataMember(Name="Compensation", EmitDefaultValue=false)]
		public List<CompensationDetail>? Compensation { get; set; }

		[DataMember(Name="DeductionsAndBenefits", EmitDefaultValue=false)]
		public DeductionsAndBenefits? DeductionsAndBenefits { get; set; }

		[DataMember(Name="DirectDepositDetails", EmitDefaultValue=false)]
		public List<DirectDepositDetail>? DirectDepositDetails { get; set; }

		[DataMember(Name="EmployeeID", EmitDefaultValue=false)]
		public StringValue? EmployeeID { get; set; }

		[DataMember(Name="EmployeeName", EmitDefaultValue=false)]
		public StringValue? EmployeeName { get; set; }

		[DataMember(Name="EmployeeType", EmitDefaultValue=false)]
		public StringValue? EmployeeType { get; set; }

		[DataMember(Name="EmploymentDates", EmitDefaultValue=false)]
		public EmploymentDates? EmploymentDates { get; set; }

		[DataMember(Name="EmploymentRecords", EmitDefaultValue=false)]
		public List<EmploymentRecord>? EmploymentRecords { get; set; }

		[DataMember(Name="GeneralInfo", EmitDefaultValue=false)]
		public EmployeeGeneralInfo? GeneralInfo { get; set; }

		[DataMember(Name="GLAccounts", EmitDefaultValue=false)]
		public EmployeeGLAccounts? GLAccounts { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? LastModifiedDateTime { get; set; }

		[DataMember(Name="PaidTimeOff", EmitDefaultValue=false)]
		public EmployeePaidTimeOff? PaidTimeOff { get; set; }

		[DataMember(Name="PaymentMethod", EmitDefaultValue=false)]
		public StringValue? PaymentMethod { get; set; }

		[DataMember(Name="Taxes", EmitDefaultValue=false)]
		public List<EmployeeTaxDetail>? Taxes { get; set; }

		[DataMember(Name="TaxSettings", EmitDefaultValue=false)]
		public List<TaxSettingDetail>? TaxSettings { get; set; }

		[DataMember(Name="EmployeeTypeClassDefault", EmitDefaultValue=false)]
		public BooleanValue? EmployeeTypeClassDefault { get; set; }

		[DataMember(Name="WorkLocations", EmitDefaultValue=false)]
		public EmployeeWorkLocations? WorkLocations { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/eCommerce/24.200.001";
		}
	}
}