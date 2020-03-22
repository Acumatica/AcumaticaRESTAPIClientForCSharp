using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.POS_17_200_001.Model
{
	[DataContract]
	public class UpdateDiscounts : EntityActionWithParameters<Discount, UpdateDiscountsParameters>
	{
		public UpdateDiscounts() : base()
		{ }
		public UpdateDiscounts(Discount entity, UpdateDiscountsParameters parameters) : base(entity, parameters)
		{ }
	}
}