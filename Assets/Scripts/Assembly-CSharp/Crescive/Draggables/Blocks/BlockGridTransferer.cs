using System;
using BrunoMikoski.AnimationSequencer;
using DG.Tweening;
using UnityEngine;

namespace Crescive.Draggables.Blocks
{
	[CreateAssetMenu(fileName = "BlockGridTransferer", menuName = "Draggables/Blocks/BlockGridTransferer")]
	public class BlockGridTransferer : ScriptableObject
	{
		[SerializeField]
		[Header("Settings")]
		private float duration;

		[SerializeField]
		private float blockPunchScale;

		[SerializeField]
		private float placeBlocksInterval;

		[SerializeField]
		private CustomEase placeMainItemEase;

		[SerializeField]
		private CustomEase placeBlocksEase;

		public Sequence Transfer(BlockGroup blockGroup, Action<Block> blockPlacingCallback, Action<Block> blockPlacedCallback, Action lastBlockPlacedCallback)
		{
			return null;
		}
	}
}
