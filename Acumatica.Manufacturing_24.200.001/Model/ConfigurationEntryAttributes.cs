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
	public class ConfigurationEntryAttributes : Entity
	{

		/// <summary>
		/// DAC: PX.Objects.AM.AMConfigResultsAttribute 
		/// Display Name: Attribute Line Nbr 
		/// Key Field
		/// </summary>
		[DataMember(Name="AttributeLineNbr", EmitDefaultValue=false)]
		public IntValue? AttributeLineNbr { get; set; }

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
		/// DAC Field Name: AMConfigurationAttribute__Descr 
		/// DAC: PX.Objects.AM.AMConfigResultsAttribute 
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		/// <summary>
		/// DAC Field Name: AMConfigurationAttribute__Label 
		/// DAC: PX.Objects.AM.AMConfigResultsAttribute 
		/// </summary>
		[DataMember(Name="Label", EmitDefaultValue=false)]
		public StringValue? Label { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMConfigResultsAttribute 
		/// </summary>
		[DataMember(Name="Required", EmitDefaultValue=false)]
		public BooleanValue? Required { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMConfigurationResults 
		/// Display Name: Conf. Revision 
		/// SQL Type: nvarchar(10) 
		/// </summary>
		[DataMember(Name="Revision", EmitDefaultValue=false)]
		public StringValue? Revision { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMConfigResultsAttribute 
		/// SQL Type: nvarchar(255) 
		/// </summary>
		[DataMember(Name="Value", EmitDefaultValue=false)]
		public StringValue? Value { get; set; }

	}
}