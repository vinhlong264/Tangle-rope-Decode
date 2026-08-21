using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Crescive.LocalNotifications
{
	public class NotificationChannelsInitializer : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CCo_IOSRequestAuthorization_003Ed__3 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

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
			public _003CCo_IOSRequestAuthorization_003Ed__3(int _003C_003E1__state)
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

		private void Start()
		{
		}

		private void AndroidRequestAuthorization()
		{
		}

		private void AndroidInitializeNotificationChannel()
		{
		}

		[IteratorStateMachine(typeof(_003CCo_IOSRequestAuthorization_003Ed__3))]
		private IEnumerator Co_IOSRequestAuthorization()
		{
			return null;
		}
	}
}
