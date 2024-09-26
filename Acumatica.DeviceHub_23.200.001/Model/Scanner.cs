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
		/// 
		/// Display Name:
		/// DAC Field Name: Description 
		/// DAC: PX.SM.SMScanner 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: DeviceHubID 
		/// DAC: PX.SM.SMScanner 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="DeviceHub", EmitDefaultValue=false)]
		public StringValue? DeviceHub { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: FileTypeComboValues 
		/// DAC: PX.SM.SMScanner 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="FileTypeComboValues", EmitDefaultValue=false)]
		public StringValue? FileTypeComboValues { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: FileTypeDefValue 
		/// DAC: PX.SM.SMScanner 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="FileTypeDefValue", EmitDefaultValue=false)]
		public StringValue? FileTypeDefValue { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: IsActive 
		/// DAC: PX.SM.SMScanner 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="IsActive", EmitDefaultValue=false)]
		public BooleanValue? IsActive { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: PaperSourceComboValues 
		/// DAC: PX.SM.SMScanner 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="PaperSourceComboValues", EmitDefaultValue=false)]
		public StringValue? PaperSourceComboValues { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: PaperSourceDefValue 
		/// DAC: PX.SM.SMScanner 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="PaperSourceDefValue", EmitDefaultValue=false)]
		public StringValue? PaperSourceDefValue { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: PixelTypeComboValues 
		/// DAC: PX.SM.SMScanner 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="PixelTypeComboValues", EmitDefaultValue=false)]
		public StringValue? PixelTypeComboValues { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: PixelTypeDefValue 
		/// DAC: PX.SM.SMScanner 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="PixelTypeDefValue", EmitDefaultValue=false)]
		public StringValue? PixelTypeDefValue { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ResolutionComboValues 
		/// DAC: PX.SM.SMScanner 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ResolutionComboValues", EmitDefaultValue=false)]
		public StringValue? ResolutionComboValues { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ResolutionDefValue 
		/// DAC: PX.SM.SMScanner 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ResolutionDefValue", EmitDefaultValue=false)]
		public StringValue? ResolutionDefValue { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ScannerName 
		/// DAC: PX.SM.SMScanner 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ScannerName", EmitDefaultValue=false)]
		public StringValue? ScannerName { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/DeviceHub/23.200.001";
		}
	}
}