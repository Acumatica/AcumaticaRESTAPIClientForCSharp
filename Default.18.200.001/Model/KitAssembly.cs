/* 
 * Default/18.200.001
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * OpenAPI spec version: 3
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using Acumatica.RESTClient.Model;

namespace Acumatica.Default_18_200_001.Model
{
    /// <summary>
    /// KitAssembly
    /// </summary>
    [DataContract]
    public partial class KitAssembly : Entity,  IEquatable<KitAssembly>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="KitAssembly" /> class.
        /// </summary>
        /// <param name="allocations">allocations.</param>
        /// <param name="date">date.</param>
        /// <param name="description">description.</param>
        /// <param name="hold">hold.</param>
        /// <param name="kitInventoryID">kitInventoryID.</param>
        /// <param name="locationID">locationID.</param>
        /// <param name="nonStockComponents">nonStockComponents.</param>
        /// <param name="postPeriod">postPeriod.</param>
        /// <param name="qty">qty.</param>
        /// <param name="reasonCode">reasonCode.</param>
        /// <param name="referenceNbr">referenceNbr.</param>
        /// <param name="revision">revision.</param>
        /// <param name="status">status.</param>
        /// <param name="stockComponents">stockComponents.</param>
        /// <param name="subitem">subitem.</param>
        /// <param name="type">type.</param>
        /// <param name="uOM">uOM.</param>
        /// <param name="warehouseID">warehouseID.</param>
        public KitAssembly(IEnumerable<KitAssemblyAllocation> allocations = default(IEnumerable<KitAssemblyAllocation>), DateTimeValue date = default(DateTimeValue), StringValue description = default(StringValue), BooleanValue hold = default(BooleanValue), StringValue kitInventoryID = default(StringValue), StringValue locationID = default(StringValue), IEnumerable<KitAssemblyNonStockComponent> nonStockComponents = default(IEnumerable<KitAssemblyNonStockComponent>), StringValue postPeriod = default(StringValue), DecimalValue qty = default(DecimalValue), StringValue reasonCode = default(StringValue), StringValue referenceNbr = default(StringValue), StringValue revision = default(StringValue), StringValue status = default(StringValue), IEnumerable<KitAssemblyStockComponent> stockComponents = default(IEnumerable<KitAssemblyStockComponent>), StringValue subitem = default(StringValue), StringValue type = default(StringValue), StringValue uOM = default(StringValue), StringValue warehouseID = default(StringValue), Guid? id = default(Guid?), long? rowNumber = default(long?), string note = default(string), Dictionary<string, Dictionary<string, CustomField>> custom = default(Dictionary<string, Dictionary<string, CustomField>>), List<FileLink> files = default(List<FileLink>)) : base(id, rowNumber, note, custom, files)
        {
            this.Allocations = allocations;
            this.Date = date;
            this.Description = description;
            this.Hold = hold;
            this.KitInventoryID = kitInventoryID;
            this.LocationID = locationID;
            this.NonStockComponents = nonStockComponents;
            this.PostPeriod = postPeriod;
            this.Qty = qty;
            this.ReasonCode = reasonCode;
            this.ReferenceNbr = referenceNbr;
            this.Revision = revision;
            this.Status = status;
            this.StockComponents = stockComponents;
            this.Subitem = subitem;
            this.Type = type;
            this.UOM = uOM;
            this.WarehouseID = warehouseID;
        }
        
        /// <summary>
        /// Gets or Sets Allocations
        /// </summary>
        [DataMember(Name="Allocations", EmitDefaultValue=false)]
        public IEnumerable<KitAssemblyAllocation> Allocations { get; set; }

        /// <summary>
        /// Gets or Sets Date
        /// </summary>
        [DataMember(Name="Date", EmitDefaultValue=false)]
        public DateTimeValue Date { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="Description", EmitDefaultValue=false)]
        public StringValue Description { get; set; }

        /// <summary>
        /// Gets or Sets Hold
        /// </summary>
        [DataMember(Name="Hold", EmitDefaultValue=false)]
        public BooleanValue Hold { get; set; }

        /// <summary>
        /// Gets or Sets KitInventoryID
        /// </summary>
        [DataMember(Name="KitInventoryID", EmitDefaultValue=false)]
        public StringValue KitInventoryID { get; set; }

        /// <summary>
        /// Gets or Sets LocationID
        /// </summary>
        [DataMember(Name="LocationID", EmitDefaultValue=false)]
        public StringValue LocationID { get; set; }

        /// <summary>
        /// Gets or Sets NonStockComponents
        /// </summary>
        [DataMember(Name="NonStockComponents", EmitDefaultValue=false)]
        public IEnumerable<KitAssemblyNonStockComponent> NonStockComponents { get; set; }

        /// <summary>
        /// Gets or Sets PostPeriod
        /// </summary>
        [DataMember(Name="PostPeriod", EmitDefaultValue=false)]
        public StringValue PostPeriod { get; set; }

        /// <summary>
        /// Gets or Sets Qty
        /// </summary>
        [DataMember(Name="Qty", EmitDefaultValue=false)]
        public DecimalValue Qty { get; set; }

        /// <summary>
        /// Gets or Sets ReasonCode
        /// </summary>
        [DataMember(Name="ReasonCode", EmitDefaultValue=false)]
        public StringValue ReasonCode { get; set; }

        /// <summary>
        /// Gets or Sets ReferenceNbr
        /// </summary>
        [DataMember(Name="ReferenceNbr", EmitDefaultValue=false)]
        public StringValue ReferenceNbr { get; set; }

        /// <summary>
        /// Gets or Sets Revision
        /// </summary>
        [DataMember(Name="Revision", EmitDefaultValue=false)]
        public StringValue Revision { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="Status", EmitDefaultValue=false)]
        public StringValue Status { get; set; }

        /// <summary>
        /// Gets or Sets StockComponents
        /// </summary>
        [DataMember(Name="StockComponents", EmitDefaultValue=false)]
        public IEnumerable<KitAssemblyStockComponent> StockComponents { get; set; }

        /// <summary>
        /// Gets or Sets Subitem
        /// </summary>
        [DataMember(Name="Subitem", EmitDefaultValue=false)]
        public StringValue Subitem { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="Type", EmitDefaultValue=false)]
        public StringValue Type { get; set; }

        /// <summary>
        /// Gets or Sets UOM
        /// </summary>
        [DataMember(Name="UOM", EmitDefaultValue=false)]
        public StringValue UOM { get; set; }

        /// <summary>
        /// Gets or Sets WarehouseID
        /// </summary>
        [DataMember(Name="WarehouseID", EmitDefaultValue=false)]
        public StringValue WarehouseID { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class KitAssembly {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  Allocations: ").Append(Allocations).Append("\n");
            sb.Append("  Date: ").Append(Date).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Hold: ").Append(Hold).Append("\n");
            sb.Append("  KitInventoryID: ").Append(KitInventoryID).Append("\n");
            sb.Append("  LocationID: ").Append(LocationID).Append("\n");
            sb.Append("  NonStockComponents: ").Append(NonStockComponents).Append("\n");
            sb.Append("  PostPeriod: ").Append(PostPeriod).Append("\n");
            sb.Append("  Qty: ").Append(Qty).Append("\n");
            sb.Append("  ReasonCode: ").Append(ReasonCode).Append("\n");
            sb.Append("  ReferenceNbr: ").Append(ReferenceNbr).Append("\n");
            sb.Append("  Revision: ").Append(Revision).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  StockComponents: ").Append(StockComponents).Append("\n");
            sb.Append("  Subitem: ").Append(Subitem).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  UOM: ").Append(UOM).Append("\n");
            sb.Append("  WarehouseID: ").Append(WarehouseID).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public override string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as KitAssembly);
        }

        /// <summary>
        /// Returns true if KitAssembly instances are equal
        /// </summary>
        /// <param name="input">Instance of KitAssembly to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(KitAssembly input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.Allocations == input.Allocations ||
                    this.Allocations != null &&
                    this.Allocations.SequenceEqual(input.Allocations)
                ) && base.Equals(input) && 
                (
                    this.Date == input.Date ||
                    (this.Date != null &&
                    this.Date.Equals(input.Date))
                ) && base.Equals(input) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && base.Equals(input) && 
                (
                    this.Hold == input.Hold ||
                    (this.Hold != null &&
                    this.Hold.Equals(input.Hold))
                ) && base.Equals(input) && 
                (
                    this.KitInventoryID == input.KitInventoryID ||
                    (this.KitInventoryID != null &&
                    this.KitInventoryID.Equals(input.KitInventoryID))
                ) && base.Equals(input) && 
                (
                    this.LocationID == input.LocationID ||
                    (this.LocationID != null &&
                    this.LocationID.Equals(input.LocationID))
                ) && base.Equals(input) && 
                (
                    this.NonStockComponents == input.NonStockComponents ||
                    this.NonStockComponents != null &&
                    this.NonStockComponents.SequenceEqual(input.NonStockComponents)
                ) && base.Equals(input) && 
                (
                    this.PostPeriod == input.PostPeriod ||
                    (this.PostPeriod != null &&
                    this.PostPeriod.Equals(input.PostPeriod))
                ) && base.Equals(input) && 
                (
                    this.Qty == input.Qty ||
                    (this.Qty != null &&
                    this.Qty.Equals(input.Qty))
                ) && base.Equals(input) && 
                (
                    this.ReasonCode == input.ReasonCode ||
                    (this.ReasonCode != null &&
                    this.ReasonCode.Equals(input.ReasonCode))
                ) && base.Equals(input) && 
                (
                    this.ReferenceNbr == input.ReferenceNbr ||
                    (this.ReferenceNbr != null &&
                    this.ReferenceNbr.Equals(input.ReferenceNbr))
                ) && base.Equals(input) && 
                (
                    this.Revision == input.Revision ||
                    (this.Revision != null &&
                    this.Revision.Equals(input.Revision))
                ) && base.Equals(input) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && base.Equals(input) && 
                (
                    this.StockComponents == input.StockComponents ||
                    this.StockComponents != null &&
                    this.StockComponents.SequenceEqual(input.StockComponents)
                ) && base.Equals(input) && 
                (
                    this.Subitem == input.Subitem ||
                    (this.Subitem != null &&
                    this.Subitem.Equals(input.Subitem))
                ) && base.Equals(input) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && base.Equals(input) && 
                (
                    this.UOM == input.UOM ||
                    (this.UOM != null &&
                    this.UOM.Equals(input.UOM))
                ) && base.Equals(input) && 
                (
                    this.WarehouseID == input.WarehouseID ||
                    (this.WarehouseID != null &&
                    this.WarehouseID.Equals(input.WarehouseID))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = base.GetHashCode();
                if (this.Allocations != null)
                    hashCode = hashCode * 59 + this.Allocations.GetHashCode();
                if (this.Date != null)
                    hashCode = hashCode * 59 + this.Date.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Hold != null)
                    hashCode = hashCode * 59 + this.Hold.GetHashCode();
                if (this.KitInventoryID != null)
                    hashCode = hashCode * 59 + this.KitInventoryID.GetHashCode();
                if (this.LocationID != null)
                    hashCode = hashCode * 59 + this.LocationID.GetHashCode();
                if (this.NonStockComponents != null)
                    hashCode = hashCode * 59 + this.NonStockComponents.GetHashCode();
                if (this.PostPeriod != null)
                    hashCode = hashCode * 59 + this.PostPeriod.GetHashCode();
                if (this.Qty != null)
                    hashCode = hashCode * 59 + this.Qty.GetHashCode();
                if (this.ReasonCode != null)
                    hashCode = hashCode * 59 + this.ReasonCode.GetHashCode();
                if (this.ReferenceNbr != null)
                    hashCode = hashCode * 59 + this.ReferenceNbr.GetHashCode();
                if (this.Revision != null)
                    hashCode = hashCode * 59 + this.Revision.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.StockComponents != null)
                    hashCode = hashCode * 59 + this.StockComponents.GetHashCode();
                if (this.Subitem != null)
                    hashCode = hashCode * 59 + this.Subitem.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.UOM != null)
                    hashCode = hashCode * 59 + this.UOM.GetHashCode();
                if (this.WarehouseID != null)
                    hashCode = hashCode * 59 + this.WarehouseID.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            foreach(var x in base.BaseValidate(validationContext)) yield return x;
            yield break;
        }
    }

}
