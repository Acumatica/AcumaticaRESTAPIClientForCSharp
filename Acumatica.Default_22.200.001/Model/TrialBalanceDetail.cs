using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_22_200_001.Model
{
	[DataContract]
	public class TrialBalanceDetail : Entity
	{

		/// <summary>
		/// DAC Field Name: CuryYtdBalance 
		/// DAC: PX.Objects.GL.GLTrialBalanceImportDetails 
		/// Display Name: Currency YTD Balance 
		/// </summary>
		[DataMember(Name="CurrencyYTDBalance", EmitDefaultValue=false)]
		public DecimalValue? CurrencyYTDBalance { get; set; }

		/// <summary>
		/// DAC: PX.Objects.GL.GLTrialBalanceImportMap 
		/// SQL Type: nvarchar(255) 
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		/// <summary>
		/// DAC Field Name: ImportAccountCD 
		/// DAC: PX.Objects.GL.GLTrialBalanceImportDetails 
		/// Display Name: Imported Account 
		/// SQL Type: nvarchar(10) 
		/// </summary>
		[DataMember(Name="ImportedAccount", EmitDefaultValue=false)]
		public StringValue? ImportedAccount { get; set; }

		/// <summary>
		/// DAC Field Name: ImportSubAccountCD 
		/// DAC: PX.Objects.GL.GLTrialBalanceImportDetails 
		/// Display Name: Imported Subaccount 
		/// SQL Type: nvarchar(30) 
		/// </summary>
		[DataMember(Name="ImportedSubaccount", EmitDefaultValue=false)]
		public StringValue? ImportedSubaccount { get; set; }

		[DataMember(Name="Line", EmitDefaultValue=false)]
		public IntValue? Line { get; set; }

		[DataMember(Name="MapNbr", EmitDefaultValue=false)]
		public StringValue? MapNbr { get; set; }

		/// <summary>
		/// DAC Field Name: MapAccountID 
		/// DAC: PX.Objects.GL.GLTrialBalanceImportDetails 
		/// Display Name: Mapped Account 
		/// </summary>
		[DataMember(Name="MappedAccount", EmitDefaultValue=false)]
		public StringValue? MappedAccount { get; set; }

		/// <summary>
		/// DAC Field Name: MapSubAccountID 
		/// DAC: PX.Objects.GL.GLTrialBalanceImportDetails 
		/// Display Name: Mapped Subaccount 
		/// </summary>
		[DataMember(Name="MappedSubaccount", EmitDefaultValue=false)]
		public StringValue? MappedSubaccount { get; set; }

		/// <summary>
		/// Specifies (if set to true) that a user has selected the record in the table on the form for processing.
		/// DAC: PX.Objects.GL.GLTrialBalanceImportDetails 
		/// </summary>
		[DataMember(Name="Selected", EmitDefaultValue=false)]
		public BooleanValue? Selected { get; set; }

		/// <summary>
		/// DAC: PX.Objects.GL.GLTrialBalanceImportMap 
		/// SQL Type: char(1) 
		/// </summary>
		[DataMember(Name="Status", EmitDefaultValue=false)]
		public StringValue? Status { get; set; }

		/// <summary>
		/// DAC Field Name: AccountType 
		/// DAC: PX.Objects.GL.GLTrialBalanceImportDetails 
		/// SQL Type: nvarchar(1) 
		/// </summary>
		[DataMember(Name="Type", EmitDefaultValue=false)]
		public StringValue? Type { get; set; }

		/// <summary>
		/// DAC Field Name: YtdBalance 
		/// DAC: PX.Objects.GL.GLTrialBalanceImportDetails 
		/// Display Name: YTD Balance 
		/// </summary>
		[DataMember(Name="YTDBalance", EmitDefaultValue=false)]
		public DecimalValue? YTDBalance { get; set; }

	}
}