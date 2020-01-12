
using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.DefaultEndpoint_18_200_001.Model
{
[DataContract]
 public partial class ReleaseExpenseClaim : EntityAction<ExpenseClaim>
    {
 public ReleaseExpenseClaim(ExpenseClaim entity) : base(entity)
        { }

[DataMember(Name = "entity", EmitDefaultValue = false)]
        public ExpenseClaim Entity
        {
            get
            {
                return _Entity;
            }
            set
            {
                _Entity = value;
            }
        }
    }
}
