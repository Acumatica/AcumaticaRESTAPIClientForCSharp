using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.Default_18_200_001.Model
{
	[DataContract]
	public class LinkEntityToActivity : EntityActionWithParameters<Activity, LinkEntityToActivityParameters>
	{
		public LinkEntityToActivity() : base()
		{ }
		public LinkEntityToActivity(Activity entity, LinkEntityToActivityParameters parameters) : base(entity, parameters)
		{ }
	}
}