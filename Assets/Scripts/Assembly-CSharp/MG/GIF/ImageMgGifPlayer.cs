using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using Cysharp.Threading.Tasks;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Networking;
using UnityEngine.UI;

namespace MG.GIF
{
	public class ImageMgGifPlayer : MonoBehaviour
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CInitializeAsync_003Ed__11 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public ImageMgGifPlayer _003C_003E4__this;

			private CancellationToken _003CcancellationToken_003E5__2;

			private byte[] _003Cbytes_003E5__3;

			private UnityWebRequest _003Crequest_003E5__4;

			private UnityAsyncExtensions.UnityWebRequestAsyncOperationAwaiter _003C_003Eu__1;

			private UniTask.Awaiter _003C_003Eu__2;

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

		[SerializeField]
		private RawImage rawImage;

		[SerializeField]
		private string fileName;

		[SerializeField]
		[Space]
		private float startDelay;

		[Space]
		public UnityEvent OnStartInitializing;

		public UnityEvent OnFinishInitializing;

		private List<Texture2D> frames;

		private List<float> frameDelay;

		private bool didInitialize;

		private int currentFrame;

		private float time;

		private void Update()
		{
		}

		[AsyncStateMachine(typeof(_003CInitializeAsync_003Ed__11))]
		private void InitializeAsync()
		{
		}

		public void Initialize(string file)
		{
		}
	}
}
