using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Obi;
using UnityEngine;

namespace Crescive.TwistedTangle
{
	public class RopeWidthScaler : MonoBehaviour
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CUpdateScaleAsync_003Ed__16 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public RopeWidthScaler _003C_003E4__this;

			public float scale;

			private UniTask<bool>.Awaiter _003C_003Eu__1;

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
		private RopePhysicToggler physicToggler;

		[SerializeField]
		private ObiRopeExtrudedRenderer ropeExtrudedRenderer;

		[SerializeField]
		private ObiRopeChainRenderer ropeChainRenderer;

		[SerializeField]
		private ObiRope rope;

		[SerializeField]
		private float multiplier;

		private float initialRopeWidth;

		private UniTask updateScaleTask;

		public float Scale { get; private set; }

		public bool IsNotDefaultScale => false;

		private void Awake()
		{
		}

		private void Start()
		{
		}

		private void Setup()
		{
		}

		[AsyncStateMachine(typeof(_003CUpdateScaleAsync_003Ed__16))]
		private void UpdateScaleAsync(float scale)
		{
		}

		private void UpdateScaleImmediate(float scale)
		{
		}

		private void UpdateScaleImmediate()
		{
		}

		public void UpdateScale(float scale, bool immediate = false)
		{
		}

		public void ResetScale()
		{
		}

		public void SetMultiplier(float value)
		{
		}

		public void SetMultiplierAndUpdateImmediate(float value)
		{
		}
	}
}
