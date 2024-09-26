using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_23_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen CS205000 in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class AttributeDefinition : Entity, ITopLevelEntity
	{

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: AttributeID 
		/// DAC: PX.Objects.CS.CSAttribute 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="AttributeID", EmitDefaultValue=false)]
		public StringValue? AttributeID { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ControlType 
		/// DAC: PX.Objects.CS.CSAttribute 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ControlType", EmitDefaultValue=false)]
		public StringValue? ControlType { get; set; }

		[DataMember(Name="CreatedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? CreatedDateTime { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: Description 
		/// DAC: PX.Objects.CS.CSAttribute 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: EntryMask 
		/// DAC: PX.Objects.CS.CSAttribute 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="EntryMask", EmitDefaultValue=false)]
		public StringValue? EntryMask { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: IsInternal 
		/// DAC: PX.Objects.CS.CSAttribute 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Internal", EmitDefaultValue=false)]
		public BooleanValue? Internal { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? LastModifiedDateTime { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: RegExp 
		/// DAC: PX.Objects.CS.CSAttribute 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="RegExp", EmitDefaultValue=false)]
		public StringValue? RegExp { get; set; }

		[DataMember(Name="Values", EmitDefaultValue=false)]
		public List<AttributeDefinitionValue>? Values { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/Default/23.200.001";
		}
	}
}