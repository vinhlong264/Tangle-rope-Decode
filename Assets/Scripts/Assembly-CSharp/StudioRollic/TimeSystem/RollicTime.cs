using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

namespace StudioRollic.TimeSystem
{
	public class RollicTime : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CGetUniversalTimeRoutine_003Ed__26 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public RollicTime _003C_003E4__this;

			public Action OnComplete;

			private UnityWebRequest _003CwebRequest_003E5__2;

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
			public _003CGetUniversalTimeRoutine_003Ed__26(int _003C_003E1__state)
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
		private sealed class _003CStartTimer_003Ed__24 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public RollicTime _003C_003E4__this;

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
			public _003CStartTimer_003Ed__24(int _003C_003E1__state)
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

		public static RollicTime Instance;

		private const string _timeUrl = "https://newapi.rollic.gs/v2/time";

		private Dictionary<string, RemainingTimeData> _remainingTimeDataCluster;

		private List<string> _endedTimerIdList;

		private string _dayStr;

		private string _hourStr;

		private string _dayLocStr;

		private string _hourLocStr;

		private DateTime _nowDateTime;

		private float _requestCompletedTime;

		public static Func<bool> OnIsRightToLeftLanguages;

		public static Func<string> OnHourTextLocalization;

		public static Func<string> OnDayTextLocalization;

		private DateTime _nowTime => default(DateTime);

		private DateTime _nowTimeLocal => default(DateTime);

		public bool IsResultComplete { get; private set; }

		public DateTime NowTime(bool isLocalTime)
		{
			return default(DateTime);
		}

		[RuntimeInitializeOnLoadMethod]
		private static void OnRuntimeInitialized()
		{
		}

		private void Awake()
		{
		}

		[IteratorStateMachine(typeof(_003CStartTimer_003Ed__24))]
		private IEnumerator StartTimer()
		{
			return null;
		}

		public void GetUniversalTime(Action OnComplete = null)
		{
		}

		[IteratorStateMachine(typeof(_003CGetUniversalTimeRoutine_003Ed__26))]
		private IEnumerator GetUniversalTimeRoutine(Action OnComplete)
		{
			return null;
		}

		internal void AddTimer(RemainingTimeData timeData)
		{
		}

		public void RemoveTimer(string timerId)
		{
		}

		private void ClearTimers()
		{
		}

		internal TimeSpan GetRemainingTime(string timerId)
		{
			return default(TimeSpan);
		}

		private void DisplayTime(float timeToDisplay, Text text, bool useColon, bool useSpace, bool showAsHours)
		{
		}

		private void DisplayTime(float timeToDisplay, TextMeshProUGUI text, bool useColon, bool useSpace, bool showAsHours)
		{
		}

		private void CheckDayHourStrings()
		{
		}
	}
}
