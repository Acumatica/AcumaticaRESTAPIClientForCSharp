
using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.DefaultEndpoint_18_200_001.Model
{
[DataContract]
 public partial class ProcessAllManageFinancialPeriods : EntityAction<ManageFinancialPeriods>
    {
 public ProcessAllManageFinancialPeriods(ManageFinancialPeriods entity) : base(entity)
        { }

[DataMember(Name = "entity", EmitDefaultValue = false)]
        public ManageFinancialPeriods Entity
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
