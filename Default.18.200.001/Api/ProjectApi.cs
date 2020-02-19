using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Acumatica.RESTClient.Api;
using Acumatica.RESTClient.Client;
using Acumatica.Default_18_200_001.Model;

namespace Acumatica.Default_18_200_001.Api
{
    public partial class ProjectApi : EntityAPI<Project>
    {
        public ProjectApi(Configuration configuration) : base(configuration)
        {
        }
        public string InvokeApproveProjectAction(Project project)
        {
            return InvokeAction(new ApproveProject(project));
        }
    }
}
