using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Default_20_200_001.Model
{
   [DataContract]
   public class Invoice : Entity_v4
   {
      /// <summary>
      /// The amount of the document after taxes and discounts.
      /// </summary>
      [DataMember(Name="Amount", EmitDefaultValue=false)]
      public DecimalValue Amount { get; set; }

      /// <summary>
      /// Credit Memos that pertain to this document.
      /// </summary>
      [DataMember(Name="ApplicationsCreditMemo", EmitDefaultValue=false)]
      public List<InvoiceApplicationsCreditMemo> ApplicationsCreditMemo { get; set; }

      /// <summary>
      /// The list of AR payments that have been applied to the document.
      /// </summary>
      [DataMember(Name="ApplicationsDefault", EmitDefaultValue=false)]
      public List<InvoiceApplicationsDefault> ApplicationsDefault { get; set; }

      /// <summary>
      /// For an open AR document, the outstanding balance after any payments were applied.
      /// For a document with the Open or Closed status, these payments are in the Applications.
      /// </summary>
      [DataMember(Name="Balance", EmitDefaultValue=false)]
      public DecimalValue Balance { get; set; }

      /// <summary>
      /// Whether or no the billing has been printed.
      /// </summary>
      [DataMember(Name="BillingPrinted", EmitDefaultValue=false)]
      public BooleanValue BillingPrinted { get; set; }
      
      /// <summary>
      /// The billing addresses of the customer and the contact information for billing purposes.
      /// </summary>
      [DataMember(Name="BillToContact", EmitDefaultValue=false)]
      public DocContact BillToContact { get; set; }

      /// <summary>
      /// If selected, indicates that the contact info is not the default contact information.
      /// </summary>
      [DataMember(Name="BillToContactOverride", EmitDefaultValue=false)]
      public BooleanValue BillToContactOverride { get; set; }

      /// <summary>
      /// The date of the creation of this invoice.
      /// </summary>
      [DataMember(Name="CreatedDateTime", EmitDefaultValue=false)]
      public DateTimeValue CreatedDateTime { get; set; }

      /// <summary>
      /// The customer associated with the document.
      /// </summary>
      [DataMember(Name="Customer", EmitDefaultValue=false)]
      public StringValue Customer { get; set; }

      /// <summary>
      /// The original reference number or ID assigned by the customer to the customer document.
      /// If the AR document has been crated based on a pro forma invoice,
      /// the reference number of the pro forma invoice is shown in the box.
      /// </summary>
      [DataMember(Name="CustomerOrder", EmitDefaultValue=false)]
      public StringValue CustomerOrder { get; set; }

      /// <summary>
      /// The date when the AR document was created.
      /// By default, for a new document, it is the current business date, but you can change the date.
      /// </summary>
      [DataMember(Name="Date", EmitDefaultValue=false)]
      public DateTimeValue Date { get; set; }

      /// <summary>
      /// Any user-provided description of the AR document.
      /// </summary>
      [DataMember(Name="Description", EmitDefaultValue=false)]
      public StringValue Description { get; set; }

      /// <summary>
      /// Line details of this document.
      /// </summary>
      [DataMember(Name="Details", EmitDefaultValue=false)]
      public List<InvoiceDetail> Details { get; set; }

      /// <summary>
      /// Document- and Group-level discounts that were applied to the document.
      /// </summary>
      [DataMember(Name="DiscountDetails", EmitDefaultValue=false)]
      public List<InvoiceDiscountDetail> DiscountDetails { get; set; }

      /// <summary>
      /// The date when payment for the document is due, in accordance with the credit terms.
      /// </summary>
      [DataMember(Name="DueDate", EmitDefaultValue=false)]
      public DateTimeValue DueDate { get; set; }

      /// <summary>
      /// Changes the status of the document to On Hold.
      /// </summary>
      [DataMember(Name="Hold", EmitDefaultValue=false)]
      public BooleanValue Hold { get; set; }

      /// <summary>
      /// The last time this document was modified.
      /// </summary>
      [DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
      public DateTimeValue LastModifiedDateTime { get; set; }

      /// <summary>
      /// A linked AR Account.
      /// </summary>
      [DataMember(Name="LinkARAccount", EmitDefaultValue=false)]
      public StringValue LinkARAccount { get; set; }

      /// <summary>
      /// A linked Branch.
      /// </summary>
      [DataMember(Name="LinkBranch", EmitDefaultValue=false)]
      public StringValue LinkBranch { get; set; }

      /// <summary>
      /// The location of the customer related to the document.
      /// By default, it is the default location of the selected customer or, if the invoice is created from an
      /// opportunity, it is the customer location specified for the opportunity.
      /// </summary>
      [DataMember(Name="LocationID", EmitDefaultValue=false)]
      public StringValue LocationID { get; set; }

      /// <summary>
      /// The period to which the document should be posted. By default, it is the current period,
      /// but you can change the period.
      /// </summary>
      [DataMember(Name="PostPeriod", EmitDefaultValue=false)]
      public StringValue PostPeriod { get; set; }

      /// <summary>
      /// The project or the customer contract with which this document is associated,
      /// or the code indicating that this document is not associated with any project.
      /// </summary>
      [DataMember(Name="Project", EmitDefaultValue=false)]
      public StringValue Project { get; set; }

      /// <summary>
      /// The reference number of the AR document in the system; for a new document, the <NEW> string is displayed,
      /// indicating that a new number will be generated. 
      /// </summary>
      [DataMember(Name="ReferenceNbr", EmitDefaultValue=false)]
      public StringValue ReferenceNbr { get; set; }
      
      /// <summary>
      /// The status of the document, which is assigned by the system and can be one of the following:
      /// On Hold, Pending Print, Pending Email, Credit Hold, Balanced, Scheduled, Voided, Pending Approval,
      /// Rejected, Open, Reserved, Closed.
      /// </summary>
      [DataMember(Name="Status", EmitDefaultValue=false)]
      public StringValue Status { get; set; }

      /// <summary>
      /// This is copied from the settings of the customer location specified for the invoice.
      /// </summary>
      [DataMember(Name="ShipToContact", EmitDefaultValue=false)]
      public DocContact ShipToContact { get; set; }

      /// <summary>
      /// If selected, indicates that the ship-to address is not the default shipping address of the customer.
      /// </summary>
      [DataMember(Name="ShipToContactOverride", EmitDefaultValue=false)]
      public BooleanValue ShipToContactOverride { get; set; }

      /// <summary>
      /// Taxes to be applied to the document.
      /// </summary>
      [DataMember(Name="TaxDetails", EmitDefaultValue=false)]
      public List<InvoiceTaxDetail> TaxDetails { get; set; }

      /// <summary>
      /// The tax amount of the document, as defined by the TaxDetails.
      /// </summary>
      [DataMember(Name="TaxTotal", EmitDefaultValue=false)]
      public DecimalValue TaxTotal { get; set; }

      /// <summary>
      /// The credit terms used in relations with the customer.
      /// </summary>
      [DataMember(Name="Terms", EmitDefaultValue=false)]
      public StringValue Terms { get; set; }

      /// <summary>
      /// The document type.
      /// The following types are available: Invoice, Debit Memo, Credit Memo, Overdue Charge, Credit WO
      /// </summary>
      [DataMember(Name="Type", EmitDefaultValue=false)]
      public StringValue Type { get; set; }

   }
}