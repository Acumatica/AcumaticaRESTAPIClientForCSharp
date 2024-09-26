using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_24_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen TX205500 in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class TaxCategory : Entity, ITopLevelEntity
	{

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: Active 
		/// DAC: PX.Objects.TX.TaxCategory 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Active", EmitDefaultValue=false)]
		public BooleanValue? Active { get; set; }

		[DataMember(Name="CreatedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? CreatedDateTime { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: Descr 
		/// DAC: PX.Objects.TX.TaxCategory 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		[DataMember(Name="Details", EmitDefaultValue=false)]
		public List<TaxCategoryTaxDetail>? Details { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: TaxCatFlag 
		/// DAC: PX.Objects.TX.TaxCategory 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ExcludeListedTaxes", EmitDefaultValue=false)]
		public BooleanValue? ExcludeListedTaxes { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? LastModifiedDateTime { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: TaxCategoryID 
		/// DAC: PX.Objects.TX.TaxCategory 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="TaxCategoryID", EmitDefaultValue=false)]
		public StringValue? TaxCategoryID { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/Default/24.200.001";
		}
	}
}