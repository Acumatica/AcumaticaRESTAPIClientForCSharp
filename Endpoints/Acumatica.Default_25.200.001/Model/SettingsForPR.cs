using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_25_200_001.Model
{
	[DataContract]
	public class SettingsForPR : Entity
	{

		/// <summary>
		/// <para>DAC Field Name: PRBatchExportSYMappingID</para>
		/// <para>DAC: PX.Objects.CA.PaymentMethod</para>
		/// <para>Display Name: Export Scenario</para>
		/// </summary>
		[DataMember(Name="ExportScenario", EmitDefaultValue=false)]
		public StringValue? ExportScenario { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.CA.PaymentMethod</para>
		/// <para>SQL Type: nvarchar(MAX)</para>
		/// </summary>
		[DataMember(Name="PRProcessing", EmitDefaultValue=false)]
		public StringValue? PRProcessing { get; set; }

		/// <summary>
		/// <para>DAC Field Name: PRCheckReportID</para>
		/// <para>DAC: PX.Objects.CA.PaymentMethod</para>
		/// <para>SQL Type: varchar(8)</para>
		/// </summary>
		[DataMember(Name="Report", EmitDefaultValue=false)]
		public StringValue? Report { get; set; }

	}
}