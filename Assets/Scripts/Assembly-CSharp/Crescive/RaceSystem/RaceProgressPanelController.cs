using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using TMPro;
using UnityEngine;

namespace Crescive.RaceSystem
{
	public class RaceProgressPanelController : MonoBehaviour
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CStartAnimations_003Ed__31 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

			public List<RacerData> racersOrdered;

			public RacerData playerRacerData;

			public RaceProgressPanelController _003C_003E4__this;

			public bool isFinish;

			public RaceSettingsData settings;

			private int _003CplayerRank_003E5__2;

			private UniTask.Awaiter _003C_003Eu__1;

			private List<RacerData>.Enumerator _003C_003E7__wrap2;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[SerializeField]
		private RaceSystem raceSystem;

		[SerializeField]
		private ConcurrencyHelpersBehaviour concurrencyHelpers;

		[Space]
		[Space]
		[SerializeField]
		private bool updateOnEnable;

		[Space]
		[SerializeField]
		private bool progressBarsInitialized;

		[SerializeField]
		private KittyLaneController kittyLaneController;

		[SerializeField]
		private Transform kittyParent;

		private Dictionary<string, KittyLaneController> _kittyLaneControllerDict;

		[SerializeField]
		private RectTransform grass;

		public bool OpenedByFinish;

		[SerializeField]
		private List<GameObject> closeGameObject;

		[SerializeField]
		private TMP_Text timerText;

		[SerializeField]
		private TMP_Text timerFinishText;

		[SerializeField]
		private TMP_Text raceText;

		[SerializeField]
		private TMP_Text raceFinishText;

		[SerializeField]
		private TMP_FontAsset japonFont;

		[SerializeField]
		private TMP_FontAsset normalFont;

		public KittyLaneController KittyLaneController { get; private set; }

		public int PlayerRank { get; private set; }

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void InitializeProgressBars(RacerData playerRacerData, List<RacerData> racersOrdered, RaceSettingsData settings)
		{
		}

		private KittyLaneController SafeInstantiateKitty(KittyLaneController prefab, Transform parent)
		{
			return null;
		}

		private void ResetKitties()
		{
		}

		public void UpdateRaceProgress()
		{
		}

		public void UpdateRaceFinishProgress()
		{
		}

		[AsyncStateMachine(typeof(_003CStartAnimations_003Ed__31))]
		private UniTaskVoid StartAnimations(List<RacerData> racersOrdered, RaceSettingsData settings, RacerData playerRacerData, bool isFinish = false)
		{
			return default(UniTaskVoid);
		}
	}
}
