using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CresciveCore;
using Google.Play.Common;
using Google.Play.Review;
using PersistentSO;
using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace Crescive.StoreReview
{
	public class StoreReviewRequester : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CAndroidStoreRequestEnumerator_003Ed__6 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			private ReviewManager _003CreviewManager_003E5__2;

			private PlayAsyncOperation<PlayReviewInfo, ReviewErrorCode> _003CrequestFlowOperation_003E5__3;

			private PlayAsyncOperation<VoidResult, ReviewErrorCode> _003ClaunchFlowOperation_003E5__4;

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
			public _003CAndroidStoreRequestEnumerator_003Ed__6(int _003C_003E1__state)
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
		private LevelSystem levelSystem;

		[SerializeField]
		private IntVariable diplayLevel;

		[SerializeField]
		private PersistentBoolVariable hasDisplayed;

		public void RequestStoreReview()
		{
		}

		private void RequestiOSReview()
		{
		}

		private void RequestAndroidReview()
		{
		}

		[IteratorStateMachine(typeof(_003CAndroidStoreRequestEnumerator_003Ed__6))]
		private IEnumerator AndroidStoreRequestEnumerator()
		{
			return null;
		}
	}
}
