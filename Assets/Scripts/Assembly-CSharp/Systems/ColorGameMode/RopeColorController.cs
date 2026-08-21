using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Crescive.TwistedTangle;
using DG.Tweening;
using Obi;
using UnityEngine;

namespace Systems.ColorGameMode
{
	public class RopeColorController : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003COnSetupRopesRoutine_003Ed__26 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public RopeColorController _003C_003E4__this;

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
			public _003COnSetupRopesRoutine_003Ed__26(int _003C_003E1__state)
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
		public ObiRopeExtrudedRenderer obiRopeExtrudedRenderer;

		[SerializeField]
		public ObiRope obiRope;

		[SerializeField]
		public RopeConnection RopeConnection;

		[SerializeField]
		public RopePhysicToggler RopePhysicToggler;

		[SerializeField]
		public MeshRenderer RopeMeshRenderer;

		[SerializeField]
		private Material ColorableMaterial;

		[SerializeField]
		private Material OutlineMaterial;

		[SerializeField]
		private GameObject Fx;

		private static int ColorID;

		private static int Color2ID;

		private static int ColorMappingID;

		private static int Color2MappingID;

		private static int HighlightColorID;

		private static int ShadowColorID;

		private static int HColorID;

		private static int SColorID;

		private static int ColorDist;

		private Tween colorAnimation;

		private Tween colorAnimation2;

		private Tween delayedPinAnimation;

		private Tween delayedPinAnimation2;

		private bool isInitialized;

		private Material oldMaterial;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnSetupRopes()
		{
		}

		[IteratorStateMachine(typeof(_003COnSetupRopesRoutine_003Ed__26))]
		private IEnumerator OnSetupRopesRoutine()
		{
			return null;
		}

		public void OnRopeGrab()
		{
		}

		private void SetPinColor(PinEntity p, Color c, float t)
		{
		}

		public void OnRopePlaced()
		{
		}
	}
}
