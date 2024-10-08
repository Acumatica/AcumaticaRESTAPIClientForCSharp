using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Manufacturing_23_100_001.Model
{
	[DataContract]
	public class OrderTypeAttribute : Entity
	{

		/// <summary>
		/// DAC: PX.Objects.AM.AMOrderTypeAttribute 
		/// Display Name: Attribute ID 
		/// SQL Type: nvarchar(10) 
		/// </summary>
		[DataMember(Name="AttributeID", EmitDefaultValue=false)]
		public StringValue? AttributeID { get; set; }

		/// <summary>
		/// DAC Field Name: Descr 
		/// DAC: PX.Objects.AM.AMOrderType 
		/// SQL Type: nvarchar(60) 
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMOrderTypeAttribute 
		/// </summary>
		[DataMember(Name="Enabled", EmitDefaultValue=false)]
		public BooleanValue? Enabled { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMOrderTypeAttribute 
		/// SQL Type: nvarchar(30) 
		/// </summary>
		[DataMember(Name="Label", EmitDefaultValue=false)]
		public StringValue? Label { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMOrderTypeAttribute 
		/// Display Name: Line Nbr 
		/// Key Field
		/// </summary>
		[DataMember(Name="LineNbr", EmitDefaultValue=false)]
		public IntValue? LineNbr { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMOrderTypeAttribute 
		/// Display Name: Transaction Required 
		/// </summary>
		[DataMember(Name="TransactionRequired", EmitDefaultValue=false)]
		public BooleanValue? TransactionRequired { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMOrderTypeAttribute 
		/// SQL Type: nvarchar(255) 
		/// </summary>
		[DataMember(Name="Value", EmitDefaultValue=false)]
		public StringValue? Value { get; set; }

	}
}