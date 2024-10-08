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
	/// Corresponds to the screen AR209000 in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class DiscountCode : Entity, ITopLevelEntity
	{

		/// <summary>
		/// DAC: PX.Objects.AR.ARDiscount 
		/// Display Name: Applicable To 
		/// SQL Type: char(2) 
		/// </summary>
		[DataMember(Name="ApplicableTo", EmitDefaultValue=false)]
		public StringValue? ApplicableTo { get; set; }

		[DataMember(Name="CreatedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? CreatedDateTime { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AR.ARDiscount 
		/// SQL Type: nvarchar(250) 
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		/// <summary>
		/// DAC Field Name: DiscountID 
		/// DAC: PX.Objects.AR.ARDiscount 
		/// Display Name: Discount Code 
		/// SQL Type: nvarchar(10) 
		/// Key Field
		/// </summary>
		[DataMember(Name="DiscountCodeID", EmitDefaultValue=false)]
		public StringValue? DiscountCodeID { get; set; }

		/// <summary>
		/// DAC Field Name: Type 
		/// DAC: PX.Objects.AR.ARDiscount 
		/// Display Name: Discount Type 
		/// SQL Type: char(1) 
		/// </summary>
		[DataMember(Name="DiscountType", EmitDefaultValue=false)]
		public StringValue? DiscountType { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? LastModifiedDateTime { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/Default/22.200.001";
		}
	}
}