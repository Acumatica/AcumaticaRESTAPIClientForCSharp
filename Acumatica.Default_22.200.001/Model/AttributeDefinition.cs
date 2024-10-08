using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_22_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen CS205000 in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class AttributeDefinition : Entity, ITopLevelEntity
	{

		/// <summary>
		/// DAC: PX.Objects.CS.CSAttribute 
		/// Display Name: Attribute ID 
		/// SQL Type: nvarchar(10) 
		/// Key Field
		/// </summary>
		[DataMember(Name="AttributeID", EmitDefaultValue=false)]
		public StringValue? AttributeID { get; set; }

		/// <summary>
		/// DAC: PX.Objects.CS.CSAttribute 
		/// Display Name: Control Type 
		/// </summary>
		[DataMember(Name="ControlType", EmitDefaultValue=false)]
		public StringValue? ControlType { get; set; }

		[DataMember(Name="CreatedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? CreatedDateTime { get; set; }

		/// <summary>
		/// DAC: PX.Objects.CS.CSAttribute 
		/// SQL Type: nvarchar(60) 
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		/// <summary>
		/// DAC: PX.Objects.CS.CSAttribute 
		/// Display Name: Entry Mask 
		/// SQL Type: varchar(60) 
		/// </summary>
		[DataMember(Name="EntryMask", EmitDefaultValue=false)]
		public StringValue? EntryMask { get; set; }

		/// <summary>
		/// DAC Field Name: IsInternal 
		/// DAC: PX.Objects.CS.CSAttribute 
		/// </summary>
		[DataMember(Name="Internal", EmitDefaultValue=false)]
		public BooleanValue? Internal { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? LastModifiedDateTime { get; set; }

		/// <summary>
		/// DAC: PX.Objects.CS.CSAttribute 
		/// Display Name: Reg. Exp. 
		/// SQL Type: nvarchar(255) 
		/// </summary>
		[DataMember(Name="RegExp", EmitDefaultValue=false)]
		public StringValue? RegExp { get; set; }

		[DataMember(Name="Values", EmitDefaultValue=false)]
		public List<AttributeDefinitionValue>? Values { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/Default/22.200.001";
		}
	}
}