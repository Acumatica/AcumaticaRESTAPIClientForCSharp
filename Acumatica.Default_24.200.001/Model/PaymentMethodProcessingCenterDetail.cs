using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_24_200_001.Model
{
	[DataContract]
	public class PaymentMethodProcessingCenterDetail : Entity
	{

		/// <summary>
		/// DAC Field Name: IsActive 
		/// DAC: PX.Objects.CA.PaymentMethod 
		/// </summary>
		[DataMember(Name="Active", EmitDefaultValue=false)]
		public BooleanValue? Active { get; set; }

		/// <summary>
		/// DAC Field Name: IsDefault 
		/// DAC: PX.Objects.CA.CCProcessingCenterPmntMethod 
		/// </summary>
		[DataMember(Name="Default", EmitDefaultValue=false)]
		public BooleanValue? Default { get; set; }

		/// <summary>
		/// DAC Field Name: PaymentMethodID 
		/// DAC: PX.Objects.CA.PaymentMethod 
		/// Display Name:  Payment Method ID 
		/// SQL Type: nvarchar(10) 
		/// Key Field
		/// </summary>
		[DataMember(Name="PaymentMethod", EmitDefaultValue=false)]
		public StringValue? PaymentMethod { get; set; }

		/// <summary>
		/// DAC Field Name: ProcessingCenterID 
		/// DAC: PX.Objects.CA.CCProcessingCenterPmntMethod 
		/// Display Name: Proc. Center ID 
		/// SQL Type: nvarchar(10) 
		/// Key Field
		/// </summary>
		[DataMember(Name="ProcCenterID", EmitDefaultValue=false)]
		public StringValue? ProcCenterID { get; set; }

	}
}