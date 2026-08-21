using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Crescive.Navigation;
using Crescive.UI;
using UnityEngine;
using UnityEngine.UI;

namespace Crescive.LiveEvents.DynamicQuest
{
	public class DynamicQuestGoldenPassIntroOverlayPopupController : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CHideRoutine_003Ed__9 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public DynamicQuestGoldenPassIntroOverlayPopupController _003C_003E4__this;

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
			public _003CHideRoutine_003Ed__9(int _003C_003E1__state)
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
		private sealed class _003CShowRoutine_003Ed__8 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public DynamicQuestGoldenPassIntroOverlayPopupController _003C_003E4__this;

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
			public _003CShowRoutine_003Ed__8(int _003C_003E1__state)
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
		private Navigatable navigatable;

		[SerializeField]
		private DynamicQuestSystem dynamicQuestSystem;

		[SerializeField]
		private DynamicQuestProgressPopupChannel progressPopupChannel;

		[SerializeField]
		private Popover infoPopover;

		[SerializeField]
		private float popoverShowDelay;

		[SerializeField]
		private float regularItemsAlpha;

		private bool isShowing;

		private Dictionary<Graphic, Color> originalGraphicsColors;

		[IteratorStateMachine(typeof(_003CShowRoutine_003Ed__8))]
		private IEnumerator ShowRoutine()
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CHideRoutine_003Ed__9))]
		private IEnumerator HideRoutine()
		{
			return null;
		}

		private void SetVisuals(bool introActive)
		{
		}

		public void OnShow()
		{
		}

		public void OnTapped()
		{
		}
	}
}
