using System.Collections.Generic;
using UnityAtoms;
using UnityAtoms.BaseAtoms;
using UnityEngine;
using UnityEngine.Events;

namespace CresciveCore
{
	public class LevelConditionListener : MonoBehaviour
	{
		[Header("References")]
		[SerializeField]
		private LevelSystem levelSystem;

		[Header("Settings")]
		[SerializeField]
		private IntReference minLevel;

		[SerializeField]
		[Header("Settings")]
		private IntReference maxLevel;

		[Header("Settings")]
		[SerializeField]
		private List<AtomCondition> conditions;

		[Header("Events")]
		public UnityEvent OnTrueMatchAtAwake;

		public UnityEvent OnFalseMatchAtAwake;

		public UnityEvent<bool> OnMatchOnAwake;

		public UnityEvent<bool> OnMatchReversedOnAwake;

		public UnityEvent OnTrueMatchAtStart;

		public UnityEvent OnFalseMatchAtStart;

		public UnityEvent<bool> OnMatchOnStart;

		public UnityEvent<bool> OnMatchReversedOnStart;

		public UnityEvent OnTrueMatchOnEnable;

		public UnityEvent OnFalseMatchOnEnable;

		public UnityEvent<bool> OnMatchOnEnable;

		public UnityEvent<bool> OnMatchReversedOnEnable;

		private bool Enabled => false;

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void Start()
		{
		}

		private void TriggerAwakeEvents()
		{
		}

		private void TriggerOnEnableEvents()
		{
		}

		private void TriggerStartEvents()
		{
		}
	}
}
