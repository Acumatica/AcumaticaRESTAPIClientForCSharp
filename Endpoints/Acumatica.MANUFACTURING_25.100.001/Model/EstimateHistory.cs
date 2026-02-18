using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.MANUFACTURING_25_100_001.Model
{
	public class EstimateHistory : Entity
	{

		/// <summary>
		/// The date and time when the record was created.
		/// <para>DAC Field Name: CreatedDateTime</para>
		/// <para>DAC: PX.Objects.AM.AMEstimateHistory</para>
		/// <para>Display Name: Created At</para>
		/// </summary>
		public DateTimeValue? CreatedAt { get; set; }

		/// <summary>
		/// The ID of the user who created the record.
		/// <para>DAC Field Name: CreatedByID</para>
		/// <para>DAC: PX.Objects.AM.AMEstimateHistory</para>
		/// <para>Display Name: Created By</para>
		/// </summary>
		public StringValue? CreatedBy { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMEstimateOper</para>
		/// <para>Display Name: Operation Desc</para>
		/// <para>SQL Type: nvarchar(256)</para>
		/// </summary>
		public StringValue? Description { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMEstimateItem</para>
		/// <para>Display Name: Estimate ID</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// Key Field
		/// </summary>
		public StringValue? EstimateID { get; set; }

		public IntValue? HistoryLineNumber { get; set; }

		/// <summary>
		/// <para>DAC Field Name: RevisionID</para>
		/// <para>DAC: PX.Objects.AM.AMEstimateItem</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// Key Field
		/// </summary>
		public StringValue? Revision { get; set; }

	}
}