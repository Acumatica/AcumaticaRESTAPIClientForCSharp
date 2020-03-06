
using Acumatica.RESTClient.Api;
using Acumatica.RESTClient.Model;
using SOAPLikeWrapperForREST;
using System;

namespace AcumaticaSOAPWrapperForREST
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
	public class DefaultSoapClient : RESTClient
	{
		public DefaultSoapClient(string siteURL) : base(siteURL)
		{ }
		public ProcessResult WaitInvoke<T>(EntityAction<T> action)
			where T : Entity
		{
			InvokeResult invokeResult = Invoke(action);

			while (true)
			{
				ProcessResult processResult = GetProcessStatus(invokeResult);

				System.Threading.Thread.Sleep(100);

				switch (processResult.Status)
				{
					case ProcessStatus.NotExists:
					case ProcessStatus.Aborted:
						throw new SystemException("Process status: " +
												  processResult.Status + "; Error: " +
												  processResult.Message);
					case ProcessStatus.Completed:
						return processResult;
					case ProcessStatus.InProcess:
						if (processResult.Seconds > 30)
							throw new TimeoutException();
						continue;
					default:
						throw new InvalidOperationException();
				}
			}
		}
	}
}