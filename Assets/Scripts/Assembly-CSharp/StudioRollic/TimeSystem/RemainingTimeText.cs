using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace StudioRollic.TimeSystem
{
	public class RemainingTimeText : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CEndTimeRoutine_003Ed__22 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public RemainingTimeText _003C_003E4__this;

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
			public _003CEndTimeRoutine_003Ed__22(int _003C_003E1__state)
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
		private bool _useColon;

		[SerializeField]
		private bool _useSpace;

		[SerializeField]
		private bool _showAsHours;

		private Text _text;

		private TextMeshProUGUI _textTextMesh;

		private string _timerId;

		private float _timeRemaining;

		private DateTime _endDateTime;

		private string _endTime;

		private Action _onTimeEnded;

		private bool _initialized;

		private bool _convertToLocalTime;

		private string _stringFormat;

		public DateTime EndTime => default(DateTime);

		public void Initialize(bool convertToLocalTime = false, string stringFormat = "")
		{
		}

		public bool IsTimePassed()
		{
			return false;
		}

		public TimeSpan GetRemainingTime()
		{
			return default(TimeSpan);
		}

		public void SetEndTime(string timerId, string endTime, Action OnTimeEnded = null)
		{
		}

		public void SetEndTime(string timerId, DateTime endDateTime, Action OnTimeEnded = null)
		{
		}

		private void GetEndTime()
		{
		}

		public void SetText(string text)
		{
		}

		[IteratorStateMachine(typeof(_003CEndTimeRoutine_003Ed__22))]
		private IEnumerator EndTimeRoutine()
		{
			return null;
		}
	}
}
