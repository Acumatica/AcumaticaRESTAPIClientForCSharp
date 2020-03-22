using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Default_18_200_001.Model
{
	[DataContract]
	public class NonStockItemSalesCategory : Entity
	{

		[DataMember(Name="CategoryID", EmitDefaultValue=false)]
		public IntValue CategoryID { get; set; }

	}
}