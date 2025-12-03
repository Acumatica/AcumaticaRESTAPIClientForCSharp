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
	/// Corresponds to the screen <c>SM206510</c> in the Acumatica ERP
	/// <para>Key Fields: DeviceHub, PrinterName</para>
	/// </summary>
	[DataContract]
	public class Printer : Entity, ITopLevelEntity
	{

		/// <summary>
		/// <para>DAC: PX.SM.SMPrinter</para>
		/// <para>SQL Type: nvarchar(255)</para>
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		/// <summary>
		/// <para>DAC Field Name: DeviceHubID</para>
		/// <para>DAC: PX.SM.SMPrinter</para>
		/// <para>Display Name: DeviceHub ID</para>
		/// <para>SQL Type: varchar(30)</para>
		/// Key Field
		/// </summary>
		[DataMember(Name="DeviceHub", EmitDefaultValue=false)]
		public StringValue? DeviceHub { get; set; }

		/// <summary>
		/// <para>DAC: PX.SM.SMPrinter</para>
		/// <para>Display Name: Active</para>
		/// </summary>
		[DataMember(Name="IsActive", EmitDefaultValue=false)]
		public BooleanValue? IsActive { get; set; }

		/// <summary>
		/// <para>DAC: PX.SM.SMPrinter</para>
		/// <para>Display Name: Printer</para>
		/// <para>SQL Type: varchar(20)</para>
		/// Key Field
		/// </summary>
		[DataMember(Name="PrinterName", EmitDefaultValue=false)]
		public StringValue? PrinterName { get; set; }

		public static class Expand
		{
			public const string Files = "Files";

			//Intentionally excluded
			//public const string All = "Files";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/DeviceHub/23.200.001";
		}
	}
}