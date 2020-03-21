
using Acumatica.RESTClient.Api;
using Acumatica.RESTClient.Model;
using SOAPLikeWrapperForREST;
using System;
using System.Collections.Generic;

namespace SOAPLikeWrapperForREST
{
	public enum ProcessStatus
	{

		/// <remarks/>
		NotExists = 404,

		/// <remarks/>
		InProcess = 202,

		/// <remarks/>
		Completed = 204,

		/// <remarks/>
		Aborted,
	}
	public partial class ProcessResult
	{
		public ProcessStatus Status
		{
			get;
			set;
		}
		public int Seconds
		{
			get;
			set;
		}
		public string Message
		{
			get;
			set;
		}
	}
	public class InvokeResult
	{
		public static implicit operator string(InvokeResult d) => d.Result;
		public static implicit operator InvokeResult(string d) => new InvokeResult() { Result = d };
		public string Result { get; set; }

	}
}