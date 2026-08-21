using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using TMPro;
using UnityEngine;

namespace FigmaImporter.Extras
{
	[RequireComponent(typeof(TMP_Text))]
	[ExecuteAlways]
	public class AnimatedTextView : TextView
	{
		[CompilerGenerated]
		private sealed class _003CWriteTextLetterByLetter_003Ed__12 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public AnimatedTextView _003C_003E4__this;

			private List<string> _003CelementList_003E5__2;

			private int _003Cindex_003E5__3;

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
			public _003CWriteTextLetterByLetter_003Ed__12(int _003C_003E1__state)
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
		private sealed class _003CWriteTextWithAlpha_003Ed__11 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public AnimatedTextView _003C_003E4__this;

			private List<string> _003CelementList_003E5__2;

			private int _003Cindex_003E5__3;

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
			public _003CWriteTextWithAlpha_003Ed__11(int _003C_003E1__state)
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
		private TMP_Text m_tmpText;

		private const string AlphaOpenBracket = "<alpha=#00>";

		private const float WriteTime = 0.03f;

		private Coroutine _typingCoroutine;

		private string _value;

		private Action _finishAction;

		public override void SetText(string text)
		{
		}

		public override void SetColor(Color value)
		{
		}

		public Tween WriteNumbers(int from, int newNumber, float time = 1f)
		{
			return null;
		}

		public void TypeText(string newText, Action finishAction = null)
		{
		}

		public void FinishTypeText()
		{
		}

		[IteratorStateMachine(typeof(_003CWriteTextWithAlpha_003Ed__11))]
		private IEnumerator WriteTextWithAlpha()
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CWriteTextLetterByLetter_003Ed__12))]
		private IEnumerator WriteTextLetterByLetter()
		{
			return null;
		}

		private float GetWriteSeconds(string tempElement, float f)
		{
			return 0f;
		}

		private static List<string> ParseElements(string value)
		{
			return null;
		}
	}
}
