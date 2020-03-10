using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.POS_17_200_001.Model
{
	[DataContract]
	public partial class CancelSendingEmail : EntityAction<Email>
	{
		public CancelSendingEmail(Email entity) : base(entity)
		{ }
		public CancelSendingEmail() : base()
		{ }
	}
}
