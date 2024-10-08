using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.GLConsolidation_22_200_001.Model
{
	[DataContract]
	public class ConsolidationItem : Entity
	{

		/// <summary>
		/// DAC: PX.Objects.GL.GLConsolData 
		/// Display Name: Account 
		/// SQL Type: nvarchar(30) 
		/// Key Field
		/// </summary>
		[DataMember(Name="AccountCD", EmitDefaultValue=false)]
		public StringValue? AccountCD { get; set; }

		/// <summary>
		/// DAC: PX.Objects.GL.GLConsolData 
		/// Display Name: Credit Amount 
		/// </summary>
		[DataMember(Name="ConsolAmtCredit", EmitDefaultValue=false)]
		public DecimalValue? ConsolAmtCredit { get; set; }

		/// <summary>
		/// DAC: PX.Objects.GL.GLConsolData 
		/// Display Name: Debit Amount 
		/// </summary>
		[DataMember(Name="ConsolAmtDebit", EmitDefaultValue=false)]
		public DecimalValue? ConsolAmtDebit { get; set; }

		/// <summary>
		/// DAC: PX.Objects.GL.GLConsolData 
		/// Display Name: Fin. Period 
		/// SQL Type: nchar(6) 
		/// Key Field
		/// </summary>
		[DataMember(Name="FinPeriodID", EmitDefaultValue=false)]
		public StringValue? FinPeriodID { get; set; }

		/// <summary>
		/// DAC: PX.Objects.GL.GLConsolData 
		/// Display Name: Mapped Sub. 
		/// SQL Type: nvarchar(30) 
		/// Key Field
		/// </summary>
		[DataMember(Name="MappedValue", EmitDefaultValue=false)]
		public StringValue? MappedValue { get; set; }

		/// <summary>
		/// DAC: PX.Objects.GL.GLConsolData 
		/// Display Name: Mapped Sub. Length 
		/// </summary>
		[DataMember(Name="MappedValueLength", EmitDefaultValue=false)]
		public IntValue? MappedValueLength { get; set; }

	}
}