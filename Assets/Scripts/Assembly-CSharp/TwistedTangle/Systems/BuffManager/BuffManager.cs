using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace TwistedTangle.Systems.BuffManager
{
	public class BuffManager : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CCheckBuffsRoutine_003Ed__13 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public BuffManager _003C_003E4__this;

			private WaitForSeconds _003Cwait_003E5__2;

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
			public _003CCheckBuffsRoutine_003Ed__13(int _003C_003E1__state)
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

		private const string BUFF_DATA_KEY = "BUFF_DATA";

		private static BuffManager _instance;

		public static BuffManager Instance => null;

		public static BuffDatas BuffData
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		private void Awake()
		{
		}

		public void AddBuff(BuffType buffType, float minutes)
		{
		}

		internal void RemoveBuff(BuffType buffType)
		{
		}

		public bool IsBuffActive(BuffType buffType)
		{
			return false;
		}

		public float GetBuffRemainingTime(BuffType buffType)
		{
			return 0f;
		}

		private void CleanExpiredBuffs()
		{
		}

		[IteratorStateMachine(typeof(_003CCheckBuffsRoutine_003Ed__13))]
		private IEnumerator CheckBuffsRoutine()
		{
			return null;
		}
	}
}
