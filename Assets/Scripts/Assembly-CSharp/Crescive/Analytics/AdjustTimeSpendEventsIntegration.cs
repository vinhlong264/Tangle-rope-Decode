using System.Collections.Generic;
using Crescive.GameStates;
using ElephantSDK;
using PersistentSO;
using UnityAtoms;
using UnityEngine;

namespace Crescive.Analytics
{
	public class AdjustTimeSpendEventsIntegration : MonoBehaviour
	{
		[SerializeField]
		private List<AdjustNumberEventData> data;

		[SerializeField]
		private List<AtomCondition> conditions;

		[SerializeField]
		private GameStateEvents gameStateEvents;

		[SerializeField]
		private PersistentIntVariable lastEventNumber;

		private static readonly string TimeSpend;

		private MetaDataUtils MetaDataUtils => null;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnApplicationFocus(bool hasFocus)
		{
		}

		private void SendTimeSpendEvents()
		{
		}
	}
}
