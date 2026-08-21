using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Crescive.Navigation;
using Crescive.Sequencer;
using UnityEngine;
using UnityEngine.UI;

namespace DynamicQuestTime
{
	public class DynamicQuestTimeHomeButton : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CDoActionNextFrame_003Ed__11 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public DynamicQuestTimeHomeButton _003C_003E4__this;

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
			public _003CDoActionNextFrame_003Ed__11(int _003C_003E1__state)
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
		private GameObject main;

		[SerializeField]
		private Button homeButton;

		[SerializeField]
		private LayoutElement layoutElement;

		[SerializeField]
		private LayoutElement layoutElementDynamicQuest1;

		[SerializeField]
		private Canvas overrideCanvas;

		[SerializeField]
		private GraphicRaycaster graphicRaycaster;

		[SerializeField]
		private SequencerChannel returnedHomeSequencerChannel;

		[SerializeField]
		private List<NavigationChannel> navigationChannels;

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		private void OnReturnedHome()
		{
		}

		[IteratorStateMachine(typeof(_003CDoActionNextFrame_003Ed__11))]
		private IEnumerator DoActionNextFrame()
		{
			return null;
		}

		private bool IsChannelsEmpty()
		{
			return false;
		}

		private void OnDynamicQuestTimeClaimPopupClosed(DynamicQuestTimeEvents.OnDynamicQuestTimeClaimPopupClosed p)
		{
		}

		private void OnHomeButtonClicked()
		{
		}

		public void ShowUI()
		{
		}

		public void Hide()
		{
		}
	}
}
