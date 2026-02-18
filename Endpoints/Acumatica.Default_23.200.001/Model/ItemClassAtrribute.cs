using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_23_200_001.Model
{
	public class ItemClassAtrribute : Entity
	{

		/// <summary>
		/// <para>DAC: PX.Objects.CS.CSAttributeGroup</para>
		/// <para>Display Name: Attribute ID</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// Key Field
		/// </summary>
		public StringValue? AttributeID { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.CS.CSAttributeGroup</para>
		/// </summary>
		public BooleanValue? Required { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.CS.CSAttributeGroup</para>
		/// <para>Display Name: Sort Order</para>
		/// </summary>
		public ShortValue? SortOrder { get; set; }

	}
}