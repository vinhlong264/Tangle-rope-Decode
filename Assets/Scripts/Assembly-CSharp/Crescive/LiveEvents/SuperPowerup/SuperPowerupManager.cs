using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Crescive.GameStates;
using Crescive.Navigation;
using Crescive.PowerUps;
using Crescive.Scheduler;
using Crescive.Sequencer;
using CresciveCore;
using UnityAtoms;
using UnityAtoms.BaseAtoms;
using UnityEngine;
using UnityEngine.Serialization;

namespace Crescive.LiveEvents.SuperPowerup
{
	public class SuperPowerupManager : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CSuperPowerUpCoroutine_003Ed__22 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public SuperPowerupManager _003C_003E4__this;

			public SequenceStep step;

			private List<string>.Enumerator _003C_003E7__wrap1;

			private PowerUpChannel _003CpowerUpChannel_003E5__3;

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
			public _003CSuperPowerUpCoroutine_003Ed__22(int _003C_003E1__state)
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

			private void _003C_003Em__Finally1()
			{
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[SerializeField]
		[Header("References")]
		private PowerUpSystem powerUpSystem;

		[SerializeField]
		private GameStateEvents gameStateEvents;

		[SerializeField]
		private SuperPowerupDataService superPowerupDataService;

		[SerializeField]
		private LevelSystem levelSystem;

		[SerializeField]
		private PersistentConsecutiveWinSaveData persistentConsecutiveWinSaveData;

		[SerializeField]
		[FormerlySerializedAs("navigationChannel")]
		private NavigationChannel menuPopUpNavigationChannel;

		[SerializeField]
		private StringReference superPowerupPanelId;

		[SerializeField]
		private StringReference superPowerupStartPanelId;

		[SerializeField]
		private SchedulerSystem schedulerSystem;

		[SerializeField]
		private VoidBaseEventReference loadedSceneReadyEvent;

		[SerializeField]
		private StringCompareCondition isSceneTypeHome;

		[SerializeField]
		private SequencerChannel returnedHomeSequencerChannel;

		[SerializeField]
		private VoidBaseEventReference levelGiveUpEvent;

		[SerializeField]
		private SequenceStep activateSuperPowerUpsStep;

		[SerializeField]
		private StringReference currentLevelDifficulty;

		[SerializeField]
		private StringReference hardLevelDifficulty;

		[SerializeField]
		private StringReference veryHardLevelDifficulty;

		[FormerlySerializedAs("superPowerUpEvents")]
		public SuperPowerUpSystem superPowerUpSystem;

		private void OnEnable()
		{
		}

		public bool WillExecute()
		{
			return false;
		}

		private void OnSuperPowerUpActivated(SequenceStep step)
		{
		}

		private PowerUpChannel GetPowerUp(string id)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CSuperPowerUpCoroutine_003Ed__22))]
		private IEnumerator SuperPowerUpCoroutine(SequenceStep step)
		{
			return null;
		}

		private void Start()
		{
		}

		private void OnDisable()
		{
		}

		private void OnDestroy()
		{
		}

		private void OnScheduleActivatedNow(ScheduleActivatedNowArgs args)
		{
		}

		private void OnScheduleExpiredNow(ScheduleExpiredNowArgs args)
		{
		}

		private void OnLevelPlay()
		{
		}

		private void OnSceneLoaded(UnityAtoms.Void _)
		{
		}

		private void OnLevelWin()
		{
		}

		private void Update()
		{
		}

		private void FakeLevelWin()
		{
		}

		private void OnGameOver()
		{
		}

		private void OnLevelGiveUp(UnityAtoms.Void _)
		{
		}

		private void OnReturnedHome()
		{
		}
	}
}
