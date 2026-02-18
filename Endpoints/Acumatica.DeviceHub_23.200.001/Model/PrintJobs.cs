using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.DeviceHub_23_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen <c>SM206500</c> in the Acumatica ERP
	/// <para>Key Fields: JobID</para>
	/// </summary>
	public class PrintJobs : Entity, ITopLevelEntity
	{

		/// <summary>
		/// <para>DAC: PX.SM.SMPrintJobFilter</para>
		/// <para>Display Name: End Date</para>
		/// </summary>
		public DateTimeValue? EndDate { get; set; }

		public DateTimeValue? EndModifiedDateTime { get; set; }

		/// <summary>
		/// <para>DAC: PX.SM.SMPrintJobFilter</para>
		/// <para>Display Name: Hide Processed</para>
		/// </summary>
		public BooleanValue? HideProcessed { get; set; }

		/// <summary>
		/// <para>DAC: PX.SM.SMPrintJob</para>
		/// <para>Display Name: Job ID</para>
		/// Key Field
		/// </summary>
		public IntValue? JobID { get; set; }

		public List<PrintJob>? Jobs { get; set; }

		/// <summary>
		/// <para>DAC: PX.SM.SMPrintJobFilter</para>
		/// <para>Display Name: Start Date</para>
		/// </summary>
		public DateTimeValue? StartDate { get; set; }

		public DateTimeValue? StartModifiedDateTime { get; set; }

		public static class Expand
		{
			public const string Files = "Files";
			public const string Translations = "Translations";
			public const string Jobs = "Jobs";
			public const string Jobs_Files = "Jobs/Files";
			public const string Jobs_Parameters = "Jobs/Parameters";
			public const string Jobs_Parameters_Files = "Jobs/Parameters/Files";

			//Intentionally excluded
			//public const string All = "Files,Translations,Jobs,Jobs/Files,Jobs/Parameters,Jobs/Parameters/Files";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/DeviceHub/23.200.001";
		}
	}
}