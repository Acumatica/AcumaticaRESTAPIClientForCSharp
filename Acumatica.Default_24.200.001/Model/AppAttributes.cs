using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_24_200_001.Model
{
	[DataContract]
	public class AppAttributes : Entity
	{

		/// <summary>
		/// DAC Field Name: AttributeID 
		/// DAC: PX.Objects.CS.CSAnswers 
		/// SQL Type: nvarchar(10) 
		/// Key Field
		/// </summary>
		[DataMember(Name="Attribute", EmitDefaultValue=false)]
		public StringValue? Attribute { get; set; }

		/// <summary>
		/// DAC: PX.Objects.FS.FSApptLineSplit 
		/// Display Name: Related Document 
		/// </summary>
		[DataMember(Name="RefNoteID", EmitDefaultValue=false)]
		public GuidValue? RefNoteID { get; set; }

		/// <summary>
		/// DAC Field Name: isRequired 
		/// DAC: PX.Objects.CS.CSAnswers 
		/// </summary>
		[DataMember(Name="Required", EmitDefaultValue=false)]
		public BooleanValue? Required { get; set; }

		/// <summary>
		/// DAC: PX.Objects.CS.CSAnswers 
		/// SQL Type: nvarchar(255) 
		/// </summary>
		[DataMember(Name="Value", EmitDefaultValue=false)]
		public StringValue? Value { get; set; }

	}
}