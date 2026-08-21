using MyBox;
using UnityEngine;
using UnityEngine.Events;

namespace Crescive.Inputs
{
	[CreateAssetMenu(menuName = "GameData/Channel/PlayerInputData", fileName = "PlayerInputData")]
	public class PlayerInputData : ScriptableObject
	{
		[ReadOnly(new string[] { })]
		public float Horizontal;

		[ReadOnly(new string[] { })]
		public float Vertical;

		[ReadOnly(new string[] { })]
		public bool Holding;

		[ReadOnly(new string[] { })]
		public bool Released;

		[ReadOnly(new string[] { })]
		public bool Tapped;

		[ReadOnly(new string[] { })]
		public bool TappedRaw;

		public UnityEvent OnTapped;

		public UnityEvent OnTappedRaw;

		public UnityEvent OnReleased;
	}
}
