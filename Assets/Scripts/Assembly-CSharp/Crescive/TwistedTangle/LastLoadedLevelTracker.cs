using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Crescive.CreatorMode;
using UnityEngine;

namespace Crescive.TwistedTangle
{
	public class LastLoadedLevelTracker : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CSetLastLoadedLevelDelayed_003Ed__4 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public LastLoadedLevelTracker _003C_003E4__this;

			public LevelCreatorSaveData data;

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
			public _003CSetLastLoadedLevelDelayed_003Ed__4(int _003C_003E1__state)
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

		[SerializeField]
		private LastLoadedLevelTrackData lastLoadedLevelTrackData;

		[SerializeField]
		private PinsChannel pinsChannel;

		public void OnLevelLoaded(LevelCreatorSaveData data)
		{
		}

		public void OnLevelLoaded(string json)
		{
		}

		[IteratorStateMachine(typeof(_003CSetLastLoadedLevelDelayed_003Ed__4))]
		private IEnumerator SetLastLoadedLevelDelayed(LevelCreatorSaveData data)
		{
			return null;
		}
	}
}
