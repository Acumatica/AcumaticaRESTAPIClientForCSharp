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
	/// Corresponds to the screen PR209700 in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class PayrollUnionLocal : Entity, ITopLevelEntity
	{

		/// <summary>
		/// DAC Field Name: IsActive 
		/// DAC: PX.Objects.PM.PMUnion 
		/// </summary>
		[DataMember(Name="Active", EmitDefaultValue=false)]
		public BooleanValue? Active { get; set; }

		[DataMember(Name="DeductionsAndBenefits", EmitDefaultValue=false)]
		public List<UnionDeductionOrBenefitDetail>? DeductionsAndBenefits { get; set; }

		/// <summary>
		/// DAC: PX.Objects.PM.PMUnion 
		/// SQL Type: nvarchar(255) 
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		[DataMember(Name="EarningRates", EmitDefaultValue=false)]
		public List<UnionEarningRateDetail>? EarningRates { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? LastModifiedDateTime { get; set; }

		[DataMember(Name="Location", EmitDefaultValue=false)]
		public StringValue? Location { get; set; }

		/// <summary>
		/// DAC Field Name: UnionID 
		/// DAC: PX.Objects.PM.PMUnion 
		/// Display Name: Union Local ID 
		/// SQL Type: nvarchar(15) 
		/// Key Field
		/// </summary>
		[DataMember(Name="PayrollUnionLocalID", EmitDefaultValue=false)]
		public StringValue? PayrollUnionLocalID { get; set; }

		[DataMember(Name="Vendor", EmitDefaultValue=false)]
		public StringValue? Vendor { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/Default/22.200.001";
		}
	}
}