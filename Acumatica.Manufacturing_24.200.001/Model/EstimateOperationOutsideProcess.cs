using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Manufacturing_24_200_001.Model
{
	[DataContract]
	public class EstimateOperationOutsideProcess : Entity
	{

		/// <summary>
		/// DAC Field Name: DropShippedToVendor 
		/// DAC: PX.Objects.AM.AMEstimateOper 
		/// Display Name: Drop Shipped to Vendor 
		/// </summary>
		[DataMember(Name="DropShippedtoVendor", EmitDefaultValue=false)]
		public BooleanValue? DropShippedtoVendor { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMEstimateOper 
		/// Display Name: Outside Process 
		/// </summary>
		[DataMember(Name="OutsideProcess", EmitDefaultValue=false)]
		public BooleanValue? OutsideProcess { get; set; }

		/// <summary>
		/// DAC Field Name: VendorID 
		/// DAC: PX.Objects.AM.AMEstimateOper 
		/// </summary>
		[DataMember(Name="Vendor", EmitDefaultValue=false)]
		public StringValue? Vendor { get; set; }

		/// <summary>
		/// DAC Field Name: VendorLocationID 
		/// DAC: PX.Objects.AM.AMEstimateOper 
		/// Display Name: Vendor Location 
		/// </summary>
		[DataMember(Name="VendorLocation", EmitDefaultValue=false)]
		public StringValue? VendorLocation { get; set; }

	}
}