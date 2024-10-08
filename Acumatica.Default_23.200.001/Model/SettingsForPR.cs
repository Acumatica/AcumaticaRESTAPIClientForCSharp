using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_23_200_001.Model
{
	[DataContract]
	public class SettingsForPR : Entity
	{

		/// <summary>
		/// DAC Field Name: PRBatchExportSYMappingID 
		/// DAC: PX.Objects.CA.PaymentMethod 
		/// Display Name: Export Scenario 
		/// </summary>
		[DataMember(Name="ExportScenario", EmitDefaultValue=false)]
		public StringValue? ExportScenario { get; set; }

		/// <summary>
		/// DAC: PX.Objects.CA.PaymentMethod 
		/// SQL Type: nvarchar(MAX) 
		/// </summary>
		[DataMember(Name="PRProcessing", EmitDefaultValue=false)]
		public StringValue? PRProcessing { get; set; }

		/// <summary>
		/// DAC Field Name: PRCheckReportID 
		/// DAC: PX.Objects.CA.PaymentMethod 
		/// SQL Type: varchar(8) 
		/// </summary>
		[DataMember(Name="Report", EmitDefaultValue=false)]
		public StringValue? Report { get; set; }

	}
}