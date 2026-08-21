using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Crescive.CreatorMode;
using UnityEngine;

namespace Crescive.Levels
{
	public class LevelsScreenshooter : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CSaveLevelImageCoroutine_003Ed__5 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public LevelsScreenshooter _003C_003E4__this;

			public LevelCreatorData data;

			object IEnumerator<object>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CSaveLevelImageCoroutine_003Ed__5(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[CompilerGenerated]
		private sealed class _003CTakeScreenshotsCoroutine_003Ed__4 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public LevelsScreenshooter _003C_003E4__this;

			private List<LevelCreatorData>.Enumerator _003C_003E7__wrap1;

			object IEnumerator<object>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CTakeScreenshotsCoroutine_003Ed__4(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			private void _003C_003Em__Finally1()
			{
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[SerializeField]
		private List<LevelCreatorData> levels;

		[SerializeField]
		private LevelCreatorChannel levelCreatorChannel;

		[Range(0f, 1f)]
		[SerializeField]
		private float screenshotResolutionScale;

		public void TakeScreenshots()
		{
		}

		[IteratorStateMachine(typeof(_003CTakeScreenshotsCoroutine_003Ed__4))]
		private IEnumerator TakeScreenshotsCoroutine()
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CSaveLevelImageCoroutine_003Ed__5))]
		private IEnumerator SaveLevelImageCoroutine(LevelCreatorData data)
		{
			return null;
		}
	}
}
