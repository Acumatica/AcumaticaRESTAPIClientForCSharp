using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_25_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen <c>AR208000</c> in the Acumatica ERP
	/// <para>Key Fields: PriceClassID</para>
	/// </summary>
	public class CustomerPriceClass : Entity, ITopLevelEntity
	{

		public DateTimeValue? CreatedDateTime { get; set; }

		/// <summary>
		/// The description of the customer price class.
		/// <para>DAC: PX.Objects.AR.ARPriceClass</para>
		/// <para>SQL Type: nvarchar(250)</para>
		/// </summary>
		public StringValue? Description { get; set; }

		public DateTimeValue? LastModifiedDateTime { get; set; }

		/// <summary>
		/// The unique identifier of the customer price class.This field is the key field.
		/// <para>DAC: PX.Objects.AR.ARPriceClass</para>
		/// <para>Display Name: Price Class ID</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// Key Field
		/// </summary>
		public StringValue? PriceClassID { get; set; }

		public GuidValue? NoteID { get; set; }

		public static class Expand
		{
			public const string Files = "Files";
			public const string Translations = "Translations";

			//Intentionally excluded
			//public const string All = "Files,Translations";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/Default/25.200.001";
		}
	}
}