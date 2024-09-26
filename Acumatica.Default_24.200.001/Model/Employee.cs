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
	/// Corresponds to the screen EP203000 in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class Employee : Entity, ITopLevelEntity
	{

		[DataMember(Name="Attributes", EmitDefaultValue=false)]
		public List<AttributeValue>? Attributes { get; set; }

		[DataMember(Name="ContactInfo", EmitDefaultValue=false)]
		public Contact? ContactInfo { get; set; }

		[DataMember(Name="Delegates", EmitDefaultValue=false)]
		public List<EmployeeDelegate>? Delegates { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: AcctCD 
		/// DAC: PX.Objects.EP.EPEmployee 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="EmployeeID", EmitDefaultValue=false)]
		public StringValue? EmployeeID { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: AcctName 
		/// DAC: PX.Objects.EP.EPEmployee 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="EmployeeName", EmitDefaultValue=false)]
		public StringValue? EmployeeName { get; set; }

		[DataMember(Name="EmployeeSettings", EmitDefaultValue=false)]
		public EmployeeSettings? EmployeeSettings { get; set; }

		[DataMember(Name="EmploymentHistory", EmitDefaultValue=false)]
		public List<EmploymentHistoryRecord>? EmploymentHistory { get; set; }

		[DataMember(Name="FinancialSettings", EmitDefaultValue=false)]
		public EmployeeFinancialSettings? FinancialSettings { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? LastModifiedDateTime { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: VStatus 
		/// DAC: PX.Objects.EP.EPEmployee 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Status", EmitDefaultValue=false)]
		public StringValue? Status { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/Default/24.200.001";
		}
	}
}