using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace Systems
{
	public class SettingsThemeContentSetter : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CContentSetRoutine_003Ed__12 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public SettingsThemeContentSetter _003C_003E4__this;

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
			public _003CContentSetRoutine_003Ed__12(int _003C_003E1__state)
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
		private RectTransform retryButtonRect;

		[SerializeField]
		private RectTransform giveUpButtonRect;

		[SerializeField]
		private RectTransform homeButtonRect;

		[SerializeField]
		private GridLayoutGroup gridLayoutGroup;

		[SerializeField]
		private RectTransform gridLayoutRect;

		[SerializeField]
		private LayoutElement gridLayoutElement;

		[SerializeField]
		private VerticalLayoutGroup verticalLayoutGroup;

		private bool isContentActive;

		private Coroutine coroutine;

		private float spacing;

		internal void SetContentActiveness(bool isActive)
		{
		}

		private void OnEnable()
		{
		}

		[IteratorStateMachine(typeof(_003CContentSetRoutine_003Ed__12))]
		private IEnumerator ContentSetRoutine()
		{
			return null;
		}
	}
}
