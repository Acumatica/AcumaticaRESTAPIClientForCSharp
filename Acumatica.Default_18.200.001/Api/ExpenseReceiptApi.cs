using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Acumatica.RESTClient.Api;
using Acumatica.RESTClient.Client;
using Acumatica.Default_18_200_001.Model;

namespace Acumatica.Default_18_200_001.Api
{
    public partial class ExpenseReceiptApi : EntityAPI<ExpenseReceipt>
    {
        public ExpenseReceiptApi(Configuration configuration) : base(configuration)
        {
        }

        public string InvokeApproveExpenseReceiptAction(ExpenseReceipt expenseReceipt)
        {
            return InvokeAction(new ApproveExpenseReceipt(expenseReceipt));
        }
    }
}
