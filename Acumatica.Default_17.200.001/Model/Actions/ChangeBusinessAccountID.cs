using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.Default_17_200_001.Model
{
	[DataContract]
	public class ChangeBusinessAccountID : EntityActionWithParameters<BusinessAccount, ChangeBusinessAccountIDParameters>
	{
		public ChangeBusinessAccountID() : base()
		{ }
		public ChangeBusinessAccountID(BusinessAccount entity, ChangeBusinessAccountIDParameters parameters) : base(entity, parameters)
		{ }
	}
}