using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Proyecto26;

namespace Crescive.Services
{
	public static class WebClientService
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CDeleteAsync_003Ed__27 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<ResponseHelper> _003C_003Et__builder;

			public string url;

			public string body;

			public CancellationToken ct;

			public int timeout;

			public Dictionary<string, string> param;

			public Dictionary<string, string> headers;

			private UniTask<ResponseHelper>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CDeleteAsync_003Ed__28<T> : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<T> _003C_003Et__builder;

			public string url;

			public string body;

			public CancellationToken ct;

			public int timeout;

			public Dictionary<string, string> param;

			public Dictionary<string, string> headers;

			private UniTask<T>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CGetAsync_003Ed__19 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<ResponseHelper> _003C_003Et__builder;

			public string url;

			public string body;

			public CancellationToken ct;

			public int timeout;

			public Dictionary<string, string> param;

			public Dictionary<string, string> headers;

			private UniTask<ResponseHelper>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CGetAsync_003Ed__20<T> : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<T> _003C_003Et__builder;

			public string url;

			public string body;

			public CancellationToken ct;

			public int timeout;

			public Dictionary<string, string> param;

			public Dictionary<string, string> headers;

			private UniTask<T>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CPatchAsync_003Ed__25 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<ResponseHelper> _003C_003Et__builder;

			public string url;

			public string body;

			public CancellationToken ct;

			public int timeout;

			public Dictionary<string, string> param;

			public Dictionary<string, string> headers;

			private UniTask<ResponseHelper>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CPatchAsync_003Ed__26<T> : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<T> _003C_003Et__builder;

			public string url;

			public string body;

			public CancellationToken ct;

			public int timeout;

			public Dictionary<string, string> param;

			public Dictionary<string, string> headers;

			private UniTask<T>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CPostAsync_003Ed__21 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<ResponseHelper> _003C_003Et__builder;

			public string url;

			public string body;

			public CancellationToken ct;

			public int timeout;

			public Dictionary<string, string> param;

			public Dictionary<string, string> headers;

			private UniTask<ResponseHelper>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CPostAsync_003Ed__22<T> : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<T> _003C_003Et__builder;

			public string url;

			public string body;

			public CancellationToken ct;

			public int timeout;

			public Dictionary<string, string> param;

			public Dictionary<string, string> headers;

			private UniTask<T>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CPutAsync_003Ed__23 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<ResponseHelper> _003C_003Et__builder;

			public string url;

			public string body;

			public CancellationToken ct;

			public int timeout;

			public Dictionary<string, string> param;

			public Dictionary<string, string> headers;

			private UniTask<ResponseHelper>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CPutAsync_003Ed__24<T> : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<T> _003C_003Et__builder;

			public string url;

			public string body;

			public CancellationToken ct;

			public int timeout;

			public Dictionary<string, string> param;

			public Dictionary<string, string> headers;

			private UniTask<T>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CRequestAsync_003Ed__15 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<ResponseHelper> _003C_003Et__builder;

			public RequestHelper request;

			public CancellationToken ct;

			private UniTask<ResponseHelper>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CRequestAsync_003Ed__16<T> : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<T> _003C_003Et__builder;

			public RequestHelper request;

			public CancellationToken ct;

			private UniTask<T>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CRequestAsync_003Ed__17 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<ResponseHelper> _003C_003Et__builder;

			public RequestType requestType;

			public string url;

			public string body;

			public CancellationToken ct;

			public int timeout;

			public Dictionary<string, string> param;

			public Dictionary<string, string> headers;

			private UniTask<ResponseHelper>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CRequestAsync_003Ed__18<T> : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<T> _003C_003Et__builder;

			public RequestType requestType;

			public string url;

			public string body;

			public CancellationToken ct;

			public int timeout;

			public Dictionary<string, string> param;

			public Dictionary<string, string> headers;

			private UniTask<T>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		public static IObservable<ResponseHelper> RequestAsObservable(RequestHelper request, CancellationToken ct)
		{
			return null;
		}

		public static IObservable<T> RequestAsObservable<T>(RequestHelper request, CancellationToken ct)
		{
			return null;
		}

		public static IObservable<ResponseHelper> RequestAsObservable(RequestType requestType, string url, string body = "", CancellationToken ct = default(CancellationToken), int timeout = 10, Dictionary<string, string> param = null, Dictionary<string, string> headers = null)
		{
			return null;
		}

		public static IObservable<T> RequestAsObservable<T>(RequestType requestType, string url, string body = "", CancellationToken ct = default(CancellationToken), int timeout = 10, Dictionary<string, string> param = null, Dictionary<string, string> headers = null)
		{
			return null;
		}

		public static IObservable<ResponseHelper> GetAsObservable(string url, string body = "", CancellationToken ct = default(CancellationToken), int timeout = 10, Dictionary<string, string> param = null, Dictionary<string, string> headers = null)
		{
			return null;
		}

		public static IObservable<T> GetAsObservable<T>(string url, string body = "", CancellationToken ct = default(CancellationToken), int timeout = 10, Dictionary<string, string> param = null, Dictionary<string, string> headers = null)
		{
			return null;
		}

		public static IObservable<ResponseHelper> PostAsObservable(string url, string body = "", CancellationToken ct = default(CancellationToken), int timeout = 10, Dictionary<string, string> param = null, Dictionary<string, string> headers = null)
		{
			return null;
		}

		public static IObservable<T> PostAsObservable<T>(string url, string body = "", CancellationToken ct = default(CancellationToken), int timeout = 10, Dictionary<string, string> param = null, Dictionary<string, string> headers = null)
		{
			return null;
		}

		public static IObservable<ResponseHelper> PutAsObservable(string url, string body = "", CancellationToken ct = default(CancellationToken), int timeout = 10, Dictionary<string, string> param = null, Dictionary<string, string> headers = null)
		{
			return null;
		}

		public static IObservable<T> PutAsObservable<T>(string url, string body = "", CancellationToken ct = default(CancellationToken), int timeout = 10, Dictionary<string, string> param = null, Dictionary<string, string> headers = null)
		{
			return null;
		}

		public static IObservable<ResponseHelper> PatchAsObservable(string url, string body = "", CancellationToken ct = default(CancellationToken), int timeout = 10, Dictionary<string, string> param = null, Dictionary<string, string> headers = null)
		{
			return null;
		}

		public static IObservable<T> PatchAsObservable<T>(string url, string body = "", CancellationToken ct = default(CancellationToken), int timeout = 10, Dictionary<string, string> param = null, Dictionary<string, string> headers = null)
		{
			return null;
		}

		public static IObservable<ResponseHelper> DeleteAsObservable(string url, string body = "", CancellationToken ct = default(CancellationToken), int timeout = 10, Dictionary<string, string> param = null, Dictionary<string, string> headers = null)
		{
			return null;
		}

		public static IObservable<T> DeleteAsObservable<T>(string url, string body = "", CancellationToken ct = default(CancellationToken), int timeout = 10, Dictionary<string, string> param = null, Dictionary<string, string> headers = null)
		{
			return null;
		}

		public static IObservable<IList<T>> GetAllAsObservable<T>(string url, List<string> bodies, CancellationToken ct = default(CancellationToken), int timeout = 10, Dictionary<string, string> param = null, Dictionary<string, string> headers = null)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CRequestAsync_003Ed__15))]
		public static UniTask<ResponseHelper> RequestAsync(RequestHelper request, CancellationToken ct)
		{
			return default(UniTask<ResponseHelper>);
		}

		[AsyncStateMachine(typeof(_003CRequestAsync_003Ed__16<>))]
		public static UniTask<T> RequestAsync<T>(RequestHelper request, CancellationToken ct)
		{
			return default(UniTask<T>);
		}

		[AsyncStateMachine(typeof(_003CRequestAsync_003Ed__17))]
		public static UniTask<ResponseHelper> RequestAsync(RequestType requestType, string url, string body = "", CancellationToken ct = default(CancellationToken), int timeout = 10, Dictionary<string, string> param = null, Dictionary<string, string> headers = null)
		{
			return default(UniTask<ResponseHelper>);
		}

		[AsyncStateMachine(typeof(_003CRequestAsync_003Ed__18<>))]
		public static UniTask<T> RequestAsync<T>(RequestType requestType, string url, string body = "", CancellationToken ct = default(CancellationToken), int timeout = 10, Dictionary<string, string> param = null, Dictionary<string, string> headers = null)
		{
			return default(UniTask<T>);
		}

		[AsyncStateMachine(typeof(_003CGetAsync_003Ed__19))]
		public static UniTask<ResponseHelper> GetAsync(string url, string body = "", CancellationToken ct = default(CancellationToken), int timeout = 10, Dictionary<string, string> param = null, Dictionary<string, string> headers = null)
		{
			return default(UniTask<ResponseHelper>);
		}

		[AsyncStateMachine(typeof(_003CGetAsync_003Ed__20<>))]
		public static UniTask<T> GetAsync<T>(string url, string body = "", CancellationToken ct = default(CancellationToken), int timeout = 10, Dictionary<string, string> param = null, Dictionary<string, string> headers = null)
		{
			return default(UniTask<T>);
		}

		[AsyncStateMachine(typeof(_003CPostAsync_003Ed__21))]
		public static UniTask<ResponseHelper> PostAsync(string url, string body = "", CancellationToken ct = default(CancellationToken), int timeout = 10, Dictionary<string, string> param = null, Dictionary<string, string> headers = null)
		{
			return default(UniTask<ResponseHelper>);
		}

		[AsyncStateMachine(typeof(_003CPostAsync_003Ed__22<>))]
		public static UniTask<T> PostAsync<T>(string url, string body = "", CancellationToken ct = default(CancellationToken), int timeout = 10, Dictionary<string, string> param = null, Dictionary<string, string> headers = null)
		{
			return default(UniTask<T>);
		}

		[AsyncStateMachine(typeof(_003CPutAsync_003Ed__23))]
		public static UniTask<ResponseHelper> PutAsync(string url, string body = "", CancellationToken ct = default(CancellationToken), int timeout = 10, Dictionary<string, string> param = null, Dictionary<string, string> headers = null)
		{
			return default(UniTask<ResponseHelper>);
		}

		[AsyncStateMachine(typeof(_003CPutAsync_003Ed__24<>))]
		public static UniTask<T> PutAsync<T>(string url, string body = "", CancellationToken ct = default(CancellationToken), int timeout = 10, Dictionary<string, string> param = null, Dictionary<string, string> headers = null)
		{
			return default(UniTask<T>);
		}

		[AsyncStateMachine(typeof(_003CPatchAsync_003Ed__25))]
		public static UniTask<ResponseHelper> PatchAsync(string url, string body = "", CancellationToken ct = default(CancellationToken), int timeout = 10, Dictionary<string, string> param = null, Dictionary<string, string> headers = null)
		{
			return default(UniTask<ResponseHelper>);
		}

		[AsyncStateMachine(typeof(_003CPatchAsync_003Ed__26<>))]
		public static UniTask<T> PatchAsync<T>(string url, string body = "", CancellationToken ct = default(CancellationToken), int timeout = 10, Dictionary<string, string> param = null, Dictionary<string, string> headers = null)
		{
			return default(UniTask<T>);
		}

		[AsyncStateMachine(typeof(_003CDeleteAsync_003Ed__27))]
		public static UniTask<ResponseHelper> DeleteAsync(string url, string body = "", CancellationToken ct = default(CancellationToken), int timeout = 10, Dictionary<string, string> param = null, Dictionary<string, string> headers = null)
		{
			return default(UniTask<ResponseHelper>);
		}

		[AsyncStateMachine(typeof(_003CDeleteAsync_003Ed__28<>))]
		public static UniTask<T> DeleteAsync<T>(string url, string body = "", CancellationToken ct = default(CancellationToken), int timeout = 10, Dictionary<string, string> param = null, Dictionary<string, string> headers = null)
		{
			return default(UniTask<T>);
		}

		private static IDisposable CreateDisposable(CancellationToken ct)
		{
			return null;
		}

		private static RequestHelper CreateRequestHelper(RequestType requestType, string url, string body = "", int timeout = 10, Dictionary<string, string> param = null, Dictionary<string, string> headers = null)
		{
			return null;
		}

		private static IObservable<T> ConvertGenericObservable<T>(IObservable<ResponseHelper> observable)
		{
			return null;
		}
	}
}
