using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.DeviceHub_23_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen <c>SM206505</c> in the Acumatica ERP
	/// <para>Key Fields: ScanJobID</para>
	/// </summary>
	public class ScanJobs : Entity, ITopLevelEntity
	{

		/// <summary>
		/// <para>DAC Field Name: DeviceHubID</para>
		/// <para>DAC: PX.SM.SMScanJob</para>
		/// <para>Display Name: DeviceHub ID</para>
		/// <para>SQL Type: varchar(30)</para>
		/// </summary>
		public StringValue? DeviceHub { get; set; }

		/// <summary>
		/// <para>DAC Field Name: Error</para>
		/// <para>DAC: PX.SM.SMScanJob</para>
		/// <para>Display Name: Error</para>
		/// <para>SQL Type: nvarchar(255)</para>
		/// </summary>
		public StringValue? ErrorMessage { get; set; }

		public StringValue? ErrorTrace { get; set; }

		/// <summary>
		/// <para>DAC: PX.SM.SMScanJob</para>
		/// <para>Display Name: Job ID</para>
		/// Key Field
		/// </summary>
		public IntValue? ScanJobID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ScannerName</para>
		/// <para>DAC: PX.SM.SMScanJob</para>
		/// <para>Display Name: Scanner ID</para>
		/// <para>SQL Type: varchar(20)</para>
		/// </summary>
		public StringValue? Scanner { get; set; }

		/// <summary>
		/// <para>DAC: PX.SM.SMScanJob</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		public StringValue? Status { get; set; }

		public static class Expand
		{
			public const string Files = "Files";
			public const string Translations = "Translations";

			//Intentionally excluded
			//public const string All = "Files,Translations";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/DeviceHub/23.200.001";
		}
	}
}