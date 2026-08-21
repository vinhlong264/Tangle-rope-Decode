using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Crescive.Tutorials
{
	public class TutorialManager : MonoBehaviour
	{
		private ITutorialState? m_TutorialState;

		private TutorialStepManager? m_CurrentStepManager;

		[SerializeField]
		private List<TutorialStepManager> m_TutorialStepManagers;

		[SerializeField]
		private bool m_RegisterStepManagersOnEnableFromChildren;

		private TutorialStepManager? CurrentStepManager => null;

		public ITutorialState? TutorialState => null;

		public IReadOnlyList<TutorialStepManager> TutorialStepManagers => null;

		public event Action<TutorialStateChangedEvent>? TutorialStateChanged
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void Update()
		{
		}

		private bool NullableEquals<T>(T? a, T? b)
		{
			return false;
		}
	}
}
