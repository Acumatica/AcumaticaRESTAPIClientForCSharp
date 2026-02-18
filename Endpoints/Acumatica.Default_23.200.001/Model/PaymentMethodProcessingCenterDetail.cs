using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_23_200_001.Model
{
	public class PaymentMethodProcessingCenterDetail : Entity
	{

		/// <summary>
		/// <para>DAC Field Name: IsActive</para>
		/// <para>DAC: PX.Objects.CA.PaymentMethod</para>
		/// </summary>
		public BooleanValue? Active { get; set; }

		/// <summary>
		/// <para>DAC Field Name: IsDefault</para>
		/// <para>DAC: PX.Objects.CA.CCProcessingCenterPmntMethod</para>
		/// </summary>
		public BooleanValue? Default { get; set; }

		/// <summary>
		/// <para>DAC Field Name: PaymentMethodID</para>
		/// <para>DAC: PX.Objects.CA.PaymentMethod</para>
		/// <para>Display Name:  Payment Method ID</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// Key Field
		/// </summary>
		public StringValue? PaymentMethod { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ProcessingCenterID</para>
		/// <para>DAC: PX.Objects.CA.CCProcessingCenterPmntMethod</para>
		/// <para>Display Name: Proc. Center ID</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// Key Field
		/// </summary>
		public StringValue? ProcCenterID { get; set; }

	}
}