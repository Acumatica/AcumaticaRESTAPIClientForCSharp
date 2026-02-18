using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Manufacturing_24_200_001.Model
{
	public class EstimateOperationOutsideProcess : Entity
	{

		/// <summary>
		/// <para>DAC Field Name: DropShippedToVendor</para>
		/// <para>DAC: PX.Objects.AM.AMEstimateOper</para>
		/// <para>Display Name: Drop Shipped to Vendor</para>
		/// </summary>
		public BooleanValue? DropShippedtoVendor { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMEstimateOper</para>
		/// <para>Display Name: Outside Process</para>
		/// </summary>
		public BooleanValue? OutsideProcess { get; set; }

		/// <summary>
		/// <para>DAC Field Name: VendorID</para>
		/// <para>DAC: PX.Objects.AM.AMEstimateOper</para>
		/// </summary>
		public StringValue? Vendor { get; set; }

		/// <summary>
		/// <para>DAC Field Name: VendorLocationID</para>
		/// <para>DAC: PX.Objects.AM.AMEstimateOper</para>
		/// <para>Display Name: Vendor Location</para>
		/// </summary>
		public StringValue? VendorLocation { get; set; }

	}
}