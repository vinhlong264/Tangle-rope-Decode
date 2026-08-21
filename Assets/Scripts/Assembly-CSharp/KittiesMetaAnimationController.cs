using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnityEngine;

public class KittiesMetaAnimationController : MonoBehaviour
{
	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003CAnimateKitties_003Ed__6 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

		public KittiesMetaAnimationController _003C_003E4__this;

		private float[] _003CstaticRatios_003E5__2;

		private int _003Ci_003E5__3;

		private UniTask.Awaiter _003C_003Eu__1;

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
	private KittyController kitty;

	[SerializeField]
	private Transform catParent;

	private List<KittyController> _kitties;

	private void OnEnable()
	{
	}

	private void SpawnKitties(int cout = 1)
	{
	}

	private void OnDisable()
	{
	}

	[AsyncStateMachine(typeof(_003CAnimateKitties_003Ed__6))]
	private UniTaskVoid AnimateKitties()
	{
		return default(UniTaskVoid);
	}

	private void ResetKitties()
	{
	}
}
