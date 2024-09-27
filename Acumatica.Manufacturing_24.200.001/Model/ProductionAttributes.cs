using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Manufacturing_24_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen AM401500 in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class ProductionAttributes : Entity, ITopLevelEntity
	{

		[DataMember(Name="Detail", EmitDefaultValue=false)]
		public List<ProductionAttributesDetail>? Detail { get; set; }

		/// <summary>
		/// DAC Field Name: ShowOrderAttributes 
		/// DAC: PX.Objects.AM.ProductionAttributesFilter 
		/// Display Name: Order Attributes 
		/// </summary>
		[DataMember(Name="OrderAttributes", EmitDefaultValue=false)]
		public BooleanValue? OrderAttributes { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.ProductionAttributesFilter 
		/// Display Name: Order Type 
		/// SQL Type: char(2) 
		/// </summary>
		[DataMember(Name="OrderType", EmitDefaultValue=false)]
		public StringValue? OrderType { get; set; }

		/// <summary>
		/// DAC Field Name: ProdOrdID 
		/// DAC: PX.Objects.AM.ProductionAttributesFilter 
		/// Display Name: Production Nbr. 
		/// SQL Type: nvarchar(19) 
		/// </summary>
		[DataMember(Name="ProductionNbr", EmitDefaultValue=false)]
		public StringValue? ProductionNbr { get; set; }

		/// <summary>
		/// DAC Field Name: ShowTransactionAttributes 
		/// DAC: PX.Objects.AM.ProductionAttributesFilter 
		/// Display Name: Transaction Attributes 
		/// </summary>
		[DataMember(Name="TransactionAttributes", EmitDefaultValue=false)]
		public BooleanValue? TransactionAttributes { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/MANUFACTURING/24.200.001";
		}
	}
}