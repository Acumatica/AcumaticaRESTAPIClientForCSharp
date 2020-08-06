using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.Default_20_200_001.Model
{
	[DataContract]
	public class CompleteActivity : EntityAction<Activity>
	{
		public CompleteActivity(Activity entity) : base(entity)
		{ }
		public CompleteActivity() : base()
		{ }
	}
}
