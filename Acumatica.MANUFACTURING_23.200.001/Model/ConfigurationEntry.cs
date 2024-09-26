using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Manufacturing_23_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen AM306010 in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class ConfigurationEntry : Entity, ITopLevelEntity
	{

		[DataMember(Name="Attributes", EmitDefaultValue=false)]
		public List<ConfigurationEntryAttributes>? Attributes { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: Completed 
		/// DAC: PX.Objects.AM.AMConfigurationResults 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Completed", EmitDefaultValue=false)]
		public BooleanValue? Completed { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ConfigResultsID 
		/// DAC: PX.Objects.AM.AMConfigurationResults 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ConfigResultsID", EmitDefaultValue=false)]
		public IntValue? ConfigResultsID { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ConfigurationID 
		/// DAC: PX.Objects.AM.AMConfigurationResults 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ConfigurationID", EmitDefaultValue=false)]
		public StringValue? ConfigurationID { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: Revision 
		/// DAC: PX.Objects.AM.AMConfigurationResults 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ConfRevision", EmitDefaultValue=false)]
		public StringValue? ConfRevision { get; set; }

		[DataMember(Name="Features", EmitDefaultValue=false)]
		public List<ConfigurationEntryFeatures>? Features { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: InventoryID 
		/// DAC: PX.Objects.AM.AMConfigurationResults 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="InventoryID", EmitDefaultValue=false)]
		public StringValue? InventoryID { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: OpportunityLineNbr 
		/// DAC: PX.Objects.AM.AMConfigurationResults 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="OpportunityLineNbr", EmitDefaultValue=false)]
		public IntValue? OpportunityLineNbr { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: OpportunityQuoteID 
		/// DAC: PX.Objects.AM.AMConfigurationResults 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="OpportunityQuoteID", EmitDefaultValue=false)]
		public GuidValue? OpportunityQuoteID { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ProdOrderNbr 
		/// DAC: PX.Objects.AM.AMConfigurationResults 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ProdOrderNbr", EmitDefaultValue=false)]
		public StringValue? ProdOrderNbr { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ProdOrderType 
		/// DAC: PX.Objects.AM.AMConfigurationResults 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ProdOrderType", EmitDefaultValue=false)]
		public StringValue? ProdOrderType { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: OrdLineRef 
		/// DAC: PX.Objects.AM.AMConfigurationResults 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="SOLineNbr", EmitDefaultValue=false)]
		public IntValue? SOLineNbr { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: OrdNbrRef 
		/// DAC: PX.Objects.AM.AMConfigurationResults 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="SOOrderNbr", EmitDefaultValue=false)]
		public StringValue? SOOrderNbr { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: OrdTypeRef 
		/// DAC: PX.Objects.AM.AMConfigurationResults 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="SOOrderType", EmitDefaultValue=false)]
		public StringValue? SOOrderType { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: IsConfigurationTesting 
		/// DAC: PX.Objects.AM.AMConfigurationResults 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="TestConfiguration", EmitDefaultValue=false)]
		public BooleanValue? TestConfiguration { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: SiteID 
		/// DAC: PX.Objects.AM.AMConfigurationResults 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Warehouse", EmitDefaultValue=false)]
		public StringValue? Warehouse { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/MANUFACTURING/23.200.001";
		}
	}
}