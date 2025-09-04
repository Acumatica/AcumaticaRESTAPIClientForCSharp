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
	/// Corresponds to the screen AM306010 in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class ConfigurationEntry : Entity, ITopLevelEntity
	{

		[DataMember(Name="Attributes", EmitDefaultValue=false)]
		public List<ConfigurationEntryAttributes>? Attributes { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMConfigurationResults 
		/// </summary>
		[DataMember(Name="Completed", EmitDefaultValue=false)]
		public BooleanValue? Completed { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMConfigurationResults 
		/// Display Name: Config Results ID 
		/// Key Field
		/// </summary>
		[DataMember(Name="ConfigResultsID", EmitDefaultValue=false)]
		public IntValue? ConfigResultsID { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMConfigurationResults 
		/// Display Name: Configuration ID 
		/// SQL Type: nvarchar(15) 
		/// </summary>
		[DataMember(Name="ConfigurationID", EmitDefaultValue=false)]
		public StringValue? ConfigurationID { get; set; }

		/// <summary>
		/// DAC Field Name: Revision 
		/// DAC: PX.Objects.AM.AMConfigurationResults 
		/// Display Name: Conf. Revision 
		/// SQL Type: nvarchar(10) 
		/// </summary>
		[DataMember(Name="ConfRevision", EmitDefaultValue=false)]
		public StringValue? ConfRevision { get; set; }

		[DataMember(Name="Features", EmitDefaultValue=false)]
		public List<ConfigurationEntryFeatures>? Features { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMConfigurationResults 
		/// Display Name: Inventory ID 
		/// </summary>
		[DataMember(Name="InventoryID", EmitDefaultValue=false)]
		public StringValue? InventoryID { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMConfigurationResults 
		/// Display Name: Opportunity Line Nbr 
		/// </summary>
		[DataMember(Name="OpportunityLineNbr", EmitDefaultValue=false)]
		public IntValue? OpportunityLineNbr { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMConfigurationResults 
		/// Display Name: Opportunity Quote ID 
		/// </summary>
		[DataMember(Name="OpportunityQuoteID", EmitDefaultValue=false)]
		public GuidValue? OpportunityQuoteID { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMConfigurationResults 
		/// Display Name: Prod Order Nbr 
		/// SQL Type: nvarchar(15) 
		/// </summary>
		[DataMember(Name="ProdOrderNbr", EmitDefaultValue=false)]
		public StringValue? ProdOrderNbr { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMConfigurationResults 
		/// Display Name: Prod Order Type 
		/// SQL Type: char(2) 
		/// </summary>
		[DataMember(Name="ProdOrderType", EmitDefaultValue=false)]
		public StringValue? ProdOrderType { get; set; }

		/// <summary>
		/// DAC Field Name: OrdLineRef 
		/// DAC: PX.Objects.AM.AMConfigurationResults 
		/// Display Name: SO Line Nbr. 
		/// </summary>
		[DataMember(Name="SOLineNbr", EmitDefaultValue=false)]
		public IntValue? SOLineNbr { get; set; }

		/// <summary>
		/// DAC Field Name: OrdNbrRef 
		/// DAC: PX.Objects.AM.AMConfigurationResults 
		/// Display Name: SO Order Nbr 
		/// SQL Type: nvarchar(15) 
		/// </summary>
		[DataMember(Name="SOOrderNbr", EmitDefaultValue=false)]
		public StringValue? SOOrderNbr { get; set; }

		/// <summary>
		/// DAC Field Name: OrdTypeRef 
		/// DAC: PX.Objects.AM.AMConfigurationResults 
		/// Display Name: SO Order Type 
		/// SQL Type: char(2) 
		/// </summary>
		[DataMember(Name="SOOrderType", EmitDefaultValue=false)]
		public StringValue? SOOrderType { get; set; }

		/// <summary>
		/// Indicates the configuration is running in test mode (no persist to the database)
		/// DAC Field Name: IsConfigurationTesting 
		/// DAC: PX.Objects.AM.AMConfigurationResults 
		/// Display Name: Test Configuration 
		/// </summary>
		[DataMember(Name="TestConfiguration", EmitDefaultValue=false)]
		public BooleanValue? TestConfiguration { get; set; }

		/// <summary>
		/// DAC Field Name: SiteID 
		/// DAC: PX.Objects.AM.AMConfigurationResults 
		/// </summary>
		[DataMember(Name="Warehouse", EmitDefaultValue=false)]
		public StringValue? Warehouse { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/MANUFACTURING/24.200.001";
		}
	}
}