using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.eCommerce_24_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen <c>IN203000</c> in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class TemplateItems : Acumatica.Default_24_200_001.Model.TemplateItems, ITopLevelEntity
	{

		/// <summary>
		/// References to Attribute which will be put as Column Attribute in Inventory Matrix by default.
		/// <para>DAC Field Name: DefaultColumnMatrixAttributeID</para>
		/// <para>DAC: PX.Objects.IN.InventoryItem</para>
		/// <para>Display Name: Default Column Attribute ID</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// </summary>
		[DataMember(Name="DefaultColumnAttributeID", EmitDefaultValue=false)]
		public StringValue? DefaultColumnAttributeID { get; set; }

		/// <summary>
		/// References to Attribute which will be put as Row Attribute in Inventory Matrix by default.
		/// <para>DAC Field Name: DefaultRowMatrixAttributeID</para>
		/// <para>DAC: PX.Objects.IN.InventoryItem</para>
		/// <para>Display Name: Default Row Attribute ID</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// </summary>
		[DataMember(Name="DefaultRowAttributeID", EmitDefaultValue=false)]
		public StringValue? DefaultRowAttributeID { get; set; }

		public override string GetEndpointPath()
		{
			return "entity/eCommerce/24.200.001";
		}
	}
}