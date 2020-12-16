using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Default_20_200_001.Model
{
	[DataContract]
	public class TrialBalanceDetail : Entity_v4
	{

		[DataMember(Name="CurrencyYTDBalance", EmitDefaultValue=false)]
		public DecimalValue CurrencyYTDBalance { get; set; }

		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue Description { get; set; }

		[DataMember(Name="ImportedAccount", EmitDefaultValue=false)]
		public StringValue ImportedAccount { get; set; }

		[DataMember(Name="ImportedSubaccount", EmitDefaultValue=false)]
		public StringValue ImportedSubaccount { get; set; }

		[DataMember(Name="Line", EmitDefaultValue=false)]
		public IntValue Line { get; set; }

		[DataMember(Name="MapNbr", EmitDefaultValue=false)]
		public StringValue MapNbr { get; set; }

		[DataMember(Name="MappedAccount", EmitDefaultValue=false)]
		public StringValue MappedAccount { get; set; }

		[DataMember(Name="MappedSubaccount", EmitDefaultValue=false)]
		public StringValue MappedSubaccount { get; set; }

		[DataMember(Name="Selected", EmitDefaultValue=false)]
		public BooleanValue Selected { get; set; }

		[DataMember(Name="Status", EmitDefaultValue=false)]
		public StringValue Status { get; set; }

		[DataMember(Name="Type", EmitDefaultValue=false)]
		public StringValue Type { get; set; }

		[DataMember(Name="YTDBalance", EmitDefaultValue=false)]
		public DecimalValue YTDBalance { get; set; }

	}
}