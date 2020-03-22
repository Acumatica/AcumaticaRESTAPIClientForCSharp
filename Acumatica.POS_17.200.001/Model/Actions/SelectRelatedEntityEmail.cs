using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.POS_17_200_001.Model
{
	[DataContract]
	public class SelectRelatedEntityEmail : EntityActionWithParameters<Email, SelectRelatedEntityEmailParameters>
	{
		public SelectRelatedEntityEmail() : base()
		{ }
		public SelectRelatedEntityEmail(Email entity, SelectRelatedEntityEmailParameters parameters) : base(entity, parameters)
		{ }
	}
}