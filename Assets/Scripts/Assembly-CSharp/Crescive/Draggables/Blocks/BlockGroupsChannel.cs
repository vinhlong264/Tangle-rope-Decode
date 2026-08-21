using System.Collections.Generic;
using Crescive.Channels;
using UnityEngine;

namespace Crescive.Draggables.Blocks
{
	[CreateAssetMenu(fileName = "BlockGroupsChannel", menuName = "Draggables/Blocks/BlockGroupsChannel")]
	public class BlockGroupsChannel : ObjectsChannel<BlockGroup>
	{
		public IReadOnlyList<BlockGroup> FilledBlockGroups => null;

		public IEnumerable<BlockGroup> GetCanDragBlockGroupsOnBlockGrid()
		{
			return null;
		}
	}
}
