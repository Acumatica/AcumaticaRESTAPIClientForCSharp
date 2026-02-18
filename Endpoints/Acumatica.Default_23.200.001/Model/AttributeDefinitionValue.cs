using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_23_200_001.Model
{
	public class AttributeDefinitionValue : Entity
	{

		/// <summary>
		/// <para>DAC: PX.Objects.CS.CSAttribute</para>
		/// <para>SQL Type: nvarchar(60)</para>
		/// </summary>
		public StringValue? Description { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.CS.CSAttributeDetail</para>
		/// </summary>
		public BooleanValue? Disabled { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.CS.CSAttributeDetail</para>
		/// <para>Display Name: Sort Order</para>
		/// </summary>
		public ShortValue? SortOrder { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.CS.CSAttributeDetail</para>
		/// <para>Display Name: Value ID</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// Key Field
		/// </summary>
		public StringValue? ValueID { get; set; }

	}
}