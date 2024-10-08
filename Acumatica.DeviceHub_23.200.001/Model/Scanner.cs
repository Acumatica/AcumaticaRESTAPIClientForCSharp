using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.DeviceHub_23_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen SM206540 in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class Scanner : Entity, ITopLevelEntity
	{

		/// <summary>
		/// DAC: PX.SM.SMScanner 
		/// SQL Type: nvarchar(255) 
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		/// <summary>
		/// DAC Field Name: DeviceHubID 
		/// DAC: PX.SM.SMScanner 
		/// Display Name: DeviceHub ID 
		/// SQL Type: varchar(30) 
		/// Key Field
		/// </summary>
		[DataMember(Name="DeviceHub", EmitDefaultValue=false)]
		public StringValue? DeviceHub { get; set; }

		/// <summary>
		/// DAC: PX.SM.SMScanner 
		/// Display Name: File Types 
		/// SQL Type: nvarchar(255) 
		/// </summary>
		[DataMember(Name="FileTypeComboValues", EmitDefaultValue=false)]
		public StringValue? FileTypeComboValues { get; set; }

		/// <summary>
		/// DAC: PX.SM.SMScanner 
		/// Display Name: File Type (Default) 
		/// </summary>
		[DataMember(Name="FileTypeDefValue", EmitDefaultValue=false)]
		public StringValue? FileTypeDefValue { get; set; }

		/// <summary>
		/// DAC: PX.SM.SMScanner 
		/// Display Name: Active 
		/// </summary>
		[DataMember(Name="IsActive", EmitDefaultValue=false)]
		public BooleanValue? IsActive { get; set; }

		/// <summary>
		/// DAC: PX.SM.SMScanner 
		/// Display Name: Paper Sources 
		/// SQL Type: nvarchar(255) 
		/// </summary>
		[DataMember(Name="PaperSourceComboValues", EmitDefaultValue=false)]
		public StringValue? PaperSourceComboValues { get; set; }

		/// <summary>
		/// DAC: PX.SM.SMScanner 
		/// Display Name: Paper Source (Default) 
		/// </summary>
		[DataMember(Name="PaperSourceDefValue", EmitDefaultValue=false)]
		public StringValue? PaperSourceDefValue { get; set; }

		/// <summary>
		/// DAC: PX.SM.SMScanner 
		/// Display Name: Color Modes 
		/// SQL Type: nvarchar(255) 
		/// </summary>
		[DataMember(Name="PixelTypeComboValues", EmitDefaultValue=false)]
		public StringValue? PixelTypeComboValues { get; set; }

		/// <summary>
		/// DAC: PX.SM.SMScanner 
		/// Display Name: Color Mode (Default) 
		/// </summary>
		[DataMember(Name="PixelTypeDefValue", EmitDefaultValue=false)]
		public StringValue? PixelTypeDefValue { get; set; }

		/// <summary>
		/// DAC: PX.SM.SMScanner 
		/// Display Name: Resolutions 
		/// SQL Type: nvarchar(4000) 
		/// </summary>
		[DataMember(Name="ResolutionComboValues", EmitDefaultValue=false)]
		public StringValue? ResolutionComboValues { get; set; }

		/// <summary>
		/// DAC: PX.SM.SMScanner 
		/// Display Name: Resolution (Default) 
		/// </summary>
		[DataMember(Name="ResolutionDefValue", EmitDefaultValue=false)]
		public StringValue? ResolutionDefValue { get; set; }

		/// <summary>
		/// DAC: PX.SM.SMScanner 
		/// Display Name: Scanner ID 
		/// SQL Type: varchar(20) 
		/// Key Field
		/// </summary>
		[DataMember(Name="ScannerName", EmitDefaultValue=false)]
		public StringValue? ScannerName { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/DeviceHub/23.200.001";
		}
	}
}