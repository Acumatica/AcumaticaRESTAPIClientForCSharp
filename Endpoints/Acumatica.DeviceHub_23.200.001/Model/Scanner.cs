using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.DeviceHub_23_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen <c>SM206540</c> in the Acumatica ERP
	/// <para>Key Fields: DeviceHub, ScannerName</para>
	/// </summary>
	public class Scanner : Entity, ITopLevelEntity
	{

		/// <summary>
		/// <para>DAC: PX.SM.SMScanner</para>
		/// <para>SQL Type: nvarchar(255)</para>
		/// </summary>
		public StringValue? Description { get; set; }

		/// <summary>
		/// <para>DAC Field Name: DeviceHubID</para>
		/// <para>DAC: PX.SM.SMScanner</para>
		/// <para>Display Name: DeviceHub ID</para>
		/// <para>SQL Type: varchar(30)</para>
		/// Key Field
		/// </summary>
		public StringValue? DeviceHub { get; set; }

		/// <summary>
		/// <para>DAC: PX.SM.SMScanner</para>
		/// <para>Display Name: File Types</para>
		/// <para>SQL Type: nvarchar(255)</para>
		/// </summary>
		public StringValue? FileTypeComboValues { get; set; }

		/// <summary>
		/// <para>DAC: PX.SM.SMScanner</para>
		/// <para>Display Name: File Type (Default)</para>
		/// </summary>
		public StringValue? FileTypeDefValue { get; set; }

		/// <summary>
		/// <para>DAC: PX.SM.SMScanner</para>
		/// <para>Display Name: Active</para>
		/// </summary>
		public BooleanValue? IsActive { get; set; }

		/// <summary>
		/// <para>DAC: PX.SM.SMScanner</para>
		/// <para>Display Name: Paper Sources</para>
		/// <para>SQL Type: nvarchar(255)</para>
		/// </summary>
		public StringValue? PaperSourceComboValues { get; set; }

		/// <summary>
		/// <para>DAC: PX.SM.SMScanner</para>
		/// <para>Display Name: Paper Source (Default)</para>
		/// </summary>
		public StringValue? PaperSourceDefValue { get; set; }

		/// <summary>
		/// <para>DAC: PX.SM.SMScanner</para>
		/// <para>Display Name: Color Modes</para>
		/// <para>SQL Type: nvarchar(255)</para>
		/// </summary>
		public StringValue? PixelTypeComboValues { get; set; }

		/// <summary>
		/// <para>DAC: PX.SM.SMScanner</para>
		/// <para>Display Name: Color Mode (Default)</para>
		/// </summary>
		public StringValue? PixelTypeDefValue { get; set; }

		/// <summary>
		/// <para>DAC: PX.SM.SMScanner</para>
		/// <para>Display Name: Resolutions</para>
		/// <para>SQL Type: nvarchar(4000)</para>
		/// </summary>
		public StringValue? ResolutionComboValues { get; set; }

		/// <summary>
		/// <para>DAC: PX.SM.SMScanner</para>
		/// <para>Display Name: Resolution (Default)</para>
		/// </summary>
		public StringValue? ResolutionDefValue { get; set; }

		/// <summary>
		/// <para>DAC: PX.SM.SMScanner</para>
		/// <para>Display Name: Scanner ID</para>
		/// <para>SQL Type: varchar(20)</para>
		/// Key Field
		/// </summary>
		public StringValue? ScannerName { get; set; }

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